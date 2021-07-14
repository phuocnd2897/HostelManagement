using HostelManagement.API;
using HostelManagement.Model.RequestModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                bunifuToolTip1.Show(txtUsernameRegis, "Tên tài khoản không được để trống", "Lỗi dữ liệu trống",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                txtUsernameRegis.Focus();
            }
            else if (txtPasswordRegis.Text.Trim() == "")
            {
                bunifuToolTip1.Show(txtPasswordRegis, "Mật khẩu không được để trống", "Lỗi dữ liệu trống",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                txtPasswordRegis.Focus();
            }
            else if (txtFullName.Text.Trim() == "")
            {
                bunifuToolTip1.Show(txtFullName, "Họ tên không được để trống", "Lỗi dữ liệu trống",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                txtFullName.Focus();
            }
            else if (dtBirthDate.Text.Trim() == "")
            {
                bunifuToolTip1.Show(dtBirthDate, "Ngày sinh không được để trống", "Lỗi dữ liệu trống",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                dtBirthDate.Focus();
            }
            else if (cbSex.SelectedIndex == -1)
            {
                bunifuToolTip1.Show(cbSex, "Giới tính không được để trống", "Lỗi dữ liệu trống",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                cbSex.Focus();
            }
            else if (cbProvince.SelectedIndex == -1)
            {
                bunifuToolTip1.Show(cbProvince, "Tỉnh/Thành không được để trống", "Lỗi dữ liệu trống",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                cbProvince.Focus();
            }
            else if (cbDistrict.SelectedIndex == -1)
            {
                bunifuToolTip1.Show(cbDistrict, "Quận/Huyện không được để trống", "Lỗi dữ liệu trống",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                cbDistrict.Focus();
            }
            else if (cbWard.SelectedIndex == -1)
            {
                bunifuToolTip1.Show(cbWard, "Phường/Xã không được để trống", "Lỗi dữ liệu trống",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                cbWard.Focus();
            }
            else if (txtAddress.Text.Trim() == "")
            {
                bunifuToolTip1.Show(txtAddress, "Địa chỉ không được để trống", "Lỗi dữ liệu trống",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                txtAddress.Focus();
            }
            else if (txtEmail.Text.Trim() == "")
            {
                bunifuToolTip1.Show(txtEmail, "Email không được để trống", "Lỗi dữ liệu trống",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                txtEmail.Focus();
            }
            else
            {
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(txtEmail.Text.Trim());
                if (!match.Success)
                {
                    bunifuToolTip1.Show(txtEmail, "Email không đúng định dạng", "Lỗi sai dữ liệu trống",
                    Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                    txtEmail.Focus();
                }
                else
                {
                    try
                    {
                        var result = appAccountAPI.SignUp(new AppAccountRequestModel
                        {
                            Username = txtUsernameRegis.Text.Trim(),
                            Password = txtPasswordRegis.Text.Trim(),
                            FullName = txtFullName.Text.Trim(),
                            BirthDate = dtBirthDate.Value,
                            Sex = cbSex.SelectedIndex + 1,
                            WardId = int.Parse(cbWard.SelectedValue.ToString()),
                            Address = txtAddress.Text.Trim(),
                            Email = txtEmail.Text.Trim()
                        });
                        if (result != null)
                        {
                            bunifuSnackbar1.Show(this, "Tạo tài khoản mới thành công", MessageTypes.Success);
                            bunifuThinButton21_Click(null, null);
                        }
                        else
                        {
                            bunifuSnackbar1.Show(this, "Tạo tài khoản mới thất bại. Vui vòng kiểm tra lại", MessageTypes.Error);
                        }
                    }
                    catch
                    {
                    }
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "")
            {
                bunifuToolTip1.Show(txtUsername, "Tên tài khoản không được để trống", "Lỗi dữ liệu trống",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                txtUsername.Focus();
            }
            else if (txtPassword.Text.Trim() == "")
            {
                bunifuToolTip1.Show(txtPassword, "Mật khẩu không được để trống", "Lỗi dữ liệu trống",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                txtPassword.Focus();
            }
            else
            {
                try
                {
                    var result = appAccountAPI.Login(new LoginRequsetModel
                    {
                        Username = txtUsername.Text.Trim(),
                        Password = txtPassword.Text.Trim()
                    });
                    if (result == null)
                    {
                        bunifuSnackbar1.Show(this, "Tài khoản hoặc mật khẩu không đúng. Vui vòng kiểm tra lại", MessageTypes.Error);
                    }
                    else
                    {
                        frmMain frmMain = new frmMain(result.Token);
                        frmMain.Show();
                        this.Hide();
                    }
                }
                catch
                {
                    bunifuSnackbar1.Show(this, "Tài khoản hoặc mật khẩu không đúng. Vui vòng kiểm tra lại", MessageTypes.Error);
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

        private void txtUsernameRegis_Validated(object sender, EventArgs e)
        {
            if (txtUsernameRegis.Text.Trim() == "")
            {
                bunifuToolTip1.Show(txtUsernameRegis, "Tên tài khoản không được để trống", "Lỗi dữ liệu trống",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                txtUsernameRegis.Focus();
            }
        }

        private void txtPasswordRegis_Validated(object sender, EventArgs e)
        {
            if (txtPasswordRegis.Text.Trim() == "")
            {
                bunifuToolTip1.Show(txtPasswordRegis, "Mật khẩu không được để trống", "Lỗi dữ liệu trống",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                txtPasswordRegis.Focus();
            }
        }

        private void txtFullName_Validated(object sender, EventArgs e)
        {
            if (txtFullName.Text.Trim() == "")
            {
                bunifuToolTip1.Show(txtFullName, "Họ tên không được để trống", "Lỗi dữ liệu trống",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                txtFullName.Focus();
            }
        }

        private void dtBirthDate_Validated(object sender, EventArgs e)
        {
            if (dtBirthDate.Text.Trim() == "")
            {
                bunifuToolTip1.Show(dtBirthDate, "Ngày sinh không được để trống", "Lỗi dữ liệu trống",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                dtBirthDate.Focus();
            }
        }

        private void cbSex_Validated(object sender, EventArgs e)
        {
            if (cbSex.SelectedIndex == -1)
            {
                bunifuToolTip1.Show(cbSex, "Giới tính không được để trống", "Lỗi dữ liệu trống",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                cbSex.Focus();
            }
        }

        private void cbProvince_Validated(object sender, EventArgs e)
        {
            if (cbProvince.SelectedIndex == -1)
            {
                bunifuToolTip1.Show(cbProvince, "Tỉnh/Thành không được để trống", "Lỗi dữ liệu trống",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                cbProvince.Focus();
            }
        }

        private void cbDistrict_Validated(object sender, EventArgs e)
        {
            if (cbDistrict.SelectedIndex == -1)
            {
                bunifuToolTip1.Show(cbDistrict, "Quận/Huyện không được để trống", "Lỗi dữ liệu trống",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                cbDistrict.Focus();
            }
        }

        private void cbWard_Validated(object sender, EventArgs e)
        {
            if (cbWard.SelectedIndex == -1)
            {
                bunifuToolTip1.Show(cbWard, "Phường/Xã không được để trống", "Lỗi dữ liệu trống",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                cbWard.Focus();
            }
        }

        private void txtAddress_Validated(object sender, EventArgs e)
        {
            if (txtAddress.Text.Trim() == "")
            {
                bunifuToolTip1.Show(txtAddress, "Địa chỉ không được để trống", "Lỗi dữ liệu trống",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                txtAddress.Focus();
            }
            
        }

        private void txtEmail_Validated(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim() == "")
            {
                bunifuToolTip1.Show(txtEmail, "Email không được để trống", "Lỗi dữ liệu trống",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                txtEmail.Focus();
            }
            else
            {
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(txtEmail.Text.Trim());
                if (!match.Success)
                {
                    bunifuToolTip1.Show(txtEmail, "Email không đúng định dạng", "Lỗi sai dữ liệu trống",
                    Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                    txtEmail.Focus();
                }
            }
        }
    }
}
