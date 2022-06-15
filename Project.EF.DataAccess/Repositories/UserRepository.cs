using Project.EF.DataAccess.EFContext;
using Project.EF.DataAccess.Models;
using System.Collections.Generic;
using System.Linq;

namespace Project.EF.DataAccess.Repositories
{
    public class UserRepository : IUserRepository
    {
        
        EfContext _context;
        //We create the contructor
        public UserRepository(string connectionString) => _context = new EfContext(connectionString);

        public IEnumerable<m_User> getUserList()
        {
            return _context.user.ToList();
        }
    }
}
