using HostelManagement.Model.RequestModel;
using HostelManagement.Model.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelManagement.API
{
    public class AppAccountAPI
    {
        public LoginResponseModel Login(LoginRequsetModel item)
        {
            var result = BaseAPI.Post<LoginResponseModel, LoginRequsetModel>("AppAccount", "Login", item);
            return result.Result;
        }
        public AppAccountResponseModel SignUp(AppAccountRequestModel item)
        {
            var result = BaseAPI.Post<AppAccountResponseModel, AppAccountRequestModel>("AppAccount", "Registration", item);
            return result.Result;
        }
    }
}
