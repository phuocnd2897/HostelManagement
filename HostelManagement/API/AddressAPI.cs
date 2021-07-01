using HostelManagement.Model.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelManagement.API
{
    public class AddressAPI
    {
        public List<Province> GetProvince()
        {
            var result = BaseAPI.GetMulti<Province>("Province", "", "").Result;
            return result;
        }
        public List<District> GetDistrictByProvinceID(string Id)
        {
            var result = BaseAPI.GetMulti<District>("District", "", "Id=" + Id).Result;
            return result;
        }
        public List<Ward> GetWardByDistrictID(string Id)
        {
            var result = BaseAPI.GetMulti<Ward>("Ward", "", "Id=" + Id).Result;
            return result;
        }
    }
}
