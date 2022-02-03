namespace Business.Operations
{
    public class DivideOperation : OperationBase
    {
        public DivideOperation() : base("/")
        {
        }

        public DivideOperation(double value = 0) : base("/", value)
        {
        }

        public override double CalculateResult(double input1)
        {
            return input1 / base.Value;
        }
    }
}