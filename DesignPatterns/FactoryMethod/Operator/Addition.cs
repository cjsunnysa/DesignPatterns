namespace DesignPatterns.FactoryMethod
{
    public class Addition : IOperator
    {
        public int Execute(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}