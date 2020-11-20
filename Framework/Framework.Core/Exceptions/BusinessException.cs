using System;

namespace Framework.Core.Exceptions
{
    public class BusinessException:Exception
    {
        public long Code { get; set; }
        public BusinessException(long code,string message):base(message)
        {
            Code = code;
        }
    }
}