using AutoMapper;
using TaskApp.Application.Contracts.Persistence;
using TaskApp.Application.Features.Task.CQRS.Commands;
using TaskApp.Application.Responses;
using MediatR;

namespace TaskApp.Application.Features.Task.CQRS.Handlers
{
    public class DeleteTaskCommandHandler : IRequestHandler<DeleteTaskCommand,Result<Unit>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DeleteTaskCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<Unit>> Handle(DeleteTaskCommand request, CancellationToken cancellationToken)
        {
            var response = new Result<Unit>();
            var Task = await _unitOfWork.TaskRepository.Get(request.Id);

            if (Task == null)
            {
                return null;
            }
            else
            {
                await _unitOfWork.TaskRepository.Delete(Task);
                if (await _unitOfWork.Save() > 0 )
                {
                    response.Success = true;
                    response.Message = "Delete Successful";
                }
                else
                {
                    response.Success = false;
                    response.Message = "Delete Failed";
                }
            
            }
            return response;
        }
    }
}