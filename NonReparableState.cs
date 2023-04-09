namespace ConsolePatternExamen
{
    public class NonReparableState : ICommand
    {
        private Material material;

        public NonReparableState(Material material)
        {
            this.material = material;
        }

        public void Execute()
        {
            Console.WriteLine("{0} est non réparable", material.Name);
        }
    }
}