using AutoMapper;
using TaskApp.Application.Contracts.Persistence;
using MediatR;
using TaskApp.Application.Features.Task.DTOs.Validators;
using TaskApp.Application.Features.Task.CQRS.Commands;
using TaskApp.Application.Responses;
using TaskApp.Domain;

namespace TaskApp.Application.Features.Task.CQRS.Handlers
{
    public class CreateTaskCommandHandler : IRequestHandler<CreateTaskCommand, Result<int>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public CreateTaskCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<Result<int>> Handle(CreateTaskCommand request, CancellationToken cancellationToken)
        {
            var response = new Result<int>();
            var validator = new CreateTaskDtoValidator();
            var validationResult = await validator.ValidateAsync(request.TaskDto);
            if (validationResult.IsValid == false)
            {
                response.Success = false;
                response.Message = "Creation Failed";
                response.Errors = validationResult.Errors.Select(q => q.ErrorMessage).ToList();

            }
            else
            {
                var task = _mapper.Map<TaskEntity>(request.TaskDto);

                task = await _unitOfWork.TaskRepository.Add(task);

                if (await _unitOfWork.Save() > 0)
                {
                    response.Success = true;
                    response.Message = "Creation Successfull";
                    response.Value = task.Id;
                }
                else
                {
                    response.Success = false;
                    response.Message = "Creation Failed";

                }
                
            }
            return response;
        }

    }
}
    
       