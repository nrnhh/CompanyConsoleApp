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
            Console.WriteLine("1-Create Company ;" + "2-Update Company ;"
                +"3-Delete Company ;" +"4-GetCompanyById ;" 
                +"5-GetCompanyName ;"+ "6-GetAll ;");


            while (true)
            {
                string selectMenu = Console.ReadLine();
                int menu;
                bool isChange = Int32.TryParse(selectMenu, out menu);
                if (isChange && menu >= 1 && menu <= 6)
                {
                    switch (menu)
                    {
                        case (int)Helper.GroupMethods.CreateGroup:
                            companyController.Create();
                            break;
                        case (int)Helper.GroupMethods.UpdateGroup:
                            companyController.Update();
                            break;
                        case (int)Helper.GroupMethods.DeleteGroup:
                            companyController.Remove();
                            break;

                        case 6:

                            companyController.Create();
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

