﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Userinfo.Models
{
    public class Posts
    {
        public int Id { get; set; }
        public string Title { get; set; }=string.Empty;
        public string Body { get; set; } = string.Empty;
    }
}