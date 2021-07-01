using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelManagement.Model.ResponseModel
{
    public class HostelResponseModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Avatar { get; set; }
        public int ProvinceId { get; set; }
        public int DistrictId { get; set; }
        public int WardId { get; set; }
        public string ProvinceName { get; set; }
        public string DistrictName { get; set; }
        public string WardName { get; set; }
        public string Address { get; set; }
        public int NumberOfRoom { get; set; }
        public int NumberOfEmptyRoom { get; set; }
        public int NumberOfCustomer { get; set; }
        public int Status { get; set; }
        public bool Lock { get; set; }
    }
}
