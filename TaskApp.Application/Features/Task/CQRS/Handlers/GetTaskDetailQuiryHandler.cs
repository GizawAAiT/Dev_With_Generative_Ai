using AutoMapper;
using TaskApp.Application.Contracts.Persistence;
using MediatR;
using TaskApp.Application.Features.Task.DTOs;
using TaskApp.Application.Responses;
using TaskApp.Application.Features.Task.CQRS.Queries;

namespace TaskApp.Application.Features.Rates.CQRS.Handlers
{
    public class GetTaskDetailQueryHandler : IRequestHandler<GetTaskDetailQuery,Result<TaskDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetTaskDetailQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<Result<TaskDto>> Handle(GetTaskDetailQuery request, CancellationToken cancellationToken)
        {
            var response = new Result<TaskDto>();
            var task = await _unitOfWork.TaskRepository.Get(request.TaskId);
            response.Success = true;
            response.Message = "Fetch Success";
            response.Value = _mapper.Map<TaskDto>(task);

            return response;
        }
    }
}