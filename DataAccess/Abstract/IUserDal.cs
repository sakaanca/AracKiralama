using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IUserDal:IEntityRepository<Entities.Concrete.User>
    {
        void Add(Core.Entities.Concrete.Users user);
        public List<OperationClaim> GetClaims(Core.Entities.Concrete.Users user);
       
    }
}
