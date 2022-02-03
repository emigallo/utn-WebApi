using System.Collections.Generic;
using Business.Operations;

namespace Business.Models
{
    public class Input
    {
        public Input()
        {
            this.Operations = new List<OperationBase>();
        }

        public double Value { get; set; }
        public List<OperationBase> Operations { get; set; }
    }
}