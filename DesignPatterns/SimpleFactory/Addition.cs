namespace DesignPatterns.SimpleFactory
{
    public class Addition : IOperation
    {
        public decimal Execute(decimal val1, decimal val2)
        {
            return val1 + val2;
        }
    }
}