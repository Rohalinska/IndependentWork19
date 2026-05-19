using System;
using IndependentWork19.Interfaces;

namespace IndependentWork19.Models
{
    public class DynamicRouter : IRouter
    {
        public void Route(string destination)
        {
            Console.WriteLine($"[DYNAMIC] Динамічна маршрутизація до: {destination}");
        }
    }
}