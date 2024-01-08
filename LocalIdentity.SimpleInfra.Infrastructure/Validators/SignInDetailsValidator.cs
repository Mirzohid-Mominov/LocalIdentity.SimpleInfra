using FluentValidation;
using LocalIdentity.SimpleInfra.Application.Common.Identity.Models;
using LocalIdentity.SimpleInfra.Infrastructure.Settings;
using Microsoft.Extensions.Options;

namespace LocalIdentity.SimpleInfra.Infrastructure.Validators;

public class SignInDetailsValidator : AbstractValidator<SignInDetails>
{
    public SignInDetailsValidator(IOptions<ValidationSettings> validationSettings)
    {
        var validationSettingsValue = validationSettings.Value;

        RuleFor(x => x.EmailAddress).NotEmpty().Matches(validationSettingsValue.EmailAddressRegexPattern);

        RuleFor(x => x.Password).NotEmpty();
    }
}