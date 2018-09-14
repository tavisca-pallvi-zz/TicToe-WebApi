using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicToeWbsite.DataBaseAcces;

namespace TicToeWebsite
{
    public class AuthorizeAttribute : ResultFilterAttribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {

        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var apiKey = context.HttpContext.Request.Headers["apikey"].ToString();
            if (string.IsNullOrEmpty(apiKey))
            {
                throw new UnauthorizedAccessException("Api Key not passed");
            }
            else
            {
                SqlRepository conn = new SqlRepository();
                int res = conn.AuthenticateUser(apiKey);
                if (res == 0)
                    throw new UnauthorizedAccessException("Invalid Api Key passed");
             
            }
        }

    }
}

