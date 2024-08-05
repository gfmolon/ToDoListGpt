using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ToDoApp.Services;
using ToDoAppGpt;

namespace ToDoAppGpt
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddSingleton<TodoService>();

            await builder.Build().RunAsync();
        }
    }
}
