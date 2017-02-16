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
        private bool Banned { get; set; }
    }
}
