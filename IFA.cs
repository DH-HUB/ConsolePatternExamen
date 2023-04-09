using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePatternExamen
{
    public class IFA : IAffiliate
    {
        private string name = "IFA";
        public void Display()
        {
            Console.WriteLine("Affiliation: {0}", name);
        }
    }
}