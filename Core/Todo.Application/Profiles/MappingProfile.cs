using AutoMapper;

namespace Todo.Application.Profiles;

public class MappingProfile: Profile
{
    public MappingProfile()
    {
        CreateMap<Domain.Entities.Todo, DTOs.TodoDto>().ReverseMap();
    }
}