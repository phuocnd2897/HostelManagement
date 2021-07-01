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
    public partial class HostelControl : UserControl
    {
        private HostelResponseModel _hostelResponseModel;
        private HostelAPI _hostelAPI;
        private frmMain _frmMain;
        public HostelControl(HostelResponseModel hostelResponseModel, HostelAPI hostelAPI, frmMain frmMain)
        {
            InitializeComponent();
            _hostelResponseModel = hostelResponseModel;
            _hostelAPI = hostelAPI;
            _frmMain = frmMain;
        }

        private void HostelControl_Load(object sender, EventArgs e)
        {
            this.Width = this.Parent.Width;
            this.Name = this._hostelResponseModel.Id;
            this.lbName.Text = this._hostelResponseModel.Name;
            this.lbAddress.Text = this._hostelResponseModel.Address + "," + this._hostelResponseModel.WardName + "," 
                + this._hostelResponseModel.DistrictName + "," + this._hostelResponseModel.ProvinceName;
            this.lbNumberOfRoom.Text = this._hostelResponseModel.NumberOfRoom.ToString();
            this.lbNumberOfEmptyRoom.Text = this._hostelResponseModel.NumberOfEmptyRoom.ToString();
            this.lbNumberOfCustomer.Text = this._hostelResponseModel.NumberOfCustomer.ToString();
            this.pbAvatar.ImageLocation = this._hostelResponseModel.Avatar;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmHostelDetail frmHostelDetailUserControl = new frmHostelDetail(this._hostelAPI, this._hostelResponseModel);
            frmHostelDetailUserControl.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHostelDetailUserControl_FormClosing);
            frmHostelDetailUserControl.ShowDialog();
        }
        private void frmHostelDetailUserControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            this._frmMain.frmMain_Load(null, null);
        }
    }
}
