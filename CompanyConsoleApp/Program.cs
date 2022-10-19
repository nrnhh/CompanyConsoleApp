using Business.Services;
using Entities.Models;
using System;
using Ultities;

namespace CompanyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompanyService companyService = new CompanyService();
            Console.WriteLine("1-Create Company ;" + "2-Update Company ;"
                +"3-Delete Company ;" +"4-GetCompanyById ;" 
                +"5-GetCompanyName ;"+ "6-GetAll ;");


            while (true)
            {
               string selectMenu = Console.ReadLine();
                int menu;
                bool isChange=Int32.TryParse(selectMenu, out menu);
                if (isChange && menu >= 1 && menu <= 6)
                {
                    switch (menu)
                    {

                        case 1:
                            Helper.ShowDisplay(ConsoleColor.Cyan, "Enter Company Name ");
                            string name = Console.ReadLine();
                            Helper.ShowDisplay(ConsoleColor.DarkMagenta, "Enter Company Size ");
                          WriteAgain:  string groupSize=Console.ReadLine();    
                            int size;
                            bool isSize=int.TryParse(name, out size);
                            if (isSize)
                            {
                                Company newCompany = new Company();
                                newCompany.Name = name; 
                                newCompany.MaxSize=size;
                                if (companyService.Create(newCompany)!=null)
                                {
                                    Helper.ShowDisplay(ConsoleColor.DarkYellow, $"{newCompany.Name} Company created");
                                }
                                else
                                {
                                    Helper.ShowDisplay(ConsoleColor.Green, "something went wrong ");
                                }
                                
                               
                            }
                            else
                            {
                                Helper.ShowDisplay(ConsoleColor.DarkRed, "Enter Size correctly");
                                goto WriteAgain;
                            }

                            break;

                        default:
                            break;
                    }
                }
                else if (menu ==0 && isChange)
                {
                    Helper.ShowDisplay(ConsoleColor.DarkRed, "Bye Bye  ");
                    break;
                }
                else
                {
                    Helper.ShowDisplay(ConsoleColor.DarkGreen, "Enter correctly");
                }
            }
               
            }
        }
    }

