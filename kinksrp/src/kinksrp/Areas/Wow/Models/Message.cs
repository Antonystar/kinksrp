﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace kinksrp.Areas.Wow.Models
{
    public class Message
    {
        public int MessageID { get; set; }
        [ForeignKey("PostID")]
        public int PostID { get; set; }
        [ForeignKey("UserID")]
        public int UserID { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }

        public virtual Post Post { get; set; }
        public virtual User User { get; set; }
    }
}
