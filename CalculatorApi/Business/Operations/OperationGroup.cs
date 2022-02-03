namespace Business.Operations
{
    public class OperationGroup
    {
        public OperationGroup()
        {
            this.Operation = new DefaultOperation();
            this.Value1 = 0;
            this.Value2 = 0;
        }

        public OperationBase Operation { get; private set; }

        public double Value1 { get; private set; }

        public double Value2 { get; private set; }

        public void AddOperation(OperationBase operation)
        {
            this.Operation = operation;
        }

        public void AddValue(double value)
        {
            if (this.Value1 == 0)
            {
                this.Value1 = value;
            }
            else
            {
                this.Value2 = value;
            }
        }
    }
}