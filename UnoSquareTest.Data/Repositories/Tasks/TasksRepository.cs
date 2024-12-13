using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using UnoSquareTest.DTOs.Tasks;
using UnoSquareTest.Models.Entities;

namespace UnoSquareTest.Data.Repositories.Tasks
{
    public class TasksRepository(AppDbContext dbContext) : ITasksRepository
    {
        public async Task<TaskUS> AddTask(TaskUS request)
        {
            EntityEntry<TaskUS> task = dbContext.Tasks.Add(request);
            await dbContext.SaveChangesAsync();
            return task.Entity;
        }

        public async Task<List<TaskUS>> GetTasks()
        {

            return await dbContext.Tasks.ToListAsync();
        }

        public async Task<TaskUS> UpdateTask(int id, TaskUS taskUS)
        {
            TaskUS existingTask = await dbContext.Tasks.FindAsync(id);
            if (existingTask == null) return null;
            
            taskUS.Id = existingTask.Id;
            dbContext.Entry(existingTask).CurrentValues.SetValues(taskUS);
            await dbContext.SaveChangesAsync();
            return existingTask;
        }

        public async Task<bool> DeleteTask(int id)
        {
            TaskUS existingTask = await dbContext.Tasks.FindAsync(id);
            if (existingTask == null) return false;

            dbContext.Tasks.Remove(existingTask);
            await dbContext.SaveChangesAsync();
            return true;
        }
    }
}
