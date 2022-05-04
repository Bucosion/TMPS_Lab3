using System;

namespace Observer
{
     public interface IObserver
     {
          void update(string availability);
     }
}
