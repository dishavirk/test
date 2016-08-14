using System.Collections.Generic;

namespace todoapp.Models
{public interface IToDoRepository
    {
        void Add (ToDoItem item);
        IEnumerable<ToDoItem> GetAll();
        ToDoItem Find(string Key);
        ToDoItem Remove(string Key);
        void Update(ToDoItem item);

    }
}