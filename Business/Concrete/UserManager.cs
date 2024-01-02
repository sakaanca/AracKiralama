using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;


namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }


        public List<OperationClaim> GetClaims(Core.Entities.Concrete.Users user)
        {
            return _userDal.GetClaims(user);
        }

        public void Add(Core.Entities.Concrete.Users user)
        {
             _userDal.Add(user);
        }

        public IUserDal Get_userDal()
        {
            return _userDal;
        }

        public Users GetuserDal()
        {
            return (Users)_userDal;
        }

        public Users GetByMail(string email, Users _userDal)
        {
            return  GetByMail(); ;
        }

        private Users GetByMail()
        {
            throw new NotImplementedException();
        }

        public Core.Entities.Concrete.Users GetByMail(string mail)
        {
            throw new NotImplementedException();
        }

        object IUserService.Get_userDal()
        {
            throw new NotImplementedException();
        }
    }
}
