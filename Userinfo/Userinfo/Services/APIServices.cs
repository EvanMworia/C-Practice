using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Userinfo.Models;
using Userinfo.Services.IServices;

namespace Userinfo.Services
{
    public class APIServices : IAPIs //inheriting the interface in order to implement it
    {
        //Creating and assigning endpoints to respective provided API links
        private readonly string comments_URL = "https://jsonplaceholder.typicode.com/comments";
        private readonly string posts_URL = "https://jsonplaceholder.typicode.com/posts";
        private readonly string users_URL = "https://jsonplaceholder.typicode.com/users";
        private readonly HttpClient _client;


        public APIServices()
        {
            _client = new HttpClient(); 
        }

        public async Task<List<Comments>> GetAllComments()
        {
            var response = await _client.GetAsync(comments_URL);
            var content = await response.Content.ReadAsStringAsync();
            var comment = JsonConvert.DeserializeObject<List<Comments>>(content);

            if (response.IsSuccessStatusCode)
            {
                return comment;
            }
            return new List<Comments>();

        }

        public async Task<List<Posts>> GetAllPosts()
        {
            var response = await _client.GetAsync(posts_URL);
            var content = await response.Content.ReadAsStringAsync();
            var post = JsonConvert.DeserializeObject<List<Posts>>(content);

            if (response.IsSuccessStatusCode)
            {
                return post;
            }
            return new List<Posts>();

        }

        public async Task<List<dynamic>> GetAllUsers()
        {
            var response = await _client.GetAsync(users_URL);
            var content = await response.Content.ReadAsStringAsync();
            List<dynamic> user = JsonConvert.DeserializeObject<List<dynamic>>(content);

            if (response.IsSuccessStatusCode)
            {
                return user;
            }
            return new List<dynamic>();
        }
    }
}
