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
    public partial class RoomControl : UserControl
    {
        private RoomResponseModel _roomResponseModel;
        private RoomAPI _roomAPI;
        private FeeAPI _feeAPI;
        private frmMain _frmMain;
        public RoomControl(RoomResponseModel roomResponseModel, RoomAPI roomAPI, FeeAPI feeAPI, frmMain frmMain)
        {
            InitializeComponent();
            _roomResponseModel = roomResponseModel;
            _roomAPI = roomAPI;
            _feeAPI = feeAPI;
            _frmMain = frmMain;
        }

        private void RoomControl_Load(object sender, EventArgs e)
        {
            this.Width = this.Parent.Width;
            this.Name = this._roomResponseModel.Id;
            this.lbName.Text = this._roomResponseModel.Name;
            this.lbDescription.Text = this._roomResponseModel.Description;
            this.lbPrice.Text = this._roomResponseModel.Price.ToString();
            this.lbCapacity.Text = this._roomResponseModel.Capacity.ToString();
            this.lbNumberOfCustomer.Text = this._roomResponseModel.NumberOfCustomer.ToString();
            this.pbAvatar.ImageLocation = this._roomResponseModel.Avatar;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmRoomDetail frmRoomDetailControl = new frmRoomDetail(_roomAPI, _feeAPI, this.Name, this._roomResponseModel);
            frmRoomDetailControl.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRoomDetailControl_FormClosing);
            frmRoomDetailControl.ShowDialog();
        }
        private void frmRoomDetailControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            this._frmMain.frmMain_Load(null, null);
        }
    }
}
