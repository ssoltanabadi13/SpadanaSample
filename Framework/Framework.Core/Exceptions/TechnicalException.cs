using System;

namespace Framework.Core.Exceptions
{
    public class TechnicalException:Exception
    {
        public long Code { get; set; }
        public TechnicalException(long code,string message):base(message)
        {
            Code = code;
        }
    }
}