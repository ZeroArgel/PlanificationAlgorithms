namespace FCFS.Console
{
    using Core;
    using System;
    internal static class Program
    {
        internal static void Main()
        {
            var methods = new Methods(4);
            methods.Menu();
            methods.GetFcFsResult();
            
            Console.WriteLine("\nFifo");
            methods.Results();

            methods.GetSjfResult();

            Console.WriteLine("\nSjf");
            methods.Results();
        }
    }
}