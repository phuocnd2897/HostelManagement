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
    public class CustomerAPI
    {
        private string _token;
        public CustomerAPI(string token)
        {
            _token = token;
        }
        public List<CustomerResponseModel> GetAllCustomer(string Id)
        {
            try
            {
                var result = BaseAPI.GetMulti<CustomerResponseModel>("Customer", "GetByRoomId", "Id=" + Id, _token);
                if (result != null)
                {
                    return result.Result;
                }
                return null;
            }
            catch
            {
                return null;
            }
        }
        public CustomerRequestModel AddCustomer(MultipartFormDataContent roomRequestModel)
        {
            try
            {
                var result = BaseAPI.PostWithFile<CustomerRequestModel>("Customer", "", roomRequestModel, _token);
                if (result != null)
                {
                    return result.Result;
                }
                return null;
            }
            catch
            {
                return null;
            }
        }
        public CustomerRequestModel UpdateCustomer(MultipartFormDataContent roomRequestModel)
        {
            try
            {
                var result = BaseAPI.PutWithFile<CustomerRequestModel>("Customer", "", roomRequestModel, _token);
                if (result != null)
                {
                    return result.Result;
                }
                return null;
            }
            catch
            {
                return null;
            }
        }
    }
}
