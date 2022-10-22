using Business.Services;
using CompanyConsoleApp.Controllers;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Ultities;

namespace CompanyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompanyService companyService = new CompanyService();
            CompanyController companyController = new CompanyController();
            WorkerController workerController = new WorkerController();
            Helper.ShowDisplay(ConsoleColor.Magenta,"1-Create Company ;" + "2-Update Company ;"
                +"3-Delete Company ;" +"4-GetCompanyById ;" 
                +"5-GetCompanyName ;"+ "6-GetAll ;" + "7- CreateWorker ; " + "8-GetAllWorkers ;" 
                +"9-GetAllWorkersWithCompanyName ;" +"10-DeleteWorker ;" + "11-GetAllWorkersWithSameName ; "
                + "12-UpdateWorker ; " + "13-GetWorkerById  :"
            );


            while (true)
            {
                string selectMenu = Console.ReadLine();
                int menu;
                bool isChange = Int32.TryParse(selectMenu, out menu);
                if (isChange && menu >= 1 && menu <= 13)
                {
                    switch (menu)
                    {
                        case (int)Helper.Methods.CreateCompany:
                            companyController.Create();
                            break;
                        case (int)Helper.Methods.UpdateCompany:
                            companyController.Update();
                            break;
                        case (int)Helper.Methods.DeleteCompany:
                            companyController.Remove();
                            break;
                        case (int)Helper.Methods.GetCompanyById:
                            companyController.GetWithId();
                            break;
                        case (int)Helper.Methods.GetCompanyByName:
                            companyController.GetWithName();
                            break;

                        case (int)Helper.Methods.GetAllCompany:

                            companyController.GetAll();
                            break;
                        case (int)Helper.Methods.CreateWorker:

                            workerController.Create();
                            break;

                        case (int)Helper.Methods.GetAllWorkers:

                            workerController.GetAll();
                            break;
                        case (int)Helper.Methods.GetAllWorkersWithCompanyName:

                            workerController.GetAllWorkersWithCompanyName();
                            break;
                        case (int)Helper.Methods.DeleteWorker:

                            workerController.Delete();
                            break;
                        case (int)Helper.Methods.GetAllWorkersWithSameName:

                            workerController.GetAllWorkersWithSameName();
                            break;
                        case (int)Helper.Methods.UpdateWorker:

                            workerController.UpdateWorker();
                            break;
                        case (int)Helper.Methods.GetWorkerById:

                            workerController.GetWithId();
                            break;









                        default:
                            break;
                    }


                }
                else if (menu==0 && isChange)
                {
                    Helper.ShowDisplay(ConsoleColor.DarkBlue, "bye bye");
                }
                else
                {
                    Helper.ShowDisplay(ConsoleColor.DarkBlue, "Enter Correctly");
                }
            }
               
            }
        }
    }

