using HostelManagement.API;
using HostelManagement.US;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Bunifu.Dataviz.WinForms.BunifuDatavizBasic;

namespace HostelManagement
{
    public partial class frmMain : Form
    {
        private string _token;
        private string _hostelId = "";
        private string _roomId = "";
        private HostelAPI hostelAPI;
        private RoomAPI roomAPI;
        private CustomerAPI customerAPI;
        private FeeAPI feeAPI;
        private DashboardAPI dashboardAPI;
        private DataPoint dataPoint;
        public frmMain(string token)
        {
            InitializeComponent();
            this._token = token;
            this.hostelAPI = new HostelAPI(_token);
            this.roomAPI = new RoomAPI(_token);
            this.customerAPI = new CustomerAPI(_token);
            this.feeAPI = new FeeAPI(_token);
            this.dashboardAPI = new DashboardAPI(_token);
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHostel_Click(object sender, EventArgs e)
        {
            pages.SetPage("hostel");
            page_hostel_load();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            pages.SetPage("info");
        }
        private void page_hostel_load()
        {
            this._hostelId = "";
            this._roomId = "";
            this.tbHostel.Controls.Clear();
            int x = 0, y = 0;
            var listHostel = this.hostelAPI.GetAllHostel();
            foreach (var item in listHostel)
            {
                HostelControl hostelControl = new HostelControl(item, hostelAPI, this);
                hostelControl.Location = new Point(x, y);
                tbHostel.Controls.Add(hostelControl);
                y += hostelControl.Height + 10;
                hostelControl.Click += new EventHandler(hostelItem_Click);
            }
        }
        private void page_room_load(string hostelId)
        {
            this._roomId = "";
            tbRoom.Controls.Clear();
            int x = 0, y = 0;
            var listRoom = this.roomAPI.GetAllRoom(hostelId);
            foreach (var item in listRoom)
            {
                RoomControl roomControl = new RoomControl(item, roomAPI, feeAPI, this);
                roomControl.Location = new Point(x, y);
                tbRoom.Controls.Add(roomControl);
                y += roomControl.Height + 10;
                roomControl.Click += new EventHandler(roomItem_Click);
            }
        }
        private void page_customer_load(string roomId)
        {
            tbCustomer.Controls.Clear();
            int x = 0, y = 0;
            var listRoom = this.customerAPI.GetAllCustomer(roomId);
            foreach (var item in listRoom)
            {
                CustomerControl customerControl = new CustomerControl(item, roomId, customerAPI, this);
                customerControl.Location = new Point(x, y);
                tbCustomer.Controls.Add(customerControl);
                y += customerControl.Height + 10;
                customerControl.Click += new EventHandler(roomItem_Click);
            }
        }
        private void hostelItem_Click(object sender, EventArgs e)
        {
            
            var control = (HostelControl)sender;
            this._hostelId = control.Name;
            page_room_load(_hostelId);
            pages.SetPage("room");
        }
        private void roomItem_Click(object sender, EventArgs e)
        {
            var control = (RoomControl)sender;
            this._roomId = control.Name;
            page_customer_load(_roomId);
            pages.SetPage("customer");
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (pages.PageTitle == "hostel")
            {
                frmHostelDetail frmHostelDetailUserControl = new frmHostelDetail(hostelAPI);
                frmHostelDetailUserControl.ShowDialog();
                frmHostelDetailUserControl.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHostelDetailUserControl_FormClosing);
            }
            else if (pages.PageTitle == "room")
            {
                frmRoomDetail frmRoomDetailControl = new frmRoomDetail(roomAPI, feeAPI, _hostelId);
                frmRoomDetailControl.ShowDialog();
                frmRoomDetailControl.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRoomDetailControl_FormClosing);
            }
            else if (pages.PageTitle == "customer")
            {
                frmCustomerDetail frmCustomerDetail = new frmCustomerDetail(customerAPI, this._roomId);
                frmCustomerDetail.ShowDialog();
                frmCustomerDetail.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCustomerDetail_FormClosing);
            }

        }
        private void frmHostelDetailUserControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            pages.SetPage("hostel");
            page_hostel_load();
        }
        private void frmRoomDetailControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            pages.SetPage("room");
            page_room_load(this._hostelId);
        }
        private void frmCustomerDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            pages.SetPage("customer");
            page_customer_load(this._roomId);
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void frmMain_Load(object sender, EventArgs e)
        {
            if (this._hostelId == "")
            {
                page_hostel_load();
            }
            else if (this._roomId == "")
            {
                page_room_load(this._hostelId);
            }
            else
            {
                page_customer_load(this._roomId);
            }
        }
        private void page_dashboard_load()
        {
            var result = this.dashboardAPI.CustomerByMonth();
            dataPoint = new DataPoint(_type.Bunifu_line);
            Canvas canvas = new Canvas();
            dataPoint.addLabely("JAN", result[0].ToString());
            dataPoint.addLabely("FEB", result[1].ToString());
            dataPoint.addLabely("MAR", result[2].ToString());
            dataPoint.addLabely("APR", result[3].ToString());
            dataPoint.addLabely("MAY", result[4].ToString());
            dataPoint.addLabely("JUNE", result[5].ToString());
            dataPoint.addLabely("JULY", result[6].ToString());
            dataPoint.addLabely("AUG", result[7].ToString());
            dataPoint.addLabely("SEP", result[8].ToString());
            dataPoint.addLabely("OCT", result[9].ToString());
            dataPoint.addLabely("NOV", result[10].ToString());
            dataPoint.addLabely("DEC", result[11].ToString());
            canvas.addData(dataPoint);
            bunifuDatavizBasic1.Render(canvas);
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pages.SetPage("dashboard");
            page_dashboard_load();
        }
    }
}
