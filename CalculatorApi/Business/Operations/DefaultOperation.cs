namespace Business.Operations
{
    public class DefaultOperation : OperationBase
    {
        public DefaultOperation() : base(string.Empty, 0)
        {

        }

        public override double CalculateResult(double input1)
        {
            return input1;
        }
    }
}