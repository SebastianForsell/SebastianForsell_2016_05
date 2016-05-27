using System;
using System.ComponentModel.DataAnnotations;

namespace Uppgift1.Models
{
    internal class CheckProductNumberAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return false;
            }
            return value.ToString().StartsWith("p-");
        }
        public override string FormatErrorMessage(string name)
        {
            return "Product number must start with 'p-' and then numbers!";
        }
    }
}