using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePatternExamen
{

    // Interface de base pour les materials
    public interface IMaterial
    {
        void ChangeState(object state);
        void Display();
        void Execute();
    }
}

