﻿using FluentValidation;

namespace MP.ApiDotNet6.Application.DTOs.Validations
{
    internal class PersonDTOValidatior : AbstractValidator<PersonDTO>
    {
        public PersonDTOValidatior()
        {
            RuleFor(x => x.Document)
                .NotEmpty()
                .NotNull()
                .WithMessage("Documento deve ser informado!");

            RuleFor(x => x.Name)
                .NotNull()
                .NotEmpty()
                .WithMessage("Name deve ser informado!");

            RuleFor(x => x.Phone)
                .NotEmpty()
                .NotNull()
                .WithMessage("Phone deve ser informado!");
        }
    }
}
