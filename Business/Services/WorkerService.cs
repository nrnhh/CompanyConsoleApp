using Business.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Services
{
    public class WorkerService : IWorker
    {
        public Worker Create(Worker worker, string groupName)
        {
            throw new NotImplementedException();
        }

        public Worker Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Worker Get(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Worker> Get(string companyName)
        {
            throw new NotImplementedException();
        }

        public List<Worker> GetAll(string name)
        {
            throw new NotImplementedException();
        }

        public List<Worker> GetAll()
        {
            throw new NotImplementedException();
        }

        public Worker Update(Worker worker, string groupName)
        {
            throw new NotImplementedException();
        }
    }
}
