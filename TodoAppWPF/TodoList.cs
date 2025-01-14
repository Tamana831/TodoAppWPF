using System;
using System.Collections.Generic;

namespace TodoAppWPF
{
    /// <summary>
    /// Hanterar logiken för att lägga till, ta bort och hämta todo-items.
    /// </summary>
    public class TodoList
    {
        private List<string> tasks = new List<string>();

        /// <summary>
        /// Lägger till en ny uppgift i listan.
        /// </summary>
        /// <param name="task">Texten för uppgiften.</param>
        public void AddTask(string task)
        {
            if (!string.IsNullOrWhiteSpace(task))
            {
                tasks.Add(task);
            }
        }

        /// <summary>
        /// Tar bort en uppgift från listan baserat på dess index.
        /// </summary>
        /// <param name="index">Index för uppgiften som ska tas bort.</param>
        public void RemoveTask(int index)
        {
            if (index >= 0 && index < tasks.Count)
            {
                tasks.RemoveAt(index);
            }
        }

        /// <summary>
        /// Hämtar alla uppgifter från listan.
        /// </summary>
        /// <returns>En kopia av listan med uppgifter.</returns>
        public List<string> GetAllTasks()
        {
            return new List<string>(tasks);
        }
    }
}


