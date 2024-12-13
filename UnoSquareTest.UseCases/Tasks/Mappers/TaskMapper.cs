using UnoSquareTest.DTOs.Tasks;
using UnoSquareTest.Models.Entities;

namespace UnoSquareTest.UseCases.Tasks.Mappers
{
    public static class TaskMapper
    {

        public static TaskResponseDto ToDo(this TaskUS taskUS)
               => new()
               {
                   Id = taskUS.Id,
                   Name = taskUS.Name,
                   Description = taskUS.Description,
                   Complete = taskUS.Complete,
                   DueDate = taskUS.DueDate
               };
    }
}
