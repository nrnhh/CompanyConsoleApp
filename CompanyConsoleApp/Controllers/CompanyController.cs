﻿using Business.Services;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Ultities;

namespace CompanyConsoleApp.Controllers
{
    public  class CompanyController
    {
        public CompanyService companyService { get; set; }
        public CompanyController()
        {
            companyService = new CompanyService();
        }
        public void Create()
        {

            
       
        Helper.ShowDisplay(ConsoleColor.DarkRed, "Enter Company Name");
            string name = Console.ReadLine();
            Helper.ShowDisplay(ConsoleColor.DarkRed, "Enter Company Size");
        TextAgain: string CompanySize = Console.ReadLine();
            int size;
            bool isSize = Int32.TryParse(CompanySize, out size);
            if (isSize)
            {
                Company newCompany = new Company();
                newCompany.Name = name;
                newCompany.MaxSize = size;
                if (companyService.Create(newCompany) != null)
                {
                    Helper.ShowDisplay(ConsoleColor.DarkBlue, $"{newCompany.Name} Company Created");
                }
                else
                {
                    Helper.ShowDisplay(ConsoleColor.Cyan, "Something Went Wrong Try  again ");
                }
            }
            else
            {
                Helper.ShowDisplay(ConsoleColor.DarkBlue, "Enter Size Correctly");
                goto TextAgain;
            }



        }
        public void GetAll()
        {

            List<Company> companies = companyService.GetAll();
            foreach (var item in companies)
            {
                Helper.ShowDisplay(ConsoleColor.DarkMagenta, $" Id ; {item.Id}  Name ;{item.Name}");
                Console.WriteLine($" {item.Id} {item.Name}");
            }
            
        }
        public void Remove()
        {
            Helper.ShowDisplay(ConsoleColor.DarkRed, "Enter Id for Deleting Company");
            int id = int.Parse(Console.ReadLine());
            companyService.Delete(id);
            if (companyService.Delete(id)!=null)
            {
                Helper.ShowDisplay(ConsoleColor.DarkMagenta, "Deleted");
            }
            else
            {
                Helper.ShowDisplay(ConsoleColor.DarkCyan, "Something Went Wrong");
            }
        }
        public void Update()
        {
            Helper.ShowDisplay(ConsoleColor.DarkMagenta, "Enter Id for Changing id for Company");
            int id = int.Parse(Console.ReadLine());
            Helper.ShowDisplay(ConsoleColor.DarkGreen, "Enter Company Name");
            string name = Console.ReadLine();
            Helper.ShowDisplay(ConsoleColor.DarkMagenta , "Enter Company Size");
            int size = int.Parse(Console.ReadLine());
            Company company = new Company
            {
                Name = name,
                MaxSize = size,
            };
            if (companyService.Update(id, company)!=null)
            {
                Helper.ShowDisplay(ConsoleColor.DarkRed, "Company Updated");
            }
            else
            {
                Helper.ShowDisplay(ConsoleColor.DarkYellow, "Something went wrong ");
            }


        }
    }
}