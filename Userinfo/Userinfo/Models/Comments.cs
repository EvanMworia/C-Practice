using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Userinfo.Models
{
    public class Comments
    {
        public int Id { get; set; }
        public string Name { get; set; }= string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
    }
}
