using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    public interface IWorker
    {

        Worker Create(Worker worker, string companyName);
       bool  UpdateWorker(int id ,  Worker newWorker);
        Worker Delete(int Id);
        Worker Get(int Id);
        List<Worker> Get(string companyName);
        List<Worker> GetAll(string name);
        List<Worker> GetAll();
    }
}
