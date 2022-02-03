using Business.Operations;

namespace Business.Models
{
    public class OperationInput : Input
    {
        public OperationInput(OperationBase operation)
        {
            this.Operation = operation;
        }

        public OperationBase Operation { get; init; }
    }
}