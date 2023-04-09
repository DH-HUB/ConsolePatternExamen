using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePatternExamen
{
    /* Décorateur pour les photos*/
    public class PhotoDecorator : MaterialDecorator
    {
        private string photoPath;

        public PhotoDecorator(IMaterial material, string photoPath) : base(material)
        {
            this.photoPath = photoPath;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Chemin de la photo : " + this.photoPath);
        }
    }
}
