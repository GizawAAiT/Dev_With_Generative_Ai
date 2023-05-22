using MediatR;
using TaskApp.Application.Responses;

namespace TaskApp.Application.Features.Task.CQRS.Commands
{
    public class UpdateTaskCommand : IRequest<Result<Unit>>
    {
        public int TaskId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}