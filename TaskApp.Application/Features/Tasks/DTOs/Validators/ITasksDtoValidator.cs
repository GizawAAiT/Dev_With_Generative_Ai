using FluentValidation;


namespace BlogApp.Application.Features.Reviews.DTOs.Validators
{
    public class ITasksDtoValidator : AbstractValidator<ITaskDto>
    {
        public ITasksDtoValidator()
        {

            RuleFor(p => p.Title)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull();

            RuleFor(p => p.Description)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull() 
            .MaximumLength(400).WithMessage("{PropertyName} must not exceed {ComparisonValue} characters.");

          

        }
    }
}

