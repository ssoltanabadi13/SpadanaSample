namespace Framework.Core.GenericDto
{
    public class ValidationResultDto
    {
        public ValidationResultDto(bool isValid)
        {
            IsValid = isValid;
        }

        public bool IsValid { get; set; }
    }
}