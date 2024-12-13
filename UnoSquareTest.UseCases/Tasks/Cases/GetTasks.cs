using UnoSquareTest.Data.Repositories.Tasks;
using UnoSquareTest.DTOs.Tasks;
using UnoSquareTest.Models.Entities;
using UnoSquareTest.UseCases.Tasks.Mappers;

namespace UnoSquareTest.UseCases.Tasks.Cases
{
    public class GetTasks(ITasksRepository tasksRepository)
    {
        public async Task<List<TaskResponseDto>> Execute()
        {
            List<TaskUS> taskUS = await tasksRepository.GetTasks();

            List<TaskResponseDto> taskResponseDto = taskUS.Select(taskUS => taskUS.ToDo()).ToList();

            return taskResponseDto;
        }
    }
}
