using HostelManagement.API;
using HostelManagement.Model.RequestModel;
using HostelManagement.Model.ResponseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Bunifu.UI.WinForms.BunifuSnackbar;

namespace HostelManagement
{
    public partial class frmHostelDetail : Form
    {
        private ByteArrayContent imageString = null;
        private HostelAPI _hostelAPI;
        private readonly AddressAPI addressAPI = new AddressAPI();
        private HostelResponseModel _hostelResponseModel;
        public frmHostelDetail(HostelAPI hostelAPI, HostelResponseModel hostelResponseModel = null)
        {
            InitializeComponent();
            _hostelAPI = hostelAPI;
            _hostelResponseModel = hostelResponseModel;
            
        }

        private void txtHostelName_Validated(object sender, EventArgs e)
        {
            if (txtHostelName.Text == "")
            {
                bunifuToolTip1.Show(txtHostelName, "Tên nhà trọ không được để trống", "Lỗi dữ liệu trống",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                txtHostelName.Focus();
            }  
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbProvince_Validated(object sender, EventArgs e)
        {
            if (cbProvince.Text == "")
            {
                bunifuToolTip1.Show(cbProvince, "Tỉnh / Thành phố không được để trống", "Dữ liệu trống",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                cbProvince.Focus();
            }
        }

        private void cbDistrict_Validated(object sender, EventArgs e)
        {
            if (cbDistrict.Text == "")
            {
                bunifuToolTip1.Show(cbDistrict, "Quận / Huyện không được để trống", "Dữ liệu trống",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                cbDistrict.Focus();
            }
        }

        private void cbWard_Validated(object sender, EventArgs e)
        {
            if (cbWard.Text == "")
            {
                bunifuToolTip1.Show(cbWard, "Phường / Xã không được để trống", "Dữ liệu trống",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                cbWard.Focus();
            }
        }

        private void txtAddress_Validated(object sender, EventArgs e)
        {
            if (txtAddress.Text == "")
            {
                bunifuToolTip1.Show(txtAddress, "Địa chỉ không được để trống", "Lỗi dữ liệu trống",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                txtAddress.Focus();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                dialog.InitialDirectory = @"D:\Study\PRN292\Project\HostelManagement\Image";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(dialog.FileName);
                    var gg = File.ReadAllBytes(dialog.FileName);
                    imageString = new ByteArrayContent(gg);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtHostelName.Text == "")
            {
                bunifuToolTip1.Show(txtHostelName, "Tên nhà trọ không được để trống", "Lỗi dữ liệu trống",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                txtHostelName.Focus();
            }
            else if (cbProvince.Text == "")
            {
                bunifuToolTip1.Show(cbProvince, "Tỉnh / Thành phố không được để trống", "Dữ liệu trống",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                cbProvince.Focus();
            }
            else if (cbDistrict.Text == "")
            {
                bunifuToolTip1.Show(cbDistrict, "Quận / Huyện không được để trống", "Dữ liệu trống",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                cbDistrict.Focus();
            }
            else if (cbWard.Text == "")
            {
                bunifuToolTip1.Show(cbWard, "Phường / Xã không được để trống", "Dữ liệu trống",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                cbWard.Focus();
            }
            else if (txtAddress.Text == "")
            {
                bunifuToolTip1.Show(txtAddress, "Địa chỉ không được để trống", "Lỗi dữ liệu trống",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                txtAddress.Focus();
            }
            else
            {
                try
                {
                    MultipartFormDataContent multipart = new MultipartFormDataContent();
                    multipart.Add(new StringContent(txtHostelName.Text), "Name");
                    multipart.Add(new StringContent(cbWard.SelectedValue.ToString()), "WardId");
                    multipart.Add(new StringContent(txtAddress.Text), "Address");
                    if (imageString != null)
                    {
                        multipart.Add(imageString, "Avatar", "fileImage");
                    }
                    multipart.Add(new StringContent("1"), "Status");
                    if (this._hostelResponseModel == null)
                    {
                        var result = _hostelAPI.AddHostel(multipart);
                        if (result != null)
                        {
                            bunifuSnackbar1.Show(this, "Thêm mới thành công", MessageTypes.Success);
                            this.Close();
                        }
                        else
                        {
                            bunifuSnackbar1.Show(this, "Có lỗi xảy ra khi thêm mới. Vui lòng kiểm tra lại", MessageTypes.Error);
                        }
                    }
                    else
                    {
                        multipart.Add(new StringContent(this._hostelResponseModel.Id), "Id");
                        var result = _hostelAPI.UpdateHostel(multipart);
                        if (result != null)
                        {
                            bunifuSnackbar1.Show(this, "Cập nhật thành công", MessageTypes.Success);
                            this.Close();
                        }
                        else
                        {
                            bunifuSnackbar1.Show(this, "Có lỗi xảy ra khi Cập nhật. Vui lòng kiểm tra lại", MessageTypes.Error);
                        }
                    }
                    
                }
                catch
                {
                    bunifuSnackbar1.Show(this, "Có lỗi xảy ra khi thêm mới. Vui lòng kiểm tra lại", MessageTypes.Error);
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

        private void frmHostelDetailUserControl_Load(object sender, EventArgs e)
        {
            var provinces = this.addressAPI.GetProvince();
            cbProvince.DataSource = provinces;
            cbProvince.DisplayMember = "Name";
            cbProvince.ValueMember = "Id";
            cbProvince.SelectedIndex = 0;
            cbProvince_SelectedIndexChanged(null, null);
            if (_hostelResponseModel != null)
            {
                this.btnAdd.ButtonText = "Cập nhật";
                this.txtHostelName.Text = _hostelResponseModel.Name;
                this.cbProvince.SelectedValue = _hostelResponseModel.ProvinceId;
                this.cbDistrict.SelectedValue = _hostelResponseModel.DistrictId;
                this.cbWard.SelectedValue = _hostelResponseModel.WardId;
                this.txtAddress.Text = _hostelResponseModel.Address;
                this.pictureBox1.ImageLocation = _hostelResponseModel.Avatar;
            }
        }
    }
}

