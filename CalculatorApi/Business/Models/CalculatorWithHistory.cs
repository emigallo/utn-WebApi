using System;
using System.Collections.Generic;
using System.Linq;
using Business.Interfaces;
using Business.Operations;

namespace Business.Models
{
    public class CalculatorWithHistory : ICopy
    {
        public CalculatorWithHistory()
        {
            this.FullCopy = true;
            this.Input = new ValueInput(0);
        }

        private ValueInput Input { get; set; }

        public bool FullCopy { get; set; }

        public double Do()
        {
            double result = this.Input.Value;

            foreach (OperationBase op in this.Input.GetOperations())
            {
                result = op.CalculateResult(result);
            }

            return result;
        }

        public void Add(double value)
        {
            this.Input = new ValueInput(value);
        }

        public void Add(OperationBase op)
        {
            this.Input.AddOperation(op);
        }

        public void AddValueToLastOperation(double value)
        {
            if (this.Input.GetOperations().Any())
            {
                this.Input.GetOperations().Last().Value = value;
            }
        }

        /// <summary>
        ///  TODO - Devolver en formato string, todos los inputs ingresados al momento
        ///  Formato: + 3 - 4 / 9
        /// </summary>
        /// <returns></returns>
        public string GetInputs()
        {
            return string.Empty;
        }

        /// <summary>
        /// TODO - Como el 'GetInputs()' pero solamente las operaciones de suma
        /// </summary>
        /// <returns></returns>
        public string GetOnlyAddOperationInputs()
        {
            return string.Empty;
        }

        /// <summary>
        /// TODO - Devolver true si la 'operacion' esta contenida en la list de 'Operations'
        /// </summary>
        /// <param name="operation"></param>
        /// <returns></returns>
        public Boolean ContainsOperation(OperationBase operation)
        {
            return true;
        }
    }
}