namespace Framework.Core.Exceptions
{
    public class ExceptionDto
    {
        public string Message { get; set; }

        public long Code { get; set; }

        public ExceptionDto(string message, long code)
        {
            Message = message;
            Code = code;
        }
    }
}