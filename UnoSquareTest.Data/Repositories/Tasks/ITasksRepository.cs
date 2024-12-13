
using UnoSquareTest.DTOs.Tasks;
using UnoSquareTest.Models.Entities;

namespace UnoSquareTest.Data.Repositories.Tasks
{
    public interface ITasksRepository
    {
        public Task<TaskUS> AddTask(TaskUS request);
        public Task<List<TaskUS>> GetTasks();
        public Task<TaskUS> UpdateTask(int id, TaskUS taskUS);
        public Task<bool> DeleteTask(int id);
    }
}
