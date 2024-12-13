using Microsoft.Extensions.DependencyInjection;
using UnoSquareTest.UseCases.Tasks.Cases;

namespace UnoSquareTest.UseCases
{
    public static class UseCasesDependencyInjection
    {

        public static IServiceCollection AddUseCases(this IServiceCollection services)
                => services.AddTasksUseCases();

        private static IServiceCollection AddTasksUseCases(this IServiceCollection services)
            => services.AddScoped<TasksUseCases>()
            .AddScoped<AddTask>()
            .AddScoped<GetTasks>()
            .AddScoped<DeleteTask>()
            .AddScoped<UpdateTask>();
    }
}
