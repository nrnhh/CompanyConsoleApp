using Business.Services;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Ultities;

namespace CompanyConsoleApp.Controllers
{
    public  class WorkerController
    {
       
            public WorkerService workerService { get; set; }
        public WorkerController()
        {
            workerService = new WorkerService();    
        }

        public void Create()
        {
            Helper.ShowDisplay(ConsoleColor.DarkMagenta, "Enter Company Name");
            string companyName = Console.ReadLine();

            Helper.ShowDisplay(ConsoleColor.DarkCyan, "Enter Worker Name");
            string name = Console.ReadLine();

            Helper.ShowDisplay(ConsoleColor.DarkRed, "Enter Worker Surname");
            string surName = Console.ReadLine();
            Worker worker = new Worker()
            {

                Name = name,
                Surname = surName


            };
            if (workerService.Create(worker , companyName)!=null)
            {
                Helper.ShowDisplay(ConsoleColor.Green, $"{worker.Name} Worker made");
            }
            else
            {
                Helper.ShowDisplay(ConsoleColor.Yellow, "something went wrong ");
            }


        }
        public void GetAll()
        {
            Helper.ShowDisplay(ConsoleColor.DarkMagenta, "List of Workers");
            List<Worker> workers = workerService.GetAll();
            foreach (var item in workers)
            {
                Helper.ShowDisplay(ConsoleColor.DarkRed, $"{item.Id} {item.Name} {item.Surname} {item.Company.Name}");
            }
        }
        public void GetAllWorkersWithCompanyName()
        {

            Helper.ShowDisplay(ConsoleColor.DarkMagenta, "Enter Company Name ");
            string companyName = Console.ReadLine();

          List<Worker> workers=  workerService.Get(companyName);
            foreach (var item in workers)
            {
                Helper.ShowDisplay(ConsoleColor.DarkRed, $"{item.Id} {item.Name} {item.Surname} {item.Company.Name}");
            }
        }
        public void Delete()
        {
            Helper.ShowDisplay(ConsoleColor.DarkRed, "Enter Id For Deleting Worker");
            int id = int.Parse(Console.ReadLine());
            workerService.Delete(id);
            if (workerService.Delete(id) != null)
            {
                Helper.ShowDisplay(ConsoleColor.DarkMagenta, "Deleted");
            }
            else
            {
                Helper.ShowDisplay(ConsoleColor.DarkCyan, "Something Went Wrong");
            }
        }
        public void GetAllWorkersWithSameName()
        {
            Helper.ShowDisplay(ConsoleColor.DarkMagenta, "Enter Worker Name ");
            string workerName = Console.ReadLine();

           
            foreach (var item in workerService.GetAll(workerName))
            {
                Helper.ShowDisplay(ConsoleColor.DarkRed, $"{item.Id} {item.Name} {item.Surname} {item.Company.Name}");
            }
        }
        public void UpdateWorkerName()
        {
           
            Helper.ShowDisplay(ConsoleColor.DarkGreen, "Enter Worker  Name");
            string workerName = Console.ReadLine();
            Helper.ShowDisplay(ConsoleColor.DarkGreen, "Enter Worker New  Name");
            string workerNewName = Console.ReadLine();



            Worker worker = new Worker
            {
                Name = workerNewName
                
            };
            if (workerService.Update( worker , workerName) != null)
            {
                
                Helper.ShowDisplay(ConsoleColor.DarkRed, $"{worker.Name} Worker Updated");
            }
            else
            {
                Helper.ShowDisplay(ConsoleColor.DarkYellow, "Something went wrong ");
            }
        }
        public void GetWithId()
        {
            GetAll();
            Helper.ShowDisplay(ConsoleColor.DarkRed, "Enter Worker Id U Looking For");
            int id = int.Parse(Console.ReadLine());
            Worker worker = workerService.Get(id);
            Console.WriteLine($"{worker.Id}  {worker.Name} found ");
        }
        public void GetWithSurname()
        {
            GetAll();
            Helper.ShowDisplay(ConsoleColor.DarkRed, "Enter Worker Surname U Looking For");
            string surname = Console.ReadLine();
            Worker worker = workerService.GetSurname(surname);
            Console.WriteLine($"  {worker.Name} found ");

        }
        public void UpdateWorkerSurname()
        {

            Helper.ShowDisplay(ConsoleColor.DarkGreen, "Enter Worker  Surname");
            string workerSurname = Console.ReadLine();
            Helper.ShowDisplay(ConsoleColor.DarkGreen, "Enter Worker New  Surname");
            string workerNewSurname = Console.ReadLine();



            Worker worker = new Worker
            {
                Surname = workerNewSurname

            };
            if (workerService.Update(worker, workerNewSurname) != null)
            {

                Helper.ShowDisplay(ConsoleColor.DarkRed, $"{worker.Surname} Worker Updated");
            }
            else
            {
                Helper.ShowDisplay(ConsoleColor.DarkYellow, "Something went wrong ");
            }
        }


    }
}
