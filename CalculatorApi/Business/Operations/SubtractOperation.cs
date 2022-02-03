namespace Business.Operations
{
    public class SubtractOperation : OperationBase
    {
        public SubtractOperation() : base("-")
        {
        }

        public SubtractOperation(double value) : base("-", value)
        {
        }

        public override double CalculateResult(double input1)
        {
            return input1 - base.Value;
        }
    }
}