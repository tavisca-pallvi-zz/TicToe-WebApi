using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicToeWebsite.Models;

namespace TicToeWebsite.DataBaseAcces
{
  public interface IRepo
    {
     void Add(User user);
    }
}
