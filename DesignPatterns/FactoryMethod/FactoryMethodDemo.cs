namespace DesignPatterns.FactoryMethod
{
    public class FactoryMethodDemo : IExecutable
    {
        public void Run()
        {
            OperationProgram program;

            program = new AdditionOperationProgram();
            program.Run();

            program = new SubtractionOperationProgram();
            program.Run();
        }
    }
}