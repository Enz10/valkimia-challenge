using valkimia_challenge.Application.Common.Mappings;
using valkimia_challenge.Domain.Entities;

namespace valkimia_challenge.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; init; }

    public bool Done { get; init; }
}
