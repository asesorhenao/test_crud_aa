using FluentValidation;
using Inscriptions.Core.DTOs;

namespace Inscriptions.Infrastructure.Validators
{
    public class InscriptionValidtor : AbstractValidator<InscriptionDto>
    {
        public InscriptionValidtor()
        {
            RuleFor(inscription => inscription.FirstName)
                .NotNull()
                .Length(1, 50);

            RuleFor(inscription => inscription.LastName)
                .NotNull()
                .Length(1, 50);

            RuleFor(inscription => inscription.DocumentNumber)
                .NotNull()
                .Length(1, 50);

            RuleFor(inscription => inscription.CellphoneNumber)
                .NotNull()
                .Length(1, 50);

            RuleFor(inscription => inscription.Email)
                .NotNull()
                .EmailAddress();

            RuleFor(inscription => inscription.Direcction)
                .NotNull()
                .Length(1, 50);

        }
    }
}
