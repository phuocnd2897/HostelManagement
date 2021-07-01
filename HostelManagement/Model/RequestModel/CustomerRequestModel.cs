using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelManagement.Model.RequestModel
{
    public class CustomerRequestModel
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public int Sex { get; set; }
        public string PhoneNumber { get; set; }
        public string IdCard { get; set; }
        public int WardId { get; set; }
        public string Address { get; set; }
        public int Status { get; set; }
        public string RoomId { get; set; }
    }
}
