using HostelManagement.API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelManagement
{
    public partial class frmLogin : Form
    {
        private AppAccountAPI appAccountAPI = new AppAccountAPI();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (slideB.Left == 455)
            {
                slideA.Visible = false;
                slideA.Left = 455;

                slideB.Visible = false;
                slideB.Left = 31;
                slideB.Visible = true;
                slideB.Refresh();
                this.Size = new Size(452, 500);

                bunifuSeparator1.Left = bunifuThinButton22.Left;
                bunifuSeparator1.Width = bunifuThinButton22.Width;
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (slideA.Left == 455)
            {
                slideB.Visible = false;
                slideB.Left = 455;

                slideA.Visible = false;
                slideA.Left = 31;
                slideA.Visible = true;
                slideA.Refresh();
                this.Size = new Size(452, 792);

                bunifuSeparator1.Left = bunifuThinButton21.Left;
                bunifuSeparator1.Width = bunifuThinButton21.Width;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtUsernameRegis.Text.Trim() == "")
            {
                
            }
            appAccountAPI.SignUp(new )
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
