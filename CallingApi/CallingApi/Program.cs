using ConsoleEventManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingApi
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsumeEventSync objsync = new ConsumeEventSync();
          objsync.GetAllEventData();
            Console.ReadKey();
        }
    }
}
