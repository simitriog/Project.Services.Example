using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.EF.DataAccess.Models
{
    public class m_Role
    {
        [Key]
        public int id_Role { get; set; }
        public string ftn_Role { get; set; }
        public string ftn_Code { get; set; }
    }
}
