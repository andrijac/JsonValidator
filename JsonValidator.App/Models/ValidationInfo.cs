namespace JsonValidator.App.Models
{
    public record ValidationInfo(
            string Message,
            long? Line,
            long? ByteInLine,
            bool IsSuccessful)
    {
        internal static ValidationInfo Successful()
        {
            return new ValidationInfo(string.Empty, null, null, true);
        }

        internal static ValidationInfo Failed(string errorMessage)
        {
            return new ValidationInfo(errorMessage, null, null, false);
        }
    }
}