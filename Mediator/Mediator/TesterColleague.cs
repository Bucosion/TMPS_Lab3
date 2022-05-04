using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
     class TesterColleague : Colleague
     {
          public TesterColleague(Mediator mediator)
              : base(mediator)
          { }

          public override void Notify(string message)
          {
               Console.WriteLine("Mesaj catre tester: " + message);
          }
     }
}
