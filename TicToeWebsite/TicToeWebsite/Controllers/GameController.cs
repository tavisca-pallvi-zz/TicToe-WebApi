using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TicToeWbsite.DataBaseAcces;
using TicToeWebsite.Models;


namespace TicToeWebsite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class GameController : ControllerBase
    {

        [HttpGet]
        [Authorize]
        [Logger]
        [Exceptionss]
        
        public string MovePlayer(int boxId,int id)
        {
            SqlRepository conn = new SqlRepository(); //it should be singelton class
            return TicToe.StatusOfGame(boxId, conn.GetById(id));

        }
     
    }
}