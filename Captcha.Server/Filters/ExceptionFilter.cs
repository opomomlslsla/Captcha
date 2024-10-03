using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Captcha.Domain.Exceptions;

namespace API.Filters;

public class ApiExceptionFilter : ExceptionFilterAttribute
{
    public override void OnException(ExceptionContext context)
    {
        if (context.Exception is NullEntityException)
        {
            context.Result = new NotFoundObjectResult(context.Exception.Message);
        }
        else if (context.Exception is DbUpdateException dbUpdateException)
        {
            context.Result = new BadRequestObjectResult(dbUpdateException.InnerException?.Message ?? dbUpdateException.Message);
        }
        else
        {
            context.Result = new StatusCodeResult(StatusCodes.Status500InternalServerError);
        }

        context.ExceptionHandled = true;
    }
}