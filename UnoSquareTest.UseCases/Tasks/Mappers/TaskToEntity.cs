using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnoSquareTest.DTOs.Tasks;
using UnoSquareTest.Models.Entities;

namespace UnoSquareTest.UseCases.Tasks.Mappers
{
    public static class TaskToEntity
    {
        public static TaskUS ToDoEntity(this AddTaskRequestDto request)
       => new()
       {
           Name = request.Name,
           Description = request.Description,
           Complete = request.Complete,
           DueDate = request.DueDate
       };
    }
}
