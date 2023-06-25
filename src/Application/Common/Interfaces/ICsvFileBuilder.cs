using valkimia_challenge.Application.TodoLists.Queries.ExportTodos;

namespace valkimia_challenge.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
