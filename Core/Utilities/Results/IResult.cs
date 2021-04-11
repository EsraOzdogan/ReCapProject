using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Temel voidler için başlangıç,void için yapmaya çalıştığın fonksiyon için başarılı veya başarısız diyor ve mesaj yolluyor
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
