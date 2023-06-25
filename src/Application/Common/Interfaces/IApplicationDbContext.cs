using valkimia_challenge.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace valkimia_challenge.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<TodoList> TodoLists { get; }

    DbSet<TodoItem> TodoItems { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
