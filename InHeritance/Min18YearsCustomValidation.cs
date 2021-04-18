using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace InHeritance
{
    public class Min18YearsCustomValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext context)
        {
            var student = (Student)context.ObjectInstance;
            if (student.DateofBirth == null)
            {
                return new ValidationResult("Date of birth cannot be null");
            }
            var age = DateTime.Now.Year - student.DateofBirth.Year;
            return (age>18)?ValidationResult.Success:new ValidationResult("student be atleast 18 yo");
        }
    }
}
