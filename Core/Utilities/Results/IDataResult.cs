using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //generics
    public interface IDataResult<T>: IResult//IResultdan farklı olarak bir ed data var
    {
        T Data { get; }//araba,arabalar

    }
}
