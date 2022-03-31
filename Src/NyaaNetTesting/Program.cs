using System;
using NyaaNet;

namespace NyaaNetTesting
{
    internal class Program
    {
        static async Task Main()
        {
            APIClient client = new("http://127.0.0.1:8080/","admin", "pass1234");
            Console.WriteLine(await client.HealthCheckAsync());
            Console.ReadLine();
        }
    }
}