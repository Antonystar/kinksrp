using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kinksrp.Areas.Wow.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        [ForeignKey("AccessGroupID")]
        public int AccessGroupID { get; set; }
        public byte[] Avatar { get; set; }
        public byte[] Background { get; set; }    
        public int Reputation { get; set; }
        public DateTime Date {get; set;}

        public virtual AccessGroup AccessGroup { get; set; }
    }
}
