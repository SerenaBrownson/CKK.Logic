using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Interfaces;
using CKK.Logic.Exceptions;

namespace CKK.Logic.Models
{
    public class Product : Entity
    {
        //instance variables
        
        
        private decimal price;

        //Methods for Id
        public int GetId()
        {
            return Id;
        }
        public void SetId(int argID)
        {
            Id = argID;
        }

        //Methods for Name
        public string GetName()
        {
            return Name;
        }
        public void SetName(string argName)
        {
            Name = argName;
        }

        //Methods for Price
        public decimal GetPrice()
        {
            return price;
        }
        public void SetPrice(decimal argPrice)
        {
            price = argPrice;
        }

        public decimal Price
        {
            get { return price; }
            set{ if (value < 0)
                { throw new ArgumentOutOfRangeException(); }
                else price = value;
            }
        }
        

    }
   

}
