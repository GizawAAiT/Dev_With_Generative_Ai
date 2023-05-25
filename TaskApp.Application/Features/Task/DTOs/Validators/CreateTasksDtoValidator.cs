using FluentValidation;

namespace TaskApp.Application.Features.Task.DTOs.Validators
{
    public class CreateTaskDtoValidator : AbstractValidator<CreateTaskDto>
    {
        public CreateTaskDtoValidator()
        {
            Include(new ITasksDtoValidator());
        }
    }

}
