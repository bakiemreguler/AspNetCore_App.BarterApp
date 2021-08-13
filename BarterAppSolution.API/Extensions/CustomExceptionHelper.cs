using BarterAppSolution.API.Helpers;
using BarterAppSolution.API.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace BarterAppSolution.API.Extensions
{
    public static class CustomExceptionHelper
    {
        public static void UseCustomException(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(config =>
            {
                config.Run(async context =>
                {
                    HttpStatusCode status = HttpStatusCode.InternalServerError;
                    context.Response.StatusCode = (int)status;
                    context.Response.ContentType = "application/json";
                    var error = context.Features.Get<IExceptionHandlerFeature>();

                    if (error != null)
                    {
                        var loggerFactory = (ILoggerFactory)new LoggerFactory();
                        var logger = loggerFactory.CreateLogger("LogFilter");

                        var ex = error.Error;

                        logger.LogError(ex, "Bir Hata Oluştu.");

                        ServiceResult<object> result = Utils.GenerateServiceResult(status, false, null, "Bir Hata Oluştu.");
                        await context.Response.WriteAsync(JsonConvert.SerializeObject(result));
                    }
                });
            });
        }
    }
}
