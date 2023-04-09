using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePatternExamen
{
    // Commande pour ajouter des informations supplémentaires au matériel
    public class AdditionalInfoCommand : ICommand
    {
        private IMaterial material;
        private string additionalInfo;
        private AdditionalInfoDecorator v;

        public AdditionalInfoCommand(AdditionalInfoDecorator v)
        {
            this.v = v;
        }

        public AdditionalInfoCommand(IMaterial material, string additionalInfo)
        {
            this.material = material;
            this.additionalInfo = additionalInfo;
        }

        public void Execute()
        {
            AdditionalInfoDecorator decoratedMaterial = new AdditionalInfoDecorator((Material)this.material, this.additionalInfo);
            this.material = decoratedMaterial;
            Console.WriteLine("Des informations supplémentaires ont été ajoutées au matériel.");
        }
    }
}
