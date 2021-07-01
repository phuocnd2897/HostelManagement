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

namespace HostelManagement
{
    public partial class frmCustomerDetail : Form
    {
        private CustomerAPI _customerAPI;
        private CustomerResponseModel _customerResponseModel;
        private string _roomId;
        public frmCustomerDetail(CustomerAPI customerAPI, string roomId, CustomerResponseModel customerResponseModel = null)
        {
            InitializeComponent();
            _customerAPI = customerAPI;
            _customerResponseModel = customerResponseModel;
            _roomId = roomId;
        }
    }
}
