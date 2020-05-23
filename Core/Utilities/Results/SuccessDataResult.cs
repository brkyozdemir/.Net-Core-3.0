using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        public SuccessDataResult(T data, string message) : base(data, true, message)
        {

        }

        public SuccessDataResult(T data) : base(true, data)
        {
        }

        public SuccessDataResult(string message):base(default, true, message)
        {
            
        }

        public SuccessDataResult():base(true,default)
        {
            
        }
    }
}
