using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using TicToeWbsite.DataBaseAcces;
using TicToeWebsite.DataBaseAcces;
using TicToeWebsite.Models;

namespace TicToeWebsite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        [HttpGet]
        [Route("{id}")]
        [Logger]
        [Exceptionss]
        public string GetUser(int id)
        {  // SqlRepository conn = new SqlRepository();
            CassandraRepo conn = new CassandraRepo();
            string s = conn.GetById(id);
            return s;
        }

        [HttpPost]
        [Exceptionss]
        [Logger]
        public void RegisterUser([FromBody]User user)
        {
            AccessKey key = new AccessKey(user);

            key.GenerateAccessKey();
            ReposSelected repoToBeSelected = new ReposSelected();
            //SqlRepository conn = new SqlRepository();
            CassandraRepo conn = new CassandraRepo();
            int userExist = conn.Search(user);
            if (userExist == 0)
                conn.Add(user);
            else
                throw new Exception("User Already exists");
        }
    }
}