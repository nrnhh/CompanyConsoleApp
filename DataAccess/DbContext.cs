using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DataAccess
{
    public  static class DbContext
    {
        public static List<Worker> workers;
        public static List<Company> companies;

        static DbContext()
        {
            workers = new List<Worker>();
            companies = new List<Company>();
        }
    }
}
