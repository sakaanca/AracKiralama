﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.JWT;
using Entities.DTOs;

namespace Business.Concrete
{
    public class AuthManager:IAuthService
    {
        private IUserService _userService;
        private ITokenHelper _tokenHelper;

        public AuthManager(IUserService userService, ITokenHelper tokenHelper)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
        }

        public IDataResult<Users> Register(UserForRegisterDto userForRegisterDto, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password,out passwordHash,out passwordSalt);
            var user = new Users
            {
                    Email = userForRegisterDto.Email,
                    FirstName = userForRegisterDto.FirstName,
                    LastName = userForRegisterDto.LastName,
                    PasswordHash = passwordHash,
                    PasswordSalt = passwordSalt,
                    Status = true
            };
            _userService.Add(user);
            return new SuccessDataResult<Users>(user, Messages.UserRegistered);
        }

        //public IDataResult<Users> Login(UserForLoginDto userForLoginDto)
        //{
        //    var userToCheck = _userService.GetByMail(userForLoginDto.Email, _userService.Get_userDal(), _userService.Get_userDal());
        //    if (userToCheck==null)
        //    {
        //        return new ErrorDataResult<Users>(Messages.UserNotFound);
        //    }

        //    if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password,userToCheck.PasswordHash,userToCheck.PasswordSalt))
        //    {
        //        return new ErrorDataResult<Users>(Messages.PasswordError);
        //    }

        //    return new SuccessDataResult<Users>(userToCheck, Messages.SuccessfulLogin);
        //}

        //public IResult UserExists(string email)
        //{
        //    if (_userService.GetByMail(email, _userService.Get_userDal(), _userService.Get_userDal()) !=null)
        //    {
        //        return new ErrorResult(Messages.UserAlredyExists);
        //    }

        //    return new SuccessResult();
        //}

        public IDataResult<AccessToken> CreateAccessToken(Users user)
        {
            var claims = _userService.GetClaims(user);
            var accessToken = _tokenHelper.CreateToken(user, claims);
            return new SuccessDataResult<AccessToken>(accessToken, Messages.AccessTokenCreated);
        }

        public IDataResult<Users> Login(UserForLoginDto userForLoginDto)
        {
            throw new NotImplementedException();
        }

        public IResult UserExists(string email)
        {
            throw new NotImplementedException();
        }
    }
}
