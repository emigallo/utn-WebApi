namespace Business.Operations
{
    public class MultiplyOperation : OperationBase
    {
        public MultiplyOperation() : base("*")
        {
        }

        public MultiplyOperation(double value = 0) : base("*", value)
        {
        }

        public override double CalculateResult(double input1)
        {
            return input1 * this.Value;
        }
    }
}