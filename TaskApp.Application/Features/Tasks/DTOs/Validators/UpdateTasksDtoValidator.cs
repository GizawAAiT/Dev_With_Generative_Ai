
using BlogApp.Application.Features.Reviews.DTOs.Validators;
using FluentValidation;
using TaskApp.Application.Features.Task.DTOs;

namespace TaskApp.Application.Features.Reviews.DTOs.Validators
{
    public class UpdateReviewDtoValidator : AbstractValidator<UpdateTaskDto>
    {
        public UpdateReviewDtoValidator()
        {
            Include(new ITasksDtoValidator());

            RuleFor(p => p.Id).NotNull().WithMessage("{PropertyName} must be present");
        }
    }
}
