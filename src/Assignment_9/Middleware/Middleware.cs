﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using System.Net;

namespace Assignment_9.Middleware {
    public class Middleware {

        private readonly RequestDelegate next;

        public Middleware(RequestDelegate next) {
            this.next = next;
        }

        public Task Invoke(HttpContext httpContext) {
            var currentContext = httpContext.Request.Method.ToUpper();

            if ((currentContext == "POST" || currentContext == "PUT" || currentContext == "PATCH") && httpContext.Request.ContentType != "application/json") {
                httpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            }

            return next(httpContext);
        }
    }

    public static class MiddlewareExtensions {
        public static IApplicationBuilder UseMiddleware(this IApplicationBuilder builder) {
            return builder.UseMiddleware<Middleware>();
        }
    }
}
