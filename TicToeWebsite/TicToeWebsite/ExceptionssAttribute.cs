using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicToeWebsite.DataBaseAcces;
using TicToeWebsite.Models;

namespace TicToeWebsite
{
    public class ExceptionssAttribute : ActionFilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext context)
          {
            string req = "";
            req = context.RouteData.Values["action"].ToString() + context.RouteData.Values["controller"].ToString();
            Logger.Request = req;
            Logger.Response = "Failure";
            
            Logger.Exception = context.Exception.Message + context.Exception.Source;
            LogDatabase.Add();
        }
    }
}
