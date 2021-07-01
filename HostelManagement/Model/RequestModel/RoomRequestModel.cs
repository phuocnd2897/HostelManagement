using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelManagement.Model.RequestModel
{
    public class RoomRequestModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
        public int NumberOfCustomer { get; set; }
        public double Price { get; set; }
        public int Status { get; set; }
        public bool IsActive { get; set; }
        public string HostelId { get; set; }
        public string FeeIds { get; set; }
    }
}
