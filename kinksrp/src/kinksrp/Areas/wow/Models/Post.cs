using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace kinksrp.Areas.Wow.Models
{
    public class Post
    {
        public int PostID { get; set; }
        [ForeignKey("SectionID")]
        public int SectionID { get; set; }
        [ForeignKey("UserID")]
        public int UserID { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }

        public virtual Section Section { get; set; }
        public virtual User User { get; set; }
    }
}
