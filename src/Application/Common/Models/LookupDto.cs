using valkimia_challenge.Application.Common.Mappings;
using valkimia_challenge.Domain.Entities;

namespace valkimia_challenge.Application.Common.Models;

// Note: This is currently just used to demonstrate applying multiple IMapFrom attributes.
public class LookupDto : IMapFrom<TodoList>, IMapFrom<TodoItem>
{
    public int Id { get; init; }

    public string? Title { get; init; }
}
