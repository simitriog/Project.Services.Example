using Project.EF.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.EF.DataAccess.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<m_User> getUserList();
    }
}
