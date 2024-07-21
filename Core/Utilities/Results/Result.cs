using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        /* this komutu tek parametreli constructorın calısmasını saglıyor boylelikle iki parametreli 1. ctor 
        calısırsa aynı anda 2. de calısıyor.*/
        public Result(bool success,string message):this(success)
        {
           
           Message = message;   
        }
        public Result(bool success)
        {
            Success = success;
        }




        public bool Success { get; }

        public string Message { get; }
    }
}
