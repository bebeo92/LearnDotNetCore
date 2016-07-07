using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreWithMVC.Services;
using Microsoft.AspNetCore.Builder;

namespace AspNetCoreWithMVC.Extension
{
    public static class RequestLoggerExtension
    {
        public static IApplicationBuilder UseRequestLogger(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RequestLoggerMiddleware>();
        }
    }
}
