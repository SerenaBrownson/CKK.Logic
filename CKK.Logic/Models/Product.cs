using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class Product
    {
        //instance variables
        private int id;
        private string name;
        private decimal price;

        //Methods for Id
        public int GetId()
        {
            return id;
        }
        public void SetId(int argID)
        {
            id = argID;
        }

        //Methods for Name
        public string GetName()
        {
            return name;
        }
        public void SetName(string argName)
        {
            name = argName;
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

    }
   

}
