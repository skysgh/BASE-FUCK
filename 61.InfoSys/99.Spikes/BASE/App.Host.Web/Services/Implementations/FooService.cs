
namespace App.Host.Web.Services.Implementations
{
    public class FooService : IFooService
    {
        public FooService(ILogger<FooService> logger)
        {
            logger.LogInformation("all works nicely.");
        }
        public string SayHello(string name)
        {
            return $"Hello {name}.";
        }
    }
}
