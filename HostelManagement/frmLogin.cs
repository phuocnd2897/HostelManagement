using HostelManagement.API;
using HostelManagement.Model.RequestModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Bunifu.UI.WinForms.BunifuSnackbar;

namespace HostelManagement
{
    public partial class frmLogin : Form
    {
        private readonly AppAccountAPI appAccountAPI = new AppAccountAPI();
        private readonly AddressAPI addressAPI = new AddressAPI();
        public frmLogin()
        {
            InitializeComponent();
            var provinces = this.addressAPI.GetProvince();
            cbProvince.DataSource = provinces;
            cbProvince.DisplayMember = "Name";
            cbProvince.ValueMember = "Id";
            cbProvince.SelectedIndex = 0;
            cbProvince_SelectedIndexChanged(null, null);
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
                MessageBox.Show("Tên tài khoản không được để trống", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtPasswordRegis.Text.Trim() == "")
            {
                bunifuSnackbar1.Show(this, "Mật khẩu không được để trống", MessageTypes.Warning);
            }
            else if (txtFullName.Text.Trim() == "")
            {
                bunifuSnackbar1.Show(this, "Họ và tên không được để trống", MessageTypes.Warning);
            }
            else if (cbProvince.Text.Trim() == "")
            {
                bunifuSnackbar1.Show(this, "Họ và tên không được để trống", MessageTypes.Warning);
            }
            else if (cbDistrict.Text.Trim() == "")
            {
                bunifuSnackbar1.Show(this, "Tỉnh/ thành phố không được để trống, MessageTypes.Warning");
            }
            else if (cbWard.Text.Trim() == "")
            {
                bunifuSnackbar1.Show(this, "", MessageTypes.Warning);
            }
            else if (txtAddress.Text.Trim() == "")
            {
                bunifuSnackbar1.Show(this, "Username is required", MessageTypes.Warning);
            }
            else if (txtEmail.Text.Trim() == "")
            {
                bunifuSnackbar1.Show(this, "Username is required", MessageTypes.Warning);
            }
            else
            {
                try
                {
                    var result = appAccountAPI.SignUp(new AppAccountRequestModel
                    {
                        Username = txtUsernameRegis.Text,
                        Password = txtPasswordRegis.Text,
                        FullName = txtFullName.Text,
                        BirthDate = dtBirthDate.Value,
                        Sex = cbSex.SelectedIndex + 1,
                        WardId = int.Parse(cbWard.SelectedValue.ToString()),
                        Address = txtAddress.Text,
                        Email = txtEmail.Text
                    });
                    if (result != null)
                    {
                        bunifuThinButton21_Click(null, null);
                    }
                }
                catch
                {
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Tên tài khoản không được để trống", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Mật khẩu không được để trống", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    var result = appAccountAPI.Login(new LoginRequsetModel
                    {
                        Username = txtUsername.Text,
                        Password = txtPassword.Text
                    });
                    if (result == null)
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        frmMain frmMain = new frmMain(result.Token);
                        frmMain.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProvince.SelectedValue != null && int.TryParse(cbProvince.SelectedValue.ToString(), out int a) == true)
            {
                cbDistrict.Enabled = true;
                cbDistrict.DataSource = this.addressAPI.GetDistrictByProvinceID(cbProvince.SelectedValue.ToString()).ToList();
                cbDistrict.DisplayMember = "Name";
                cbDistrict.ValueMember = "Id";
                cbDistrict.SelectedIndex = 0;
                cbDistrict_SelectedIndexChanged(null, null);
            }
        }

        private void cbDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDistrict.SelectedValue != null && int.TryParse(cbDistrict.SelectedValue.ToString(), out int a) == true)
            {
                cbWard.Enabled = true;
                cbWard.DataSource = this.addressAPI.GetWardByDistrictID(cbDistrict.SelectedValue.ToString()).ToList();
                cbWard.DisplayMember = "Name";
                cbWard.ValueMember = "Id";
                cbWard.SelectedIndex = 0;
            }
        }
    }
}
