using System;

namespace Strategy
{
     class Program
     {
          static void Main()
          {
               Console.WriteLine("Salut!, te rog sa alegi modalitatea de transport: \n1. Masina \n2. Bicicleta \n3. Autobus");
               Console.WriteLine("\n*****************************************************************************************************\n");
               var userStrategy = Console.ReadLine().ToLower();
               Console.WriteLine("\nAi selectat modalitatea " + userStrategy + " ca transport!\n");
               Console.WriteLine("\n*****************************************************************************************************\n");
               switch (userStrategy)
               {
                    case "1":
                         new TravelStrategy(new CarStrategy()).GetTravelTime("Punct A", "Punct B");
                         break;
                    case "2":
                         new TravelStrategy(new BikeStrategy()).GetTravelTime("Punct A", "Punct B");
                         break;
                    case "3":
                         new TravelStrategy(new BusStrategy()).GetTravelTime("Punct A", "Punct B");
                         break;
                    default:
                         Console.WriteLine("Ai ales un mod invalid.");
                         break;
               }
          }
     }
}
