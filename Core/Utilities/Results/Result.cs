﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {

        public Result(bool success, string message):this(success)//constructor
        {
            Message = message;
        }
        public Result(bool success)//constructor overloading //sadece başarılı olmasının da döndürmek isteyebiliriz
        {
            Success = success;
        }
        public bool Success { get; }

        public string Message { get; }
    }
}
