using System;
using Api.DTOs;
using Business.Models;
using Business.Operations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("calc")]
    public class CalculatorController : ControllerBase
    {
        public CalculatorController()
        {
        }

        [HttpGet]
        public ActionResult Default()
        {
            WelcomeMessage message = new WelcomeMessage();
            message.Message = "Esta es la API de la calculadora " + DateTime.Now.ToString();
            message.Weather = "Sunny";
            return Ok(message);
        }

        [HttpGet]
        [Route("do")]
        public string Do(double value1, string operation, double value2)
        {
            OperationBase op;
            switch (operation)
            {
                case "ADD":
                    op = new AddOperation(value2);
                    break;

                case "SUB":
                    op = new SubtractOperation(value2);
                    break;

                case "MUL":
                    op = new MultiplyOperation(value2);
                    break;

                case "DIV":
                    op = new DivideOperation(value2);
                    break;

                default:
                    throw new Exception("operación inválida.");
            }

            double result = op.CalculateResult(value1);
            return string.Format("El resultado de la cuenta es: {0}", result);
        }

        [Authorize]
        [HttpGet]
        [Route("history")]
        public ActionResult DoHistory(OperationValueList operations)
        {
            CalculatorWithHistory calc = new CalculatorWithHistory();
            calc.Add(operations.Value);

            foreach (var item in operations.Operations)
            {
                OperationBase add = this.GetOperationById(item.OperationId);
                add.Value = item.Value;
                calc.Add(add);
            }

            double result = calc.Do();
            return Ok(result);
        }

        [Authorize]
        [HttpGet]
        [Route("test")]
        public ActionResult GetJson()
        {
            // 4 + 3 + 5 - 2 = 10
            OperationValueList rett = new OperationValueList();
            rett.Value = 4;
            rett.Operations.Add(new OperationValueKeyPair(3, "ADD"));
            rett.Operations.Add(new OperationValueKeyPair(5, "ADD"));
            rett.Operations.Add(new OperationValueKeyPair(2, "SUB"));

            return Ok(rett);
        }

        [HttpGet]
        [Route("add")]
        public string Add(double value1, double value2)
        {
            OperationBase op = new AddOperation(value2);
            double result = op.CalculateResult(value1);
            return string.Format("El resultado de la cuenta es: {0}", result);
        }

        [HttpGet]
        [Route("sub")]
        public string Sub(double value1, double value2)
        {
            OperationBase op = new SubtractOperation(value2);
            double result = op.CalculateResult(value1);
            return string.Format("El resultado de la cuenta es: {0}", result);
        }

        [HttpGet]
        [Route("mul")]
        public string Mul(double value1, double value2)
        {
            OperationBase op = new MultiplyOperation(value2);
            double result = op.CalculateResult(value1);
            return string.Format("El resultado de la cuenta es: {0}", result);
        }

        [HttpGet]
        [Route("div")]
        public string Div(double value1, double value2)
        {
            OperationBase op = new DivideOperation(value2);
            double result = op.CalculateResult(value1);
            return string.Format("El resultado de la cuenta es: {0}", result);
        }

        private OperationBase GetOperationById(string id)
        {
            switch (id)
            {
                case "ADD":
                    return new AddOperation();

                case "SUB":
                    return new SubtractOperation();

                case "MUL":
                    return new MultiplyOperation();

                case "DIV":
                    return new DivideOperation();

                default:
                    throw new Exception("operación inválida.");
            }
        }
    }
}