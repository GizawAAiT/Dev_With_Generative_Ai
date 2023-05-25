
using MediatR;
using TaskApp.Application.Responses;

namespace TaskApp.Application.Features.Task.CQRS.Commands
{
    public class DeleteTaskCommand : IRequest<Result<Unit>>
    {
        public int Id { get; set; }
    }
}