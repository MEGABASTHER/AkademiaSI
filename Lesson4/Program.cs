using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesAndStrategy.Writers;
using InterfacesAndStrategy.Triggers;

namespace InterfacesAndStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Run StartProgram = new Run();

            StartProgram.DoIt();
        }
    }
}