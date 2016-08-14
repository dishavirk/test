using System;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace todoapp.Models {
    public class ToDoRepository : IToDoRepository {
        private static ConcurrentDictionary<string, ToDoItem> dict = 
        new ConcurrentDictionary<string, ToDoItem>();

        public void Add(ToDoItem item) {
            item.Key = Guid.NewGuid().ToString();
            dict[item.Key] = item;
        }
        public ToDoItem Remove(string key) {
            ToDoItem item;
            dict.TryRemove(key, out item);
            return item;
        }
        public void Update(ToDoItem item) {
            dict[item.Key] = item;
        }

        public IEnumerable<ToDoItem> GetAll() {
            return dict.Values;
        }
        public ToDoItem Find(string key) {
            ToDoItem item;
            dict.TryGetValue(key, out item);
            return item;
        }
    }
}