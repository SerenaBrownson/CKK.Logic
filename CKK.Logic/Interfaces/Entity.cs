using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Models;
using CKK.Logic.Exceptions;


namespace CKK.Logic.Interfaces
{
   public abstract class Entity
    {
        public int id
        {
            get { return id; }
            set
            { 
                if (value < 0)
                {
                   throw new InvalidIdException("Error Invalid Id Exception");
                }
                else { id = value; }
                
            }
        }
        public string name { get; set; }

    }
}
