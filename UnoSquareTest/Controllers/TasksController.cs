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
        public async Task<ActionResult<List<TaskResponseDto>>> GetTasks()
        {
            List<TaskResponseDto> taskResponseDto = await tasks.GetTasks.Execute();
            return Ok(taskResponseDto);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<TaskResponseDto>> Post(int id, AddTaskRequestDto request)
        {
            TaskResponseDto taskResponseDto = await tasks.UpdateTask.Execute(id, request);
            return Ok(taskResponseDto);
        }

        [HttpPost]
        public async Task<ActionResult<TaskResponseDto>> Post(AddTaskRequestDto request)
        {
            TaskResponseDto taskResponseDto = await tasks.AddTask.Execute(request);
            return Ok(taskResponseDto);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<TaskResponseDto>> Delete(int id)
        {
            bool response = await tasks.DeleteTask.Execute(id);
            if (!response) return NotFound();
            return NoContent();
        }
    }
}
