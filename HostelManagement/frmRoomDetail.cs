using HostelManagement.API;
using HostelManagement.Model.RequestModel;
using HostelManagement.Model.ResponseModel;
using Newtonsoft.Json;
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
    public partial class frmRoomDetail : Form
    {
        private string _hostelId;
        private FeeAPI _feeAPI;
        private RoomAPI _roomAPI;
        private List<FeeRequestModel> listFeeRequestModel = new List<FeeRequestModel>();
        private ByteArrayContent imageString = null;
        private RoomResponseModel _roomResponseModel;
        public frmRoomDetail(RoomAPI roomAPI, FeeAPI feeAPI, string hostelId, RoomResponseModel roomResponseModel = null)
        {
            InitializeComponent();
            _feeAPI = feeAPI;
            _hostelId = hostelId;
            _roomAPI = roomAPI;
            _roomResponseModel = roomResponseModel;
            listFeeRequestModel = _feeAPI.GetAllFee();
            cbFee.Properties.DataSource = listFeeRequestModel;
            cbFee.Properties.DisplayMember = "Name";
            cbFee.Properties.ValueMember = "Id";
        }

        private void txtRoomName_Validated(object sender, EventArgs e)
        {
            if (txtRoomName.Text == "")
            {
                bunifuToolTip1.Show(txtRoomName, "Tên phòng không được để trống", "Lỗi dữ liệu trống",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                txtRoomName.Focus();
            }
        }

        private void nmCapacity_Validated(object sender, EventArgs e)
        {
            if (nmCapacity.Value <= 0)
            {
                bunifuToolTip1.Show(nmCapacity, "Số lượng khách tối đa lớn hơn 0", "Lỗi sai dữ liệu",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                txtRoomName.Focus();
            }
        }

        private void txtPrice_Validated(object sender, EventArgs e)
        {
            if (txtPrice.Text == "")
            {
                bunifuToolTip1.Show(txtPrice, "Giá phòng không được để trống", "Lỗi dữ liệu trống",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                txtPrice.Focus();
            }
            else if (float.Parse(txtPrice.Text) <= 0)
            {
                bunifuToolTip1.Show(txtPrice, "Giá phòng không được nhỏ hơn hoặc bằng 0", "Lỗi sai dữ liệu",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                txtPrice.Focus();
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void cbFee_Validated(object sender, EventArgs e)
        {
            if (cbFee.Properties.Items.Where(s => s.CheckState == CheckState.Checked).Count() <= 0)
            {
                bunifuToolTip1.Show(cbFee, "Vui lòng chọn các loại chi phi có thể phát sinh", "Lỗi sai dữ liệu",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                cbFee.Focus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtRoomName.Text == "")
            {
                bunifuToolTip1.Show(txtRoomName, "Tên phòng không được để trống", "Lỗi dữ liệu trống",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                txtRoomName.Focus();
            }
            else if(nmCapacity.Value <= 0)
            {
                bunifuToolTip1.Show(nmCapacity, "Số lượng khách tối đa lớn hơn 0", "Lỗi sai dữ liệu",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                txtRoomName.Focus();
            }
            else if (txtPrice.Text == "")
            {
                bunifuToolTip1.Show(txtPrice, "Giá phòng không được để trống", "Lỗi dữ liệu trống",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                txtPrice.Focus();
            }
            else if (float.Parse(txtPrice.Text) <= 0)
            {
                bunifuToolTip1.Show(txtPrice, "Giá phòng không được nhỏ hơn hoặc bằng 0", "Lỗi sai dữ liệu",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                txtPrice.Focus();
            }
            else if (cbFee.Properties.Items.Where(s => s.CheckState == CheckState.Checked).Count() <= 0)
            {
                bunifuToolTip1.Show(cbFee, "Vui lòng chọn các loại chi phi có thể phát sinh", "Lỗi sai dữ liệu",
                Image.FromFile(@"D:\Study\PRN292\Project\HostelManagement\HostelManagement\Image\Paomedia-Small-N-Flat-Sign-warning.ico"));
                cbFee.Focus();
            }
            else
            {
                try
                {
                    int[] feeIds = cbFee.Properties.Items.Where(s => s.CheckState == CheckState.Checked).Select(s => (int)s.Value).ToArray();
                    MultipartFormDataContent multipart = new MultipartFormDataContent();
                    multipart.Add(new StringContent(txtRoomName.Text), "Name");
                    multipart.Add(new StringContent(txtDescription.Text), "Description");
                    multipart.Add(imageString, "Avatar", "fileImage");
                    multipart.Add(new StringContent(nmCapacity.Value.ToString()), "Capacity");
                    multipart.Add(new StringContent(txtPrice.Text), "Price");
                    multipart.Add(new StringContent(this._hostelId), "HostelId");
                    multipart.Add(new StringContent(JsonConvert.SerializeObject(feeIds)), "FeeIds");
                    var result = _roomAPI.AddRoom(multipart);
                    if (result != null)
                    {
                        bunifuSnackbar1.Show(this, "Thêm mới thành công", MessageTypes.Success);
                    }
                    else
                    {
                        bunifuSnackbar1.Show(this, "Có lỗi xảy ra khi thêm mới. Vui lòng kiểm tra lại", MessageTypes.Error);
                    }
                }
                catch (Exception ex)
                {
                    bunifuSnackbar1.Show(this, "Có lỗi xảy ra khi thêm mới. Vui lòng kiểm tra lại", MessageTypes.Error);
                }
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

        private void frmRoomDetailControl_Load(object sender, EventArgs e)
        {
            
            if (_roomResponseModel != null)
            {
                this.btnAdd.ButtonText = "Cập nhật";
                this.txtDescription.Text = _roomResponseModel.Description;
                this.nmCapacity.Value = _roomResponseModel.Capacity;
                this.txtPrice.Text = _roomResponseModel.Price.ToString();
                foreach (var item in this.cbFee.Properties.Items.Where(s => _roomResponseModel.Fees.Contains((int)s.Value)))
                {
                    item.CheckState = CheckState.Checked;
                }
                this.pictureBox1.ImageLocation = _roomResponseModel.Avatar;
            }
        }
    }
}
