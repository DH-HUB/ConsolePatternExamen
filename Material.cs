using ConsolePatternExamen;

namespace ConsolePatternExamen
{
    public class Material : IMaterial
    {
        private string name;
        private object material;

        public Material(string name)
        {
            this.name = name;
        }

        public object? Name { get; internal set; }
        public ICommand State { get; private set; }

        public void ChangeState(ICommand newState)
        {
            this.State = newState;
            newState.Execute();
        }

        public void Display()
        {
            Console.WriteLine("Nom du material : " + this.name);
        }

        public void Execute()
        {
            Console.WriteLine("Execution du material : " + this.name);
        }

        public void DisplayState()
        {
            if (material is BorrowedState)
            {
                Console.WriteLine("L'état du matériel est : emprunté");
            }
            else if (material is RepairingState)
            {
                Console.WriteLine("L'état du matériel est : en réparation");
            }
            else if (material is NonReparableState)
            {
                Console.WriteLine("L'état du matériel est : non réparable");
            }
            else
            {
                Console.WriteLine("L'état du matériel est : disponible");
            }
        }

        public void ChangeState(object state)
        {
            throw new NotImplementedException();
        }


        /*la méthode  crée un nouvel objet Material en utilisant le nom extrait de l'objet AdditionalInfoDecorator 
         * et en initialisant la propriété material avec l'objet AdditionalInfoDecorator.
         * Elle crée également une nouvelle instance de la classe AdditionalInfoCommand
         * en passant l'objet AdditionalInfoDecorator comme argument au constructeur, et l'assigne à la propriété State 
         * de l'objet Material. Elle retourne le nouvel objet Material créé.*/
        public static implicit operator Material(AdditionalInfoDecorator v)
        {
            Material material = new Material(v.Name);
            material.material = v;
            material.State = new AdditionalInfoCommand(v);
            return material;
        }
    }
}
   
