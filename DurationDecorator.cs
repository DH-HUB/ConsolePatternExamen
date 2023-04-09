using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePatternExamen
{
    public class DurationDecorator : MaterialDecorator
    {
        private int duration;
        private string v;

        public DurationDecorator(IMaterial material, int duration) : base(material)
        {
            this.duration = duration;
        }

        public DurationDecorator(IMaterial material, string v) : base(material)
        {
            this.v = v;
        }

        public override void Execute()
        {
            DateTime startTime = DateTime.Now;
            base.Execute();
            DateTime endTime = DateTime.Now;
            Console.WriteLine("Durée d'exécution : " + (endTime - startTime).TotalSeconds + " secondes");
        }
    }
}
    