﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace TwitterClone.API.Filters
{
    public class ValidationFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                var message = context.ModelState.SelectMany(ms => ms.Value.Errors).Select(e => e.ErrorMessage).ToList();

                context.Result = new BadRequestObjectResult(message);
            }
        }
    }
}