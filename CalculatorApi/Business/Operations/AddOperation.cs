namespace Business.Operations
{
    public class AddOperation : OperationBase
    {
        public AddOperation() : base("+")
        {

        }

        public AddOperation(double value) : base("+", value)
        {

        }

        public override double CalculateResult(double input1)
        {
            string input = base.GetInput();
            return input1 + base.Value;
        }

        public override string GetInput()
        {
            return base.Value.ToString("F2");
        }
    }
}