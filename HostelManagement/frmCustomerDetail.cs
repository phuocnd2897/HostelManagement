using HostelManagement.API;
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
    public partial class frmCustomerDetail : Form
    {
        private CustomerAPI _customerAPI;
        private CustomerResponseModel _customerResponseModel;
        private readonly AddressAPI addressAPI = new AddressAPI();
        private string _roomId;
        private ByteArrayContent imageString = null;
        public frmCustomerDetail(CustomerAPI customerAPI, string roomId, CustomerResponseModel customerResponseModel = null)
        {
            InitializeComponent();
            _customerAPI = customerAPI;
            _customerResponseModel = customerResponseModel;
            _roomId = roomId;
        }

        private void txtCusstomerName_Validated(object sender, EventArgs e)
        {
            if (txtCusstomerName.Text == "")
            {
                bunifuToolTip1.Show(txtCusstomerName, "Tên khách hàng không được để trống", "Lỗi dữ liệu trống",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                txtCusstomerName.Focus();
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

        private void txtPhoneNumber_Validated(object sender, EventArgs e)
        {
            if (txtPhoneNumber.Text == "")
            {
                bunifuToolTip1.Show(txtPhoneNumber, "Số điện thoại khách hàng không được để trống", "Lỗi dữ liệu trống",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                txtPhoneNumber.Focus();
            }
        }

        private void txtIdCard_Validated(object sender, EventArgs e)
        {
            if (txtIdCard.Text == "")
            {
                bunifuToolTip1.Show(txtIdCard, "CMND/Hộ chiếu khách hàng không được để trống", "Lỗi dữ liệu trống",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                txtIdCard.Focus();
            }
        }

        private void cbProvince_Validated(object sender, EventArgs e)
        {
            if (cbProvince.SelectedIndex == -1)
            {
                bunifuToolTip1.Show(cbProvince, "Tỉnh/ thành phố không được để trống", "Lỗi dữ liệu trống",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                cbProvince.Focus();
            }
        }

        private void cbDisstrict_Validated(object sender, EventArgs e)
        {
            if (cbDistrict.SelectedIndex == -1)
            {
                bunifuToolTip1.Show(cbDistrict, "Quận/ Huyện không được để trống", "Lỗi dữ liệu trống",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                cbDistrict.Focus();
            }
        }

        private void cbWard_Validated(object sender, EventArgs e)
        {
            if (cbWard.SelectedIndex == -1)
            {
                bunifuToolTip1.Show(cbWard, "Phường/ Xã không được để trống", "Lỗi dữ liệu trống",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                cbWard.Focus();
            }
        }

        private void txtAddress_Validated(object sender, EventArgs e)
        {
            if (txtAddress.Text == "")
            {
                bunifuToolTip1.Show(txtAddress, "Địa chỉ chi tiết khách hàng không được để trống", "Lỗi dữ liệu trống",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                txtAddress.Focus();
            }
        }

        private void dtBirthDate_Validated(object sender, EventArgs e)
        {
            if (dtBirthDate.Text == "")
            {
                bunifuToolTip1.Show(dtBirthDate, "Ngày sinh khách hàng không được để trống", "Lỗi dữ liệu trống",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                dtBirthDate.Focus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                dialog.InitialDirectory = @"D:\Study\PRN292\Project\HostelManagement\Image";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    pbImage.Image = Image.FromFile(dialog.FileName);
                    var gg = File.ReadAllBytes(dialog.FileName);
                    imageString = new ByteArrayContent(gg);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCusstomerName.Text == "")
            {
                bunifuToolTip1.Show(txtCusstomerName, "Tên khách hàng không được để trống", "Lỗi dữ liệu trống",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                txtCusstomerName.Focus();
            }
            else if (cbSex.SelectedIndex == -1)
            {
                bunifuToolTip1.Show(cbSex, "Giới tính không được để trống", "Lỗi dữ liệu trống",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                cbSex.Focus();
            }
            else if (txtPhoneNumber.Text == "")
            {
                bunifuToolTip1.Show(txtPhoneNumber, "Số điện thoại khách hàng không được để trống", "Lỗi dữ liệu trống",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                txtPhoneNumber.Focus();
            }
            else if (txtIdCard.Text == "")
            {
                bunifuToolTip1.Show(txtIdCard, "CMND/Hộ chiếu khách hàng không được để trống", "Lỗi dữ liệu trống",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                txtIdCard.Focus();
            }
            else if (cbProvince.SelectedIndex == -1)
            {
                bunifuToolTip1.Show(cbProvince, "Tỉnh/ thành phố không được để trống", "Lỗi dữ liệu trống",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                cbProvince.Focus();
            }
            else if (cbDistrict.SelectedIndex == -1)
            {
                bunifuToolTip1.Show(cbDistrict, "Quận/ Huyện không được để trống", "Lỗi dữ liệu trống",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                cbDistrict.Focus();
            }
            else if (cbWard.SelectedIndex == -1)
            {
                bunifuToolTip1.Show(cbWard, "Phường/ Xã không được để trống", "Lỗi dữ liệu trống",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                cbWard.Focus();
            }
            else if (txtAddress.Text == "")
            {
                bunifuToolTip1.Show(txtAddress, "Địa chỉ chi tiết khách hàng không được để trống", "Lỗi dữ liệu trống",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                txtAddress.Focus();
            }
            else if (dtBirthDate.Text == "")
            {
                bunifuToolTip1.Show(dtBirthDate, "Ngày sinh khách hàng không được để trống", "Lỗi dữ liệu trống",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                dtBirthDate.Focus();
            }
            else
            {
                try
                {
                    MultipartFormDataContent multipart = new MultipartFormDataContent();
                    multipart.Add(new StringContent(txtCusstomerName.Text), "FullName");
                    multipart.Add(new StringContent(dtBirthDate.Value.ToString("yyyy-MM-dd")), "BirthDate");
                    multipart.Add(new StringContent(cbSex.SelectedIndex.ToString()), "Sex");
                    multipart.Add(new StringContent(txtPhoneNumber.Text), "PhoneNumber");
                    multipart.Add(new StringContent(txtIdCard.Text), "IdCard");
                    multipart.Add(new StringContent(cbWard.SelectedValue.ToString()), "WardId");
                    multipart.Add(new StringContent(txtAddress.Text), "Address");
                    if (imageString != null)
                    {
                        multipart.Add(imageString, "Image", "fileImage");
                    }
                    multipart.Add(new StringContent("1"), "Status");
                    multipart.Add(new StringContent(this._roomId), "RoomId");
                    if (this._customerResponseModel == null)
                    {
                        var result = _customerAPI.AddCustomer(multipart);
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
                        multipart.Add(new StringContent(this._customerResponseModel.Id), "Id");
                        var result = _customerAPI.UpdateCustomer(multipart);
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
                cbDisstrict_SelectedIndexChanged(null, null);
            }
        }

        private void cbDisstrict_SelectedIndexChanged(object sender, EventArgs e)
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

        private void frmCustomerDetail_Load(object sender, EventArgs e)
        {
            var provinces = this.addressAPI.GetProvince();
            cbProvince.DataSource = provinces;
            cbProvince.DisplayMember = "Name";
            cbProvince.ValueMember = "Id";
            cbProvince.SelectedIndex = 0;
            cbProvince_SelectedIndexChanged(null, null);
            if (_customerResponseModel != null)
            {
                this.btnAdd.ButtonText = "Cập nhật";
                this.txtCusstomerName.Text = this._customerResponseModel.FullName;
                this.dtBirthDate.Value = this._customerResponseModel.BirthDate;
                this.cbSex.SelectedIndex = this._customerResponseModel.Sex;
                this.txtPhoneNumber.Text = this._customerResponseModel.PhoneNumber;
                this.txtIdCard.Text = this._customerResponseModel.IdCard;
                this.cbProvince.SelectedValue = this._customerResponseModel.ProvinceId;
                this.cbDistrict.SelectedValue = this._customerResponseModel.DistrictId;
                this.cbWard.SelectedValue = this._customerResponseModel.WardId;
                this.txtAddress.Text = this._customerResponseModel.Address;
                this.pbImage.ImageLocation = this._customerResponseModel.Image;
            }
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
