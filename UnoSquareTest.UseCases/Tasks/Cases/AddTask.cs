
using UnoSquareTest.Data.Repositories.Tasks;
using UnoSquareTest.DTOs.Tasks;
using UnoSquareTest.Models.Entities;
using UnoSquareTest.UseCases.Tasks.Mappers;

namespace UnoSquareTest.UseCases.Tasks.Cases
{
    public class AddTask(ITasksRepository tasksRepository)
    {
        public async Task<TaskResponseDto> Execute(AddTaskRequestDto request)
        {
            TaskUS entity = request.ToDoEntity();
            TaskUS taskUS = await tasksRepository.AddTask(entity);
            TaskResponseDto taskResponseDto = taskUS.ToDo();
            return taskResponseDto;
        }
    }
}
