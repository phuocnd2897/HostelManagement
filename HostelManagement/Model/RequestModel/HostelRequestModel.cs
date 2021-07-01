using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HostelManagement.Model.RequestModel
{
    public class HostelRequestModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int WardId { get; set; }
        public string Address { get; set; }
        public int Status { get; set; }
        public bool Lock { get; set; }
    }
}
