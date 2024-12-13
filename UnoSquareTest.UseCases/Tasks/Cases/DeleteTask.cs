using UnoSquareTest.Data.Repositories.Tasks;

namespace UnoSquareTest.UseCases.Tasks.Cases
{
    public class DeleteTask(ITasksRepository tasksRepository)
    {
        public bool Execute(int id)
        {
            return tasksRepository.DeleteTask(id).GetAwaiter().GetResult();
        }
    }
}
