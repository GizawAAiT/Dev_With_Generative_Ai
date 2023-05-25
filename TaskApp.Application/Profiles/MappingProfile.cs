using AutoMapper;
using TaskApp.Application.Features.Task.CQRS.Commands;
using TaskApp.Application.Features.Task.DTOs;

namespace TaskApp.Application.Profiles
{
    public class TaskProfile : Profile
    {
        public TaskProfile()
        {
            CreateMap<Task, TaskDto>().ReverseMap();
            CreateMap<CreateTaskCommand, Task>().ReverseMap();
            CreateMap<UpdateTaskCommand, Task>().ReverseMap();
        }
    }              
}
