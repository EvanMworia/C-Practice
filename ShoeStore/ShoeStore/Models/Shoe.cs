using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStore.Models
{
    public class Shoe
    {
        public int Id { get; set; } = 0;
        public string ShoeName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ShoeBrand { get; set; } = string.Empty;

        public int Price { get; set; } = 0;
    }
}
