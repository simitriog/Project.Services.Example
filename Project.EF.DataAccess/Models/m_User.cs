using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.EF.DataAccess.Models
{
    public class m_User
    {
        [Key]
        public int id_User { get; set; }
        public string ftn_User { get; set; }
        public string ftn_Password { get; set; }
        public string ftn_Role { get; set; }
        public bool ftn_IsActive { get; set; }
    }
}
