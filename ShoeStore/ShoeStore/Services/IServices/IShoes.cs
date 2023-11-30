using ShoeStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStore.Services.IServices
{
    public interface IShoes
    {
        Task<bool> createShoe(AddShoe newShoe);
        Task<bool> updateShoe(AddShoe updatedShoe);
        Task<bool> deleteShoe(int id);
        Task<List <Shoe>> getAllShoes();

    }
}
