using valkimia_challenge.Application.Common.Exceptions;
using valkimia_challenge.Application.TodoLists.Commands.CreateTodoList;
using valkimia_challenge.Application.TodoLists.Commands.DeleteTodoList;
using valkimia_challenge.Domain.Entities;
using FluentAssertions;
using NUnit.Framework;

namespace valkimia_challenge.Application.IntegrationTests.TodoLists.Commands;

using static Testing;

public class DeleteTodoListTests : BaseTestFixture
{
    [Test]
    public async Task ShouldRequireValidTodoListId()
    {
        var command = new DeleteTodoListCommand(99);
        await FluentActions.Invoking(() => SendAsync(command)).Should().ThrowAsync<NotFoundException>();
    }

    [Test]
    public async Task ShouldDeleteTodoList()
    {
        var listId = await SendAsync(new CreateTodoListCommand
        {
            Title = "New List"
        });

        await SendAsync(new DeleteTodoListCommand(listId));

        var list = await FindAsync<TodoList>(listId);

        list.Should().BeNull();
    }
}
