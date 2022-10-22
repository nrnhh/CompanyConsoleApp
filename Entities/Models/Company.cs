using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace Entities.Models
{
    public class Company : IEntity
    {
        public int Id { get ; set ; }
        public string Name { get; set; }
        public int MaxSize { get; set; }
   

    }
}
