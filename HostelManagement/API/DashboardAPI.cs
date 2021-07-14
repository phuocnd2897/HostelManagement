using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelManagement.API
{
    public class DashboardAPI
    {
        private string _token;
        public DashboardAPI(string token)
        {
            _token = token;
        }
        public List<int> CustomerByMonth()
        {
            var result = BaseAPI.GetMulti<int>("Dashboard", "CustomerByMonth", "", _token);
            if (result != null)
            {
                return result.Result;
            }
            return null;
        }
    }
}
