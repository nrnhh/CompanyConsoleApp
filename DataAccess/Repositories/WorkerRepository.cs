using DataAccess.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace DataAccess.Repositories
{
    public class WorkerRepository : IRepository<Worker>
    {
        public bool Add(Worker entity)
        {
            try
            {
                DbContext.workers.Add(entity);
                return true;
            }
            catch (Exception)
            {

                return false;
            } 
        }

        public Worker Get(Predicate<Worker> filter = null)
        {
            return filter == null ? DbContext.workers.FirstOrDefault() : DbContext.workers.Find(filter);
        }

        public List<Worker> GetAll(Predicate<Worker> filter = null)
        {
            return filter== null ? DbContext.workers.ToList() : DbContext.workers.FindAll(filter); 
            
               
            
        }

        public bool Remove(Worker entity)
        {
            try
            {
                DbContext.workers.Remove(entity);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Update(int id, Worker newEntity)
        {
            
            Worker worker = Get(x => x.Id == id);

            if (worker!=null)
            {
                worker.Name = newEntity.Name;
                worker.Surname = newEntity.Surname;
                
                return true;
                
            }
            return false;
        }

        public bool Update(Worker Entity)
        {
            throw new NotImplementedException();
        }
    }
}

