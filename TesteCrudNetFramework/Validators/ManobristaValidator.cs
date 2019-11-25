using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TesteCrudNetFramework.Models;

namespace TesteCrudNetFramework.Validators
{
    public class ManobristaValidator : AbstractValidator<Manobrista>
    {
        public ManobristaValidator()
        {
            RuleFor(m => m.Nome)
                .NotNull()
                .WithMessage("{PropertyName} não pode ser nula");

            RuleFor(m=> m.Cpf)
                .NotNull()
                .WithMessage("{PropertyName} não pode ser nula");
        }
    }
}