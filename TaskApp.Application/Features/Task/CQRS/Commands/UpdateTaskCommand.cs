using MediatR;
using TaskApp.Application.Features.Task.DTOs;
using TaskApp.Application.Responses;

namespace TaskApp.Application.Features.Task.CQRS.Commands
{
    public class UpdateTaskCommand : IRequest<Result<Unit>>
    {
        public UpdateTaskDto? TaskDto { get; set; }
    }
}