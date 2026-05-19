using IndependentWork19.Interfaces;
using IndependentWork19.Models;

namespace IndependentWork19.Factories
{
    public class ApiRouterFactory : RouterFactory
    {
        protected override IRouter CreateRouter() => new ApiRouter();
    }
}