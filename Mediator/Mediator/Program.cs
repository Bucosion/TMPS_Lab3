using System;

namespace Mediator
{
     class Program
     {
          static void Main(string[] args)
          {
               ManagerMediator mediator = new ManagerMediator();
               Colleague customer = new CustomerColleague(mediator);
               Colleague programmer = new ProgrammerColleague(mediator);
               Colleague tester = new TesterColleague(mediator);
               mediator.Customer = customer;
               mediator.Programmer = programmer;
               mediator.Tester = tester;
               customer.Send("A aparut o comanda, trebuie de facut un program");
               programmer.Send("Programul este gata, trebuie de testat");
               tester.Send("Programul a fost testat si este gata de livrat");

               Console.Read();
          }
     }
}
