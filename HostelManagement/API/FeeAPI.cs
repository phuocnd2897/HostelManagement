using HostelManagement.Model.RequestModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelManagement.API
{
    public class FeeAPI
    {
        private string _token;
        public FeeAPI(string token)
        {
            _token = token;
        }
        public List<FeeRequestModel> GetAllFee()
        {
            var result = BaseAPI.GetMulti<FeeRequestModel>("Fee", "GetAll", "", _token);
            if (result != null)
            {
                return result.Result;
            }
            return null;
        }
        public FeeRequestModel AddFee(FeeRequestModel feeRequestModel)
        {
            var result = BaseAPI.Post<FeeRequestModel, FeeRequestModel>("Fee", "", feeRequestModel, _token);
            if (result != null)
            {
                return result.Result;
            }
            return null;
        }
    }
}
