using System;
using System.Threading.Tasks;
using AspNetCoreTodo.Models;

namespace AspNetCoreTodo.Services
{
    public class FakeTodoItemService : ITodoItemService
    {
        public Task<TodoItem[]> GetIncompleteItemsAsync()
        {
            var item1 = new TodoItem
            {
                Title = "Go through Little ASP.NET Core Book",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };

            var item2 = new TodoItem
            {
                Title = "Go make an API!",
                DueAt = DateTimeOffset.Now.AddDays(4)
            };

            return Task.FromResult(new[] { item1, item2 });
        }
    }
}