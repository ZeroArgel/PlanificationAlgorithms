namespace Core
{
    using Enums;
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using ZAExtensions.zCore;

    public class Methods
    {
        public IEnumerable<Process> Processes { get; internal set; }
        public int NumbersProcess { get; }

        public Methods(int numbersProcess)
        {
            Processes = new List<Process>();
            NumbersProcess = numbersProcess;
        }

        public Methods(IEnumerable<Process> processes)
        {
            Processes = processes;
            NumbersProcess = processes.Count();
        }

        #region for console
        /// <summary>
        /// Function to show menu in console.
        /// </summary>
        public void Menu()
        {
            var id = 'A';
            while (true)
            {
                try
                {
                    Console.WriteLine("Algoritmos de planificacion");
                    Console.WriteLine();
                    Console.WriteLine("1 - FIFO");
                    Console.WriteLine("2 - SJF");
                    Console.WriteLine("3 - SRTF");
                    Console.WriteLine("4 - Round Robin (RR)");
                    Console.WriteLine("5 - Priority no expropiativa");

                    switch ((Algorithms)Console.ReadLine().ToInt())
                    {
                        case Algorithms.FcFs:
                        case Algorithms.Sjf:
                            for (var i = 0; i < NumbersProcess; i++)
                            {
                                Console.Write("Ingrese los datos de {0}: \t", id);
                                var data = Console.ReadLine().ToInt();
                                Processes.ToList().Add(new Process(i, id.ToString(), data));
                                id++;
                            }
                            return;
                        case Algorithms.Srt:
                            return;
                        default:
                            Console.WriteLine("Selecciona una opcion valida");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Selecciona una opcion valida");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }

        public void Results()
        {
            foreach (var process in Processes)
            {
                Console.WriteLine("Tiempo de retorno de {0}: {1}", process.Id, process.ReturnValue);
            }
        }
        #endregion
        #region GetFcFsResult
        public void GetFcFsResult()
        {
            var accumulated = 0.0;
            Processes = Processes.OrderBy(x => x.Order);
            foreach (var process in Processes)
            {
                accumulated += process.Value;
                process.SetReturnValue(accumulated);
            }
        }
        #endregion
        #region GetSjfResult
        public void GetSjfResult()
        {
            Processes = Processes.OrderBy(x => x.Value);
            var accumulated = 0.0;
            foreach (var process in Processes)
            {
                accumulated += process.Value;
                process.SetReturnValue(accumulated);
            }

            Processes = Processes.OrderBy(x => x.ReturnValue);
        }
        #endregion
        public void GetSrTfResult()
        {
            foreach (var process in Processes)
            {
                
            }
        }
    }
}