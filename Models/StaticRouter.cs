using System;
using IndependentWork19.Interfaces;

namespace IndependentWork19.Models
{
    public class StaticRouter : IRouter
    {
        public void Route(string destination)
        {
            Console.WriteLine($"[STATIC] Маршрутизація до статичного ресурсу: {destination}");
        }
    }
}