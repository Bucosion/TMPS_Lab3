using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
     public class BusStrategy : IStrategy
     {
          public string GetTravelTime(string source, string destination)
          {
               return "Va lua 60 min ca sa ajungi din " + source + " la " + destination + " folosind autobusul.";
          }
     }
}
