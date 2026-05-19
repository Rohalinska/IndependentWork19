using System;
using IndependentWork19.Factories;
using IndependentWork19.Services;

namespace IndependentWork19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine(" Самостійна робота №19 | Варіант 14 ");

            // 1. Отримання єдиного екземпляра сервісу (Singleton)
            RoutingService routingService = RoutingService.Instance;

            // 2. Демонстрація StaticRouter
            routingService.SetRouterFactory(new StaticRouterFactory());
            routingService.Route("/assets/images/logo.png");
            routingService.Route("/about-us.html");

            // 3. Демонстрація DynamicRouter
            routingService.SetRouterFactory(new DynamicRouterFactory());
            routingService.Route("/catalog/products/item-4521");
            routingService.Route("/profile/settings");

            // 4. Демонстрація ApiRouter
            routingService.SetRouterFactory(new ApiRouterFactory());
            routingService.Route("/api/v1/users/create");
            routingService.Route("/api/v2/orders/summary");

            Console.WriteLine("Роботу завершено успішно.");
            Console.ReadKey();
        }
    }
}