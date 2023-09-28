using AutoMapper;
using MediatR;
using Todo.Application.Features.Todo.Requests.Commands;
using Todo.Application.Persistence.Contracts;

namespace Todo.Application.Features.Todo.Handlers.Commands;

public class CreateTodoHandler: IRequestHandler<CreateTodoRequest, long>
{
    private readonly ITodoRepository _todoRepository;
    private readonly IMapper _mapper;

    public CreateTodoHandler(ITodoRepository todoRepository, IMapper mapper)
    {
        _todoRepository = todoRepository;
        _mapper = mapper;
    }
    
    public async Task<long> Handle(CreateTodoRequest request, CancellationToken cancellationToken)
    {
        var todo = _mapper.Map<Domain.Entities.Todo>(request);
        todo = await _todoRepository.AddAsync(todo, cancellationToken);
        return todo.Id;
    }
}