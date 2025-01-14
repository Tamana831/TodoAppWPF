using System;
using System.Collections.Generic;

namespace TodoAppWPF
{
    /// <summary>
    /// Hanterar logiken för att lägga till, ta bort och visa uppgifter.
    /// </summary>
    public class TodoList
    {
        private List<string> _tasks;

        public TodoList()
        {
            _tasks = new List<string>();
        }

        public void AddTask(string task)
        {
            if (!string.IsNullOrWhiteSpace(task))
            {
                _tasks.Add(task);
            }
        }

        public IEnumerable<string> GetAllTasks()
        {
            return _tasks;
        }

        public void RemoveTask(int index)
        {
            if (index >= 0 && index < _tasks.Count)
            {
                _tasks.RemoveAt(index);
            }
        }
    }
}
