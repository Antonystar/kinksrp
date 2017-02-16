using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kinksrp.Areas.Wow.Models;

namespace kinksrp.Areas.Wow.Models
{
    public interface IUserRepository
    {
        IEnumerable<User> Users { get; }
    }
}
