using HTTPReqest.Models.Github.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTTPReqest
{
    public interface IGithubClient
    {
        Task<UserResponseModel> GetUser(string username);
    }
}
