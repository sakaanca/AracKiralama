using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;
using Entities.Concrete;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal:EfEntityRepositoryBase<Core.Entities.Concrete.Users,RentACarContext>,IUserDal
    {
        public void Add(Entities.Concrete.User entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Entities.Concrete.User entity)
        {
            throw new NotImplementedException();
        }

        public Entities.Concrete.User Get(Expression<Func<Entities.Concrete.User, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Entities.Concrete.User> GetAll(Expression<Func<Entities.Concrete.User, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<OperationClaim> GetClaims(Core.Entities.Concrete.Users user)
        {
            using (var context = new RentACarContext())
            {
                var result = from operationClaim in context.OperationClaims
                    join userOperationClaim in context.UserOperationClaims
                        on operationClaim.Id equals userOperationClaim.Id
                    where userOperationClaim.UserId == user.Id
                    select new OperationClaim() { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();
            }
        }

        public void Update(Entities.Concrete.User entity)
        {
            throw new NotImplementedException();
        }
    }
}
