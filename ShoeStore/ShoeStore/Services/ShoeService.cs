using Newtonsoft.Json;
using ShoeStore.Models;
using ShoeStore.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ShoeStore.Services
{
    public class ShoeService : IShoes
    {
        private readonly HttpClient _httpClient;
        private readonly string _URL = "http://localhost:3000/shoes";
        public ShoeService()
        {
            _httpClient = new HttpClient();
        }
        public async Task<bool> createShoe(AddShoe newShoe)
        {
            var content =JsonConvert.SerializeObject(newShoe);
            var body = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(_URL, body);
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            return false;


        }

        public Task<bool> deleteShoe(int id)
        {
            
        }

        public Task<List<Shoe>> getAllShoes()
        {
            
        }

        public Task<bool> updateShoe(AddShoe updatedShoe)
        {
            
        }
    }
}
