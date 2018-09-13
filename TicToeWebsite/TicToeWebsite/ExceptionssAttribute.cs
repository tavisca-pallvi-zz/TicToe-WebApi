using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicToeWebsite.Models;

namespace TicToeWebsite
{
    public class ExceptionssAttribute : ActionFilterAttribute, IExceptionFilter
    {
           public void OnException(ExceptionContext context)
        {
            if(context.Exception )
        Logger.Exception = context.Exception.Message + context.Exception.Source;
          
        }
    }
}
