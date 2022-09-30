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
        private int id;
       public int Id
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
     public string Name { get; set; }

    }
}
