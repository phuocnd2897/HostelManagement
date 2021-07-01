using HostelManagement.Model.RequestModel;
using HostelManagement.Model.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HostelManagement.API
{
    public class HostelAPI
    {
        private string _token;
        public HostelAPI(string token)
        {
            _token = token;
        }
        public List<HostelResponseModel> GetAllHostel()
        {
            try
            {
                var result = BaseAPI.GetMulti<HostelResponseModel>("Hostel", "GetAll", "", _token).Result;
                return result;
            }
            catch
            {
                return null;
            }
        }
        public HostelRequestModel AddHostel(MultipartFormDataContent hostelRequestModel)
        {
            try
            {
                var result = BaseAPI.PostWithFile<HostelRequestModel>("Hostel", "", hostelRequestModel, _token).Result;
                return result;
            }
            catch 
            {
                return null;
            }
        }
        public HostelRequestModel UpdateHostel(MultipartFormDataContent hostelRequestModel)
        {
            try
            {
                var result = BaseAPI.PutWithFile<HostelRequestModel>("Hostel", "", hostelRequestModel, _token).Result;
                return result;
            }
            catch
            {
                return null;
            }
        }
    }
}
