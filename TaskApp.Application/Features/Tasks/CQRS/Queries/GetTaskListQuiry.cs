using MediatR;
using TaskApp.Application.Responses;

namespace BlogApp.Application.Features.Reviews.CQRS.Queries
{
    public class GetTasksQuery : IRequest<Result<List<TaskDto>>>
    {
    }
}