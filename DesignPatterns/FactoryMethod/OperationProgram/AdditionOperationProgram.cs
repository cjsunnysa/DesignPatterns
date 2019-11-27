namespace DesignPatterns.FactoryMethod
{
    public class AdditionOperationProgram : OperationProgram
    {
        protected override IOperator CreateOperator()
        {
            return new Addition();
        }
    }
}