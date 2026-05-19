using System;
using IndependentWork19.Interfaces;

namespace IndependentWork19.Models
{
    public class ApiRouter : IRouter
    {
        public void Route(string destination)
        {
            Console.WriteLine($"[API] Перенаправлення API-запиту до кінцевої точки: {destination}");
        }
    }
}