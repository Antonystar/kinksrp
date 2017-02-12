using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kinksrp
{
    public static class AreaRoutingExtensions
    {
        public static IApplicationBuilder UseAreaRouting(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<AreaRoutingMiddleware>();
        }
    }
}
