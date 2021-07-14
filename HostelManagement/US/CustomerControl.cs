using HostelManagement.API;
using HostelManagement.Model.ResponseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelManagement.US
{
    public partial class CustomerControl : UserControl
    {
        private CustomerResponseModel _customerResponseModel;
        private CustomerAPI _customerAPI;
        private frmMain _frmMain;
        private string _roomId;
        public CustomerControl(CustomerResponseModel customerResponseModel, string roomId, CustomerAPI customerAPI, frmMain frmMain)
        {
            InitializeComponent();
            _customerResponseModel = customerResponseModel;
            _customerAPI = customerAPI;
            _frmMain = frmMain;
            _roomId = roomId;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmCustomerDetail frmCustomerDetail = new frmCustomerDetail(this._customerAPI, _roomId, this._customerResponseModel);
            frmCustomerDetail.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCustomerDetail_FormClosing);
            frmCustomerDetail.ShowDialog();
        }
        private void frmCustomerDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            this._frmMain.frmMain_Load(null, null);
        }

        private void CustomerControl_Load(object sender, EventArgs e)
        {
            this.Width = this.Parent.Width;
            lbHoTen.Text = this._customerResponseModel.FullName;
            lbBirthDate.Text = this._customerResponseModel.BirthDate.ToString("dd/MM/yyyy");
            lbSex.Text = this._customerResponseModel.Sex == 0 ? "Nam" : this._customerResponseModel.Sex == 1 ? "Nữ" : "Khác" ;
            lbIdCard.Text = this._customerResponseModel.IdCard;
            lbAddress.Text = this._customerResponseModel.Address + "," + this._customerResponseModel.WardName + ","
                + this._customerResponseModel.DistrictName + "," + this._customerResponseModel.ProvinceName;
            lbPhoneNumber.Text = this._customerResponseModel.PhoneNumber;
            pbAvatar.ImageLocation = this._customerResponseModel.Image;
        }
    }
}
