using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorResult:Result
    {
        public ErrorResult(string message) : base(false, message)   //base= Result classı yani
        {

        }
        public ErrorResult() : base(false)
        {

        }
    }
}
