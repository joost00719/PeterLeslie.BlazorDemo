using App;
using FluentValidation;
using System;
using System.Xml.Schema;

namespace Validators
{
    public class SimpleCustomerValidator : AbstractValidator<SimpleCustomer>
    {
        public SimpleCustomerValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty();
        }
    }

    public class ComplexUserValidator : SimpleCustomerValidator
    {
        public ComplexUserValidator()
            : base()
        {
            // some more validation rules
        }
    }
}
