namespace DesignPatterns.FactoryMethod
{
    public class SubtractionOperationProgram : OperationProgram
    {
        protected override IOperator CreateOperator()
        {
            return new Subtraction();
        }
    }
}