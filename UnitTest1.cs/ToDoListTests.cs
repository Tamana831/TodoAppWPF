using TodoAppWPF;
using Xunit;

namespace TestingToDoList
{
    public class ToDoListTests
    {
        private TodoList _todoList;

        public ToDoListTests()
        {
            _todoList = new TodoList();
        }

        [Fact]
        public void AddTask_ShouldAddTaskToList()
        {
            // Arrange
            var task = "Test task";

            // Act
            _todoList.AddTask(task);
            var tasks = _todoList.GetAllTasks();

            // Assert
            Assert.Contains(task, tasks);
        }

        [Fact]
        public void RemoveTask_ShouldRemoveTaskFromList()
        {
            // Arrange
            var task = "Task to remove";

            // Act
            _todoList.AddTask(task);
            _todoList.RemoveTask(0);
            var tasks = _todoList.GetAllTasks();

            // Assert
            Assert.DoesNotContain(task, tasks);
        }

        [Fact]
        public void RemoveTask_InvalidIndex_ShouldNotThrowException()
        {
            // Arrange
            var task = "Valid Task";

            // Act
            _todoList.AddTask(task);
            _todoList.RemoveTask(10); // Försök ta bort med ett ogiltigt index
            var tasks = _todoList.GetAllTasks();

            // Assert
            Assert.Single(tasks); // Kontrollera att en uppgift fortfarande finns kvar
        }
    }
}

