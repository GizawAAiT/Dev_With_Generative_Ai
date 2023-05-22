using MediatR;
using TaskApp.Application.Responses;

namespace TaskApp.Application.Features.Ckecklists.CQRS.Commands
{
    public class CreateChecklistCommand : IRequest<Result<int>>
    {
        public CreateChecklistDto CreateChecklistDto { get; set; }

    }
}
