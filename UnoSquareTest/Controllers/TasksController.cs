using Microsoft.AspNetCore.Mvc;
using UnoSquareTest.DTOs.Tasks;
using UnoSquareTest.UseCases.Tasks.Cases;

namespace UnoSquareTest.Controllers
{
    [Route("api/tasks")]
    [ApiController]
    public class TasksController(TasksUseCases tasks) : ControllerBase
    {

        [HttpGet]
        public ActionResult<List<TaskResponseDto>> GetTasks()
        {
            List<TaskResponseDto> taskResponseDto = tasks.GetTasks.Execute();
            return Ok(taskResponseDto);
        }

        [HttpPut("{id}")]
        public ActionResult<TaskResponseDto> Post(int id, AddTaskRequestDto request)
        {
            TaskResponseDto taskResponseDto = tasks.UpdateTask.Execute(id, request);
            return Ok(taskResponseDto);
        }

        [HttpPost]
        public ActionResult<TaskResponseDto> Post(AddTaskRequestDto request)
        {
            TaskResponseDto taskResponseDto = tasks.AddTask.Execute(request);
            return Ok(taskResponseDto);
        }

        [HttpDelete("{id}")]
        public ActionResult<TaskResponseDto> Delete(int id)
        {
            bool response = tasks.DeleteTask.Execute(id);
            if (!response) return NotFound();
            return NoContent();
        }
    }
}
