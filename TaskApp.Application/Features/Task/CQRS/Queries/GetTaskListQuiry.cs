using MediatR;
using TaskApp.Application.Features.Task.DTOs;
using TaskApp.Application.Responses;

namespace TaskApp.Application.Features.Task.CQRS.Queries
{
    public class GetTaskListQuery : IRequest<Result<List<TaskDto>>>
    {
    }
}