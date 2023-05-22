using MediatR;
using TaskApp.Application.Responses;

namespace TaskApp.Application.Features.Task.CQRS.Commands
{
    public class CreateTaskCommand : IRequest<Result<int>>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
