using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicToeWebsite.Models
{
    public  class Logger
    {
        public static int LogId;
        public static string Response;
        public static string Request;
        public static string Exception;

        public void Logs(int id, string response)
        {

        }
    }
    //public static class Logger
    //{
    //    private static Logger _instance = null;
    //    public static Logger Instance
    //    {
    //        get
    //        {
    //            if (_instance == null)
    //            {
    //                _instance = new Logger();
    //            }
    //            return _instance;
    //        }
    //    }
    //    public static void LogMessage(int LogId, string Response, string Request, string Exception)
    //   {



    //     }



    }
}