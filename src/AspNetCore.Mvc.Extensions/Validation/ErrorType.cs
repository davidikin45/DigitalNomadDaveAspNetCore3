namespace AspNetCore.Mvc.Extensions.Validation
{
    public enum ErrorType
    {
        UnknownError,
        NotFound,
        ValidationFailed,
        ConcurrencyConflict,
        EmailSendFailed,
        Unauthorized
    }
}
