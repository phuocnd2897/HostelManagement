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
        public List<CustomerResponseModel> GetAllRoom(string Id)
        {
            try
            {
                var result = BaseAPI.GetMulti<CustomerResponseModel>("Customer", "GetByRoomId", "Id=" + Id, _token).Result;
                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public CustomerRequestModel AddRoom(MultipartFormDataContent roomRequestModel)
        {
            try
            {
                var result = BaseAPI.PostWithFile<CustomerRequestModel>("Customer", "", roomRequestModel, _token).Result;
                return result;
            }
            catch
            {
                return null;
            }
        }
        public CustomerRequestModel UpdateRoom(MultipartFormDataContent roomRequestModel)
        {
            try
            {
                var result = BaseAPI.PutWithFile<CustomerRequestModel>("Customer", "", roomRequestModel, _token).Result;
                return result;
            }
            catch
            {
                return null;
            }
        }
    }
}
