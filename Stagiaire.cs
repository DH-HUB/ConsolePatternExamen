using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePatternExamen
{
    public class Stagiaire : IAffiliate
    {
        private string name;
        public Stagiaire(string name)
        {
            this.name = name;
        }

        public void Display()
        {
            Console.WriteLine("Stagiaire: {0}", name);
        }
    }
}
