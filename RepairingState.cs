namespace ConsolePatternExamen
{
    // État du matériel: en cours de réparation
    public class RepairingState : ICommand
    {
        private readonly Material material;
        private Material material2;


        public RepairingState(Material material)
        {
            this.material = material;
        }

        public void Execute()
        {
            Console.WriteLine("{0} est en cours de réparation", material.Name);
        }
    }
}