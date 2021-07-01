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
        public CustomerControl(CustomerResponseModel customerResponseModel, CustomerAPI customerAPI, frmMain frmMain)
        {
            InitializeComponent();
            _customerResponseModel = customerResponseModel;
            _customerAPI = customerAPI;
            _frmMain = frmMain;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmCustomerDetail frmCustomerDetail = new frmCustomerDetail(this._customerAPI, this._customerResponseModel);
            frmCustomerDetail.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCustomerDetail_FormClosing);
            frmCustomerDetail.ShowDialog();
        }
        private void frmCustomerDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            this._frmMain.frmMain_Load(null, null);
        }
    }
}
