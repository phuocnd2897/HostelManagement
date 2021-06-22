using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelManagement.Model.RequestModel
{
    public class AppAccountRequestModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public int Sex { get; set; }
        public int WardId { get; set; }
        public string Address { get; set; }
        public byte[] Avatar { get; set; }
        public string Email { get; set; }
    }
}
