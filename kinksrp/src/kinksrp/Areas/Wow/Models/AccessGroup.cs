using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kinksrp.Areas.Wow.Models
{
    public class AccessGroup
    {
        public int AccessGroupID { get; set; }
        public string Name { get; set; }
        public long AccessFlags { get; set; }
        /*public bool Panel { get; set; }
        public bool Banned { get; set; }
        public bool Registred { get; set; }
        public bool EditPostsAndComments { get; set; }
        public bool EditUsers { get; set; }
        public bool BanUsers { get; set; }
        public bool Premium { get; set; }*/
    }
}
