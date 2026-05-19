using IndependentWork19.Interfaces;

namespace IndependentWork19.Factories
{
    public abstract class RouterFactory
    {
        // Фабричний метод
        protected abstract IRouter CreateRouter();

        // Конкретний метод, що використовує фабричний метод
        public void ExecuteRouting(string destination)
        {
            IRouter router = CreateRouter();
            router.Route(destination);
        }
    }
}