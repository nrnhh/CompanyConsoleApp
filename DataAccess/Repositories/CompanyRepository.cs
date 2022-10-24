using DataAccess.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Repositories
{
    public class CompanyRepository : IRepository<Company>
    {
        public bool Add(Company entity)
        {
            try
            {
                DbContext.companies.Add(entity);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Company Get(Predicate<Company> filter = null)
        {
            return filter == null ? DbContext.companies[0] :
                DbContext.companies.Find(filter);
        }

        public List<Company> GetAll(Predicate<Company> filter = null)
        {
            return filter == null ? DbContext.companies.ToList() : 
                DbContext.companies.FindAll(filter);



        }

        public bool Remove(Company entity)
        {
            try
            {
                DbContext.companies.Remove(entity);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Update(int id , Company newCompany)
        {
            Company company1 = new Company();
            if (Get(n=>n.Id==id)!=null)
            {

                company1 = Get(n => n.Id == id);
                company1= new Company();
                company1.Id = id;
                return true;

            }
            return false;
            
        }
    }
}
