using App.Host.Web.Services;
using App.Host.Web.Services.Implementations;
using Lamar;

namespace App.Host.Web.Startup
{
    public class ModuleServiceRegistry: ServiceRegistry
    {
        public ModuleServiceRegistry()
        {

            For<IFooService>().Use<FooService>();
        }
    }
}
