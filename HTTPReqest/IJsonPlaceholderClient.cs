using HTTPReqest.Models.Jsonplaceholder.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTTPReqest
{
    public interface IJsonPlaceholderClient
    {
        Task<IEnumerable<PostResponseModel>> GetPosts();
        Task<PostResponseModel> GetPost();
        Task<IEnumerable<UserResponseModel>> GetUsers();
        Task<UserResponseModel> GetUser(int id);
        Task<IEnumerable<TodoResponseModel>> GetTodoItems(int id);
        Task<IEnumerable<TodoResponseModel>> GetTodosByStatus(int id, bool isCompleted);

    }
}
