
using MediatR;
using TaskApp.Application.Responses;

namespace TaskApp.Application.Features.Ckecklists.CQRS.Commands
{
    public class DeleteChecklistCommand : IRequest<Result<Unit>>
    {
        public int TaskId { get; set; }
    }
}