using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using System;

namespace ConsolePatternExamen
{
    /*Décorateur pour afficher les informations supplémentaires*/
    public class AdditionalInfoDecorator : MaterialDecorator
    {
        private string info;

        public AdditionalInfoDecorator(IMaterial material, string info) : base(material)
        {
            this.info = info;
        }

        public string Name { get; internal set; }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Information supplémentaire : " + this.info);
        }
    }
}
    