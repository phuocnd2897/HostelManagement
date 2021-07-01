using HostelManagement.API;
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
    public class RoomAPI
    {
        private string _token;
        public RoomAPI(string token)
        {
            _token = token;
        }
        public List<RoomResponseModel> GetAllRoom(string Id)
        {
            try
            {
                var result = BaseAPI.GetMulti<RoomResponseModel>("Room", "GetByHostelId", "Id=" + Id, _token).Result;
                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public RoomRequestModel AddRoom(MultipartFormDataContent roomRequestModel)
        {
            try
            {
                var result = BaseAPI.PostWithFile<RoomRequestModel>("Room", "", roomRequestModel, _token).Result;
                return result;
            }
            catch
            {
                return null;
            }
        }
        public RoomRequestModel UpdateRoom(MultipartFormDataContent roomRequestModel)
        {
            try
            {
                var result = BaseAPI.PutWithFile<RoomRequestModel>("Room", "", roomRequestModel, _token).Result;
                return result;
            }
            catch
            {
                return null;
            }
        }
    }

}
