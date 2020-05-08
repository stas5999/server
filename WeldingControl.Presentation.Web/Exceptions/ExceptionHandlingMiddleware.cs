using System;
using System.Linq;
using System.Net;
using System.Security.Authentication;
using System.Text.Json;
using System.Threading.Tasks;
using FluentValidation;
using Microsoft.AspNetCore.Http;

namespace WeldingControl.Presentation.Web.Exceptions
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context /* other dependencies */)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            var code = HttpStatusCode.InternalServerError;
            ErrorResult[] errors = { new ErrorResult { Message = ex.Message } };

            if (ex is AuthenticationException)
            {
                code = HttpStatusCode.Unauthorized;
            }
            else if (ex is ValidationException validationException)
            {
                code = HttpStatusCode.UnprocessableEntity;
                errors = validationException.Errors
                    .Select(e => new ErrorResult { Message = e.ErrorMessage, PropertyName = Char.ToLowerInvariant(e.PropertyName[0]) + e.PropertyName.Substring(1) })
                    .ToArray();
            }

            var result = JsonSerializer.Serialize(new { errors }, new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)code;
            return context.Response.WriteAsync(result);
        }
    }
}