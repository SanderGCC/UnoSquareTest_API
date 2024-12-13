using UnoSquareTest.Data.Repositories.Tasks;

namespace UnoSquareTest.UseCases.Tasks.Cases
{
    public class DeleteTask(ITasksRepository tasksRepository)
    {
        public async Task<bool> Execute(int id)
        {
            return await tasksRepository.DeleteTask(id);
        }
    }
}
