using System;
using System.Collections.Generic;
using System.Text;

namespace Ultities
{
    public class Helper
    {

        public static void ShowDisplay(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public enum Methods
        {
            CreateCompany = 1,
            UpdateCompany,
            DeleteCompany,
            GetCompanyById,
            GetCompanyByName,
            GetAllCompany,
            CreateWorker,
            GetAllWorkers,
            GetAllWorkersWithCompanyName,
            DeleteWorker,
            GetAllWorkersWithSameName,
            
            GetWorkerById,
            GetSurname,
            UpdateWorkerSurname


        }
    }
}
