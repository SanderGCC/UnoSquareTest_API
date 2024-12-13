using UnoSquareTest.Data.Repositories.Tasks;
using UnoSquareTest.DTOs.Tasks;
using UnoSquareTest.Models.Entities;
using UnoSquareTest.UseCases.Tasks.Mappers;

namespace UnoSquareTest.UseCases.Tasks.Cases
{
    public class UpdateTask(ITasksRepository tasksRepository)
    {
        public async Task<TaskResponseDto> Execute(int id, AddTaskRequestDto request)
        {
            TaskUS entity = request.ToDoEntity();
            TaskUS taskUS = await tasksRepository.UpdateTask(id, entity);
            TaskResponseDto taskResponseDto = taskUS.ToDo();
            return taskResponseDto;
        }
    }
}
