using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspNetCore.Mvc.Extensions.Validation
{
    public class Result
    {
        public byte[] NewRowVersion { get; }
        public IEnumerable<ValidationResult> Errors { get; }
        public bool IsSuccess { get; }
        public ErrorType? ErrorType { get; private set; }
        public bool IsFailure => !IsSuccess;

        protected Result(bool isSuccess, ErrorType? errorType, IEnumerable<ValidationResult> errors, byte[] newRowVersion)
        {
            if (isSuccess && errorType != null)
                throw new InvalidOperationException();
            if (!isSuccess && errorType == null)
                throw new InvalidOperationException();

            IsSuccess = isSuccess;
            ErrorType = errorType;
            Errors = errors;
            NewRowVersion = newRowVersion;
        }

        #region Validation Failed
        public static Result ValidationFailed(string errorMessage)
        {
            var list = new List<ValidationResult>();
            list.Add(new ValidationResult(errorMessage));
            return ValidationFailed(list);
        }

        public static Result ValidationFailed(string errorMessage, IEnumerable<string> memberNames)
        {
            var list = new List<ValidationResult>();
            list.Add(new ValidationResult(errorMessage, memberNames));
            return ValidationFailed(list);
        }

        public static Result<T> ValidationFailed<T>(string errorMessage)
        {
            var list = new List<ValidationResult>();
            list.Add(new ValidationResult(errorMessage));
            return ValidationFailed<T>(list);
        }

        public static Result<T> ValidationFailed<T>(string errorMessage, IEnumerable<string> memberNames)
        {
            var list = new List<ValidationResult>();
            list.Add(new ValidationResult(errorMessage, memberNames));
            return ValidationFailed<T>(list);
        }

        public static Result ValidationFailed(ValidationResult objectValidationError)
        {
            return new Result(false, Validation.ErrorType.ValidationFailed, new ValidationResult[] { objectValidationError }, null);
        }

        public static Result<T> ValidationFailed<T>(ValidationResult objectValidationError)
        {
            return new Result<T>(default(T), false, Validation.ErrorType.ValidationFailed, new ValidationResult[] { objectValidationError }, null);
        }

        public static Result ValidationFailed(IEnumerable<ValidationResult> ObjectValidationErrors)
        {
            return new Result(false, Validation.ErrorType.ValidationFailed, ObjectValidationErrors, null);
        }

        public static Result<T> ValidationFailed<T>(IEnumerable<ValidationResult> ObjectValidationErrors)
        {
            return new Result<T>(default(T), false, Validation.ErrorType.ValidationFailed, ObjectValidationErrors, null);
        }
        #endregion

        #region Not Found
        public static Result NotFound()
        {
            return new Result(false, Validation.ErrorType.NotFound, new List<ValidationResult>(), null);
        }

        public static Result<T> NotFound<T>()
        {
            return new Result<T>(default(T), false, Validation.ErrorType.NotFound, new List<ValidationResult>(), null);
        }
        #endregion

        #region Concurrency Conflict
        public static Result ConcurrencyConflict(string errorMessage)
        {
            var list = new List<ValidationResult>();
            list.Add(new ValidationResult(errorMessage));
            return ConcurrencyConflict(list, null);
        }

        public static Result ConcurrencyConflict(IEnumerable<ValidationResult> concurrencyConflictErrors, byte[] newRowVersion)
        {
            return new Result(false, Validation.ErrorType.ConcurrencyConflict, concurrencyConflictErrors, newRowVersion);
        }

        public static Result<T> ConcurrencyConflict<T>(string errorMessage)
        {
            var list = new List<ValidationResult>();
            list.Add(new ValidationResult(errorMessage));
            return ConcurrencyConflict<T>(list, null);
        }

        public static Result<T> ConcurrencyConflict<T>(IEnumerable<ValidationResult> concurrencyConflictErrors, byte[] newRowVersion)
        {
            return new Result<T>(default(T), false, Validation.ErrorType.ConcurrencyConflict, concurrencyConflictErrors, newRowVersion);
        }
        #endregion

        #region Unauthorized
        public static Result Unauthorized(string errorMessage)
        {
            var list = new List<ValidationResult>();
            list.Add(new ValidationResult(errorMessage));
            return Unauthorized(list);
        }

        public static Result Unauthorized(IEnumerable<ValidationResult> unauthorizedErrors)
        {
            return new Result(false, Validation.ErrorType.Unauthorized, unauthorizedErrors, null);
        }

        public static Result<T> Unauthorized<T>(string errorMessage)
        {
            var list = new List<ValidationResult>();
            list.Add(new ValidationResult(errorMessage));
            return Unauthorized<T>(list);
        }

        public static Result<T> Unauthorized<T>(IEnumerable<ValidationResult> unauthorizedErrors)
        {
            return new Result<T>(default(T), false, Validation.ErrorType.Unauthorized, unauthorizedErrors, null);
        }
        #endregion

        public static Result Fail(ErrorType errorType)
        {
            return new Result(false, errorType, new List<ValidationResult>(), null);
        }

        public static Result<T> Fail<T>(ErrorType errorType)
        {
            return new Result<T>(default(T), false, errorType, new List<ValidationResult>(), null);
        }

        public static Result Ok()
        {
            return new Result(true, null, new List<ValidationResult>(), null);
        }

        public static Result<T> Ok<T>(T value)
        {
            return new Result<T>(value, true, null, new List<ValidationResult>(), null);
        }

        public static Result Combine(params Result[] results)
        {
            foreach (Result result in results)
            {
                if (result.IsFailure)
                    return result;
            }

            return Ok();
        }

        public static Result Combine(IEnumerable<Result> results)
        {
            foreach (Result result in results)
            {
                if (result.IsFailure)
                    return result;
            }

            return Ok();
        }
    }

    public class Result<T> : Result
    {
        private readonly T _value;
        public T Value
        {
            get
            {
                if (!IsSuccess)
                    throw new InvalidOperationException();

                return _value;
            }
        }

        protected internal Result(T value, bool isSuccess, ErrorType? errorType, IEnumerable<ValidationResult> ObjectValidationErrors, byte[] newRowVersion)
            : base(isSuccess, errorType, ObjectValidationErrors, newRowVersion)
        {
            _value = value;
        }
    }
}
