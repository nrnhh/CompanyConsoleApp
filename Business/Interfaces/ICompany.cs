using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    public interface ICompany
    {
        Company Create(Company company);    
        Company Delete(int id );    
        Company Update(int id , Company company);   
        List<Company> GetAll();
        Company Get(int id);    
        Company Get(string  name);

    }
}
