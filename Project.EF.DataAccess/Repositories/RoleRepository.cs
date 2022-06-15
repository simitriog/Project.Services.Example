using Project.EF.DataAccess.EFContext;
using Project.EF.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.EF.DataAccess.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        EfContext _context;
        //We create the contructor
        public RoleRepository(string connectionString) => _context = new EfContext(connectionString);
        public IEnumerable<m_Role> getRoleList()
        {
            return _context.role.ToList();
        }
    }
}
