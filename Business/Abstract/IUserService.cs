using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;
using Users = Core.Entities.Concrete.Users;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(Users user);
        void Add(Users user);
        Users GetByMail(string mail);
        object Get_userDal();
    }
}
