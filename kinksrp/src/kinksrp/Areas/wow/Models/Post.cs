﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kinksrp.Areas.Wow.Models
{
    public class Post
    {
        public int PostID { get; set; }
        public int SectionID { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
    }
}
