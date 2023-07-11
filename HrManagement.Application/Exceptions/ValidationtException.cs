using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrManagement.Application.Exceptions
{
    public class ValidationtException : ApplicationException
    {
        public List<string> Errors { get; set; } = new List<string>();

        public  ValidationtException(ValidationResult validationResult) 
        {
            foreach (var error in validationResult.Errors)
            {
                Errors.Add(error.ErrorMessage);  
            }

        }
    }

    
}
