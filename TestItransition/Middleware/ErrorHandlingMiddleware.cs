using Microsoft.AspNetCore.Http;
using System.Net;
using TestItransition.Exceptions;

namespace TestItransition.Middleware
{
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ErrorHandlingMiddleware> _logger;
        public ErrorHandlingMiddleware(RequestDelegate next, ILogger<ErrorHandlingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }
        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
        
            catch(AddException addEx)
            {
                _logger.LogError(addEx.Message);
                _logger.LogError(addEx.StackTrace);
                context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                await context.Response.WriteAsJsonAsync("Невозможно добавить модель авто.");
            }
            catch(GetAutoByParameterException getAutoEx)
            {
                _logger.LogError(getAutoEx.Message);
                _logger.LogError(getAutoEx.StackTrace);
                context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                await context.Response.WriteAsJsonAsync("Невозможно найти модель по заданному параметру.");
            }
            catch (InitializationException iEx)
            {
                _logger.LogError(iEx.Message);
                _logger.LogError(iEx.StackTrace);
                context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                await context.Response.WriteAsJsonAsync("Невозможно инициализировать модель авто.");
            }
            catch (RemoveAutoException rEx)
            {
                _logger.LogError(rEx.Message);
                _logger.LogError(rEx.StackTrace);
                context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                await context.Response.WriteAsJsonAsync("Невозможно удалить модель авто.");
            }
            catch(UpdateAutoException uEx)
            {
                _logger.LogError(uEx.Message);
                _logger.LogError(uEx.StackTrace);
                context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                await context.Response.WriteAsJsonAsync("Невозможно заменить модель авто.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                _logger.LogError(ex.StackTrace);
                await context.Response.WriteAsJsonAsync("Что то пошло не так");

            }
        }
    }
}
