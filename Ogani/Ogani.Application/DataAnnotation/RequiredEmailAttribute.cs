using System;
using System.ComponentModel.DataAnnotations;
using Ogani.Application.Extensions;

namespace Ogani.Application.DataAnnotation
{
	public class RequiredEmailAttribute : RequiredAttribute
	{
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            // is-in bu versiyasi tryParse-a oxsayir 
            if (value is string email && email.IsEmail())
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("E-poct unvaniniz uygun deyil");
        }
    }
}

