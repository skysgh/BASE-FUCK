
using Microsoft.Extensions.Logging;

namespace App.Host.Web.Services.Implementations
{
    /// <summary>
    /// Implementation of the <see cref="IFooService"/>.
    /// </summary>
    public class FooService : IFooService
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="logger"></param>
        public FooService(ILogger<FooService> logger)
        {
            logger.LogInformation("all works nicely.");
        }
        
        /// <summary>
        /// Demo operation.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string SayHello(string name)
        {
            return $"Hello {name}.";
        }
    }
}
