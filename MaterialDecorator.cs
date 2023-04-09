using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePatternExamen
{

    // Classe de base pour les décorateurs
    public abstract class MaterialDecorator : IMaterial
    {
        protected IMaterial material;

        public MaterialDecorator(IMaterial material)
        {
            this.material = material;
        }

        public ICommand State { get; private set; }

       public void ChangeState(object state)
        {
            this.material.ChangeState(state);
        }
        public void ChangeState(ICommand newState)
        {
            this.State = newState;
            newState.Execute();
        }


        public virtual void Display()
        {
            this.material.Display();
        }

        public virtual void Execute()
        {
            this.material.Execute();
        }
    }
}