using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePatternExamen
{
    // L'école MNS et affiliée à l'école IFA
    public class MNS : IAffiliate
    {
        private List<IAffiliate> affiliates = new List<IAffiliate>();
        private string name = "MNS";
        public void Add(IAffiliate affiliate)
        {
            affiliates.Add(affiliate);
        }

        public void Remove(IAffiliate affiliate)
        {
            affiliates.Remove(affiliate);
        }

        public void Display()
        {
            Console.WriteLine("Affiliation: {0}", name);

            foreach (IAffiliate affiliate in affiliates)
            {
                affiliate.Display();
            }
        }
    }
  }