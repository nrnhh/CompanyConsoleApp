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
        public static int Count { get; set; }
        public CompanyService()
        {
            companyRepository = new CompanyRepository();
        }

        public Company Create(Company company)
        {
            try
            {

                Company existCompany = companyRepository.Get(c => c.Name.ToLower() == company.Name.ToLower());
                if (existCompany != null)
                {
                    return null;
                }
                company.Id = Count;
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
            try
            {
                Company existCompany = companyRepository.Get(c => c.Id == id);
                if (existCompany != null)
                {
                    companyRepository.Remove(existCompany);
                    return existCompany;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {

                return null;
            }
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
            return companyRepository.GetAll();
        }

        public Company Update(int id, Company company)
        {
            try
            {
                Company existCompany = companyRepository.Get(c => c.Id == id);

               
                if (existCompany != null)
                {
                    existCompany.Name = company.Name;
                    existCompany.MaxSize = company.MaxSize;

                    return existCompany;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
