using ToDoApp.Models;
namespace ToDoApp.Services
{
    public class TodoService
    {
        private List<TodoItem> items = new List<TodoItem>();

        public IEnumerable<TodoItem> GetItems() => items;

        public void AddItem(TodoItem item) => items.Add(item);

        public void RemoveItem(int id) => items.RemoveAll(item => item.Id == id);

        public void ToggleItem(int id)
        {
            var item = items.FirstOrDefault(item => item.Id == id);
            if (item != null)
            {
                item.IsCompleted = !item.IsCompleted;
            }
        }
    }
}
