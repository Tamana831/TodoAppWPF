using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoAppWPF
{
    /// <summary>
    /// Hantera Logiken för att lägga till, ta bort och uppdatera TodoItems 
    /// </summary>
    public class TodoList
    {
        private List<String> tasks = new List<string>();
        public void AddTask(string task)

        {
            task.Add(task);
        }
        public void RemoveTask(int index )
        {
            if (index >= 0 && index < tasks.Count)
            {
                tasks.RemoveAt(index);
            }
        }
        public List<string> GetAllTasks()

        {
            return tasks;
        }
    }
}
