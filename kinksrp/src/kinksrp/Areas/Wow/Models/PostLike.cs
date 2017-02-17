using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace kinksrp.Areas.Wow.Models
{
    public class PostLike
    {
        public int PostLikeID { get; set; }
        [ForeignKey("PostID")]
        public int PostID { get; set; }
        [ForeignKey("UserID")]
        public int UserID { get; set; }
        public bool Up { get; set; }

        public virtual Post Post { get; set; }
        public virtual User User { get; set; }
    }
}
