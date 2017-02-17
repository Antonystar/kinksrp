using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace kinksrp.Areas.Wow.Models
{
    public class UserProfileLike
    {
        public int UserProfileLikeID { get; set; }
        public int UserProfileID { get; set; }
        [ForeignKey("UserID")]
        public int UserID { get; set; }
        public bool Up { get; set; }

        public virtual User User { get; set; }
    }
}
