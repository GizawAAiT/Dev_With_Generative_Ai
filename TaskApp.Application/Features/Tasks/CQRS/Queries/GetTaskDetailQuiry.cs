using MediatR;
using TaskApp.Application.Responses;

namespace TaskApp.Application.Features.Task.CQRS.Queries
{
    public class GetTaskQuery : IRequest<Result<TaskDto>>
    {
        public int TaskId { get; set; }
    }
}