using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.DTOs
{
    public class OperationValueList
    {
        public OperationValueList()
        {
            this.Operations = new List<OperationValueKeyPair>();
        }

        public double Value { get; set; }
        public List<OperationValueKeyPair> Operations { get; set; }
    }
}