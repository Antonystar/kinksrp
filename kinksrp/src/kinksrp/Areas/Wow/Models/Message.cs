using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kinksrp.Areas.Wow.Models
{
    public class Message
    {
        public int MessageID { get; set; }
        public int PostID { get; set; }
        public int UserID { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
    }
}
