using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kinksrp
{
    public class AreaRoutingMiddleware
    {
        private readonly RequestDelegate _next;


        public AreaRoutingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {

            var host = context.Request.Host.Value;

            var index = host.IndexOf(".");

            var subdomains = new string[] { "wow", "Wow"};

            if (index > 0)
            {
                var subdomain = host.Substring(0, index);

                if (subdomains.Contains(subdomain))
                {

                    context.Request.Path = "/" + subdomain  + context.Request.Path;
                }

            }


            await _next.Invoke(context);

        }
    }
}
