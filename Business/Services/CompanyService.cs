using Business.Interfaces;
using DataAccess.Repositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Services
{
    public class CompanyService : ICompany
    {

        public CompanyRepository companyRepository { get; set; }
        public static  int Count { get; set; }
        public CompanyService()
        {
            companyRepository = new CompanyRepository();    
        }
       
        public Company Create(Company company)
        {
            try
            {

                Company existCompany = companyRepository.Get(c => c.Name.ToLower() == company.Name.ToLower());
                if (existCompany!=null)
                {
                    return null;
                }
                company.Id=Count; 
                companyRepository.Add(company);
                Count++;
                return company; 
            }
            catch (Exception)
            {

                return null;
            }
        }

        public Company Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Company Get(int id)
        {
            throw new NotImplementedException();
        }

        public Company Get(string name)
        {
            throw new NotImplementedException();
        }

        public List<Company> GetAll()
        {
            throw new NotImplementedException();
        }

        public Company Update(int id, Company company)
        {
            throw new NotImplementedException();
        }
    }
}
