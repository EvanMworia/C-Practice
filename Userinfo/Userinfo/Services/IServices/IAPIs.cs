using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Userinfo.Models;

namespace Userinfo.Services.IServices
{
    public interface IAPIs
    {
        Task<List<dynamic>> GetAllUsers();
        Task<List<Posts>> GetAllPosts();
        Task<List<Comments>> GetAllComments();

    }
}
