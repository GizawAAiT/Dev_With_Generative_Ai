using MediatR;
using TaskApp.Application.Features.Task.DTOs;
using TaskApp.Application.Responses;

namespace TaskApp.Application.Features.Task.CQRS.Commands
{
    public class CreateTaskCommand : IRequest<Result<int>>
    {
        public CreateTaskDto? TaskDto {get; set;}
    }
}
