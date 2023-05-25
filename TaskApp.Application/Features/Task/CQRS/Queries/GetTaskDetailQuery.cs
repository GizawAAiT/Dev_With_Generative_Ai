using MediatR;
using TaskApp.Application.Features.Task.DTOs;
using TaskApp.Application.Responses;

namespace TaskApp.Application.Features.Task.CQRS.Queries
{
    public class GetTaskDetailQuery : IRequest<Result<TaskDto>>
    {
        public int TaskId { get; set; }
    }
}