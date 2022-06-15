using Project.EF.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.EF.DataAccess.EFContext
{
    public class EfContext : DbContext
    {
        public EfContext(string connectionString) : base(connectionString)
        {
            Database.SetInitializer<EfContext>(null);
        }

        public  DbSet<m_User> user { get; set; }
        public DbSet<m_Role> role { get; set; }
    }
}
