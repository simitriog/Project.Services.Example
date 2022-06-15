using Project.EF.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.EF.DataAccess.Repositories
{
    public interface IRoleRepository
    {
        IEnumerable<m_Role> getRoleList();
    }
}
