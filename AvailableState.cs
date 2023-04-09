using ConsolePatternExamen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePatternExamen
{
    /* État du matériel: en stock disponible*/
    public class AvailableState : ICommand
    {
        private Material material;

        /* public AvailableState(Material material)
    {
        this.material = material;
    }*/
        public void Execute()
        {
            Console.WriteLine("{0} est en stock disponible", material.Name);
        }

    } 
}
