using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.DTOs
{
    public class OperationValueKeyPair
    {
        public OperationValueKeyPair()
        {

        }

        public OperationValueKeyPair(double value, string operationId)
        {
            this.Value = value;
            this.OperationId = operationId;
        }

        public double Value { get; set; }
        public string OperationId { get; set; }
    }
}