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
    public class WorkerService : IWorker
    {
        public CompanyService companyService { get; set; }
        public WorkerRepository workerRepository { get; set; }
        public static int Count { get; set; }
        public WorkerService()
        {
            companyService = new CompanyService();  
            workerRepository = new WorkerRepository();  
        }
        public Worker Create(Worker worker, string companyName)
        {
           Company company = companyService.Get(companyName);
            if (company!=null)
            {
                worker.Id = Count;
                worker.Company = company;   
                workerRepository.Add(worker);
                Count++;
                return worker;
            }
           
            
                return null;
            
        }

        public Worker Delete(int Id)
        {
            Worker existWorker = workerRepository.Get(w => w.Id == Id);
            if (existWorker != null)
            {
                workerRepository.Remove(existWorker);
                return existWorker;
            }
            else
            {
                return null;
            }
        }

        public Worker Get(int id)
        {
            try
            {
                Worker worker = workerRepository.Get(w => w.Id == id);
                if (worker != null)
                {
                    return worker;
                }
                return null;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public List<Worker> Get(string companyName)
        {
            try
            {
                Company company = companyService.Get(companyName);
                if (company!=null)
                {
                    List<Worker> workers = workerRepository.GetAll(w=>w.Company.Name.ToLower()==company.Name.ToLower());
                    return workers;
                }
                return null;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public List<Worker> GetAll(string name)
        {
            return workerRepository.GetAll(w => w.Name.ToLower() == name.ToLower());
        }

        public List<Worker> GetAll()
        {
          return workerRepository.GetAll(); 
        }

       
        public Worker GetSurname(string surname )
        {

            try
            {
                Worker worker = workerRepository.Get(w => w.Name == surname);
                if (worker != null)
                {
                    return worker;
                }
                return null;
            }
            catch (Exception)
            {

                return null;
            }
        }
       

        

        public bool UpdateWorker(int id, Worker newWorker)
        {
            workerRepository.Update(id, newWorker);
            if (workerRepository.Update(id, newWorker)==true)
            {
                return true; 
            }
            return false;
        }
    }
}
