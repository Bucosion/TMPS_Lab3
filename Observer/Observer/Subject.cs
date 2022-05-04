using System;
using System.Collections.Generic;

namespace Observer
{
     public class Subject : ISubject
     {
          private List<IObserver> observers = new List<IObserver>();
          private string ProductName { get; set; }
          private int ProductPrice { get; set; }
          private string Availability { get; set; }

          public Subject
              (
              string productName,
              int productPrice,
              string availability)
          {
               ProductName = productName;
               ProductPrice = productPrice;
               Availability = availability;
          }

          public string getAvailability()
          {
               return Availability;
          }

          public void setAvailability(string availability)
          {
               this.Availability = availability;
               Console.WriteLine("Stocul fost schimbat cu succes de la Finisat la Disponibil!");
   
               NotifyObservers();
          }

          public void RegisterObserver(IObserver observer)
          {
               Console.WriteLine("A adaugat : " +
                                       ((Observer)observer).UserName);
               observers.Add(observer);
          }

          public void AddObservers(IObserver observer)
          {
               observers.Add(observer);
          }

          public void RemoveObserver(IObserver observer)
          {
               observers.Remove(observer);
          }

          public void NotifyObservers()
          {
               Console.WriteLine("Numele Produsului :"
                               + ProductName + ", Pretul produsului : "
                               + ProductPrice + ", Este acum Disponibil. ");
   

               Console.WriteLine();
               foreach (IObserver observer in observers)
               {
                    observer.update(Availability);
               }
          }
     }
}