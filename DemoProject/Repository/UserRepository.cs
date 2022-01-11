using DemoProject.Data;
using DemoProject.Interface;
using System.Linq;

namespace DemoProject.Repository
{
    public class UserRepository : IUser
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public UserRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;   
        }
        public int Count()
        {
            return _applicationDbContext.UserDetails.ToList().Count();
        }

        public void DeleteById(int Id)
        {
            throw new System.NotImplementedException();
        }

        public void GetAll()
        {
            throw new System.NotImplementedException();
        }

        public int UpdateById(int Id)
        {
            throw new System.NotImplementedException();
        }
    }
}
