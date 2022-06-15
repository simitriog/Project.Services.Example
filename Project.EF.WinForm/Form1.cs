using Project.EF.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.EF.WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IUserRepository user = new UserRepository("db_example");
            IRoleRepository role = new RoleRepository("db_example");
            var userList = user.getUserList();
            var roleList = role.getRoleList();

            dtwUser.DataSource = userList.ToList();
            dtwRole.DataSource = roleList.ToList();

        }
    }
}
