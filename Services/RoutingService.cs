using System;
using IndependentWork19.Factories;

namespace IndependentWork19.Services
{
    public class RoutingService
    {
        private static RoutingService? _instance;
        private static readonly object _lock = new object();
        
        private RouterFactory? _currentFactory;

        // Приватний конструктор для запобігання створенню об'єктів ззовні
        private RoutingService() { }

        // Потокобезпечна реалізація Singleton (Double-Check Locking)
        public static RoutingService Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new RoutingService();
                        }
                    }
                }
                return _instance;
            }
        }

        // Встановлення поточної фабрики
        public void SetRouterFactory(RouterFactory factory)
        {
            _currentFactory = factory;
            Console.WriteLine($"\\n---> Фабрику змінено на: {factory.GetType().Name} <---");
        }

        // Делегування виконання поточної фабриці
        public void Route(string destination)
        {
            if (_currentFactory == null)
            {
                Console.WriteLine("Помилка: Фабрику маршрутизації не встановлено!");
                return;
            }
            _currentFactory.ExecuteRouting(destination);
        }
    }
}