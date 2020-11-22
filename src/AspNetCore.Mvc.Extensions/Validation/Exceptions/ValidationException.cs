using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore.Mvc.Extensions.Validation.Exceptions
{
    public class ValidationException : Exception
    {
        public ValidationException()
            : base("One or more validation errors have occurred.")
        {
            Errors = new Dictionary<string, string[]>();
        }

        public ValidationException(IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> errors)
            : this()
        {
            var errorGroups = new Dictionary<string, List<string>>();

            foreach (var err in errors)
            {
                if (err.MemberNames.Any())
                {
                    foreach (var prop in err.MemberNames)
                    {
                        if (!errorGroups.ContainsKey(prop))
                            errorGroups.Add(prop, new List<string>());

                        errorGroups[prop].Add(err.ErrorMessage);
                    }
                }
                else
                {
                    if(!errorGroups.ContainsKey(""))
                        errorGroups.Add("", new List<string>());

                    errorGroups[""].Add(err.ErrorMessage);
                }
            }

            foreach (var failureGroup in errorGroups)
            {
                var propertyName = failureGroup.Key;
                var propertyFailures = failureGroup.Value.ToArray();

                Errors.Add(propertyName, propertyFailures);
            }
        }

        public ValidationException(IEnumerable<ValidationFailure> failures)
            : this()
        {
            var failureGroups = failures
                .GroupBy(e => e.PropertyName, e => e.ErrorMessage);

            foreach (var failureGroup in failureGroups)
            {
                var propertyName = failureGroup.Key;
                var propertyFailures = failureGroup.ToArray();

                Errors.Add(propertyName, propertyFailures);
            }
        }

        public IDictionary<string, string[]> Errors { get; }
    }
}
