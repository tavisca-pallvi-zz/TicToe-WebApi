using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TicToeWbsite.DataBaseAcces;

namespace TicToeWebsite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class GameController : ControllerBase
    {
        
        [HttpPost]
        [Authorize]
        public void MovePlayer(int moveno, string apikey)
        {

            //SqlRepository conn = new SqlRepository();
            //int userExist = conn.Search(user);
            //if (userExist == 0)
            //    conn.Add(user);
        }
    }
}