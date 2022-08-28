namespace App.Host.Web.Services
{
    public interface IFooService
    {
        /// <summary>
        /// Demo operation.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        string SayHello(string name);
    }
}
