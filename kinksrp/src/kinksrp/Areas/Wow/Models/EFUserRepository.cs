using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kinksrp.Areas.Wow.Models;

namespace kinksrp.Areas.Wow.Models
{
    public class EFUserRepository : IUserRepository
    {
        private ApplicationDbContext context;

        public EFUserRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IEnumerable<User> Users => context.Users;

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
