using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePatternExamen
{
    /* État du matériel: emprunté*/
    public class BorrowedState : ICommand
    {
        private Material material;

        public BorrowedState(Material material)
        {
            this.material = material;
        }

        public void Execute()
        {
            Console.WriteLine("{0} est emprunté", material.Name);
        }
    }

}
