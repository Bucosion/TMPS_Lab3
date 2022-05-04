
using System;
namespace Observer
{
     class Program
     {
          static void Main(string[] args)
          {

               Subject Iphone = new Subject("Iphone X", 10000, "Stocul s-a terminat!");
   
   
               Observer user1 = new Observer("Edvin", Iphone);

              Observer user2 = new Observer("Vlad", Iphone);

              Observer user3 = new Observer("Ovidiu", Iphone);

               Console.WriteLine("Situatia : " + Iphone.getAvailability());
               Console.WriteLine();

               Iphone.setAvailability("Disponibil");

               Console.Read();
          }
     }
}