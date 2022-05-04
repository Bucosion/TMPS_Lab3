using System;
namespace Observer
{
     public class Observer : IObserver
     {
          public string UserName { get; set; }

          public Observer(string userName, ISubject subject)
          {
               UserName = userName;
               subject.RegisterObserver(this);
          }

          public void update(string availabiliy)
          {
               Console.WriteLine("Salut " + UserName + ", Produsul este acum " +
               availabiliy + " pe 999.md.");
          }
     }
}