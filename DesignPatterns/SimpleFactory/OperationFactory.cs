namespace DesignPatterns.SimpleFactory
{
    public class OperationFactory
    {
        public static IOperation CreateOperation(OperationType operationType)
        {
            switch(operationType)
            {
                case OperationType.Addition:
                    return new Addition();
                case OperationType.Subtraction:
                    return new Subtraction();
                default:
                    return null;
            }
        }
    }
}