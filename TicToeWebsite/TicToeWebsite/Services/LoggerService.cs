using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicToeWebsite.DataBaseAcces;
using TicToeWebsite.Models;

namespace TicToeWebsite.Services
{
    public class LoggerService
    {
        public LogDatabase logHandler;
       // public Logger log;

        public LoggerService()
        {
            logHandler = new LogDatabase();
            //log = new Logger();
        }
      //  [Exceptionss]
        public void AddLogs()
        {
            logHandler.Add();
        }



    }
}
