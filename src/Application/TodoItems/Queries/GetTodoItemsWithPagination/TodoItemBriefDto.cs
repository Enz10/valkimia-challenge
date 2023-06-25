using valkimia_challenge.Application.Common.Mappings;
using valkimia_challenge.Domain.Entities;

namespace valkimia_challenge.Application.TodoItems.Queries.GetTodoItemsWithPagination;

public class TodoItemBriefDto : IMapFrom<TodoItem>
{
    public int Id { get; init; }

    public int ListId { get; init; }

    public string? Title { get; init; }

    public bool Done { get; init; }
}
