using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicToeWebsite.Models;

namespace TicToeWebsite
{
    public class AccessKey
    {

        public User user;
        public AccessKey(User user)
        {
            this.user = user;
        }
        public void GenerateAccessKey()
        {
            Guid accessKey = Guid.NewGuid();
            string id = accessKey.ToString();
            user.AccessToken = id;
        }
    }

}
