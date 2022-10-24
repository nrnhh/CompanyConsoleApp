using Business.Interfaces;
using DataAccess.Repositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

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
            try
            {
                Company company = companyRepository.Get(c =>c.Id==id);
                if (company != null)
                {
                    return company;
                }
                return null;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public Company Get(string name)
        {
            try
            {
                Company company = companyRepository.Get(c => c.Name.ToLower() == name.ToLower());
                if (company!=null)
                {
                    return company;
                }
                return null;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public List<Company> GetAll()
        {
            return companyRepository.GetAll();
        }

        public Company Update(int id, Company company)
        {
            try
            {
                Company existCompany = companyRepository.Get(g => g.Id == id);


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
