﻿using System;
using Lab4Singleton.Factory;
using Lab4Singleton.Logger;

namespace Lab4Singleton
{
    internal class Program
    // Синглтон или Одиночка — это порождающий паттерн проектирования, который гарантирует, 
    // что у класса есть только один экземпляр, и предоставляет к нему глобальную точку доступа.
    {
        private static void Main(string[] args)
        {
            var lg = Log.GetLog;
            lg.ExecuteLog("Method Main()");

            Operation.Run('-', 35);
            Operation.Run('+', 30);

            CarFactory audiFactory = AudiFactory.GetAudiFactory;
            var client = new Client(audiFactory);
            Console.WriteLine("Max speed {0} is {1} km/hour",
                client, client.GetMaxSpeed());
        }
    }
}