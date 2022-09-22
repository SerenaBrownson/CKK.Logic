using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Interfaces;


namespace CKK.Logic.Models
{
    public class Customer : Entity
    {
        //private instance variables
        
        
        private string address;
     
        //Methods for Id
        public int GetId()
        {
            return base.id;
        }
        public void SetId(int argId)
        {
            id=argId;
        }
        //Methods for Name;
        public string GetName()
        {
            return name;
        }
        public void SetName(string argName)
        {
            name=argName;
        }
        //Methods for Address
        public string GetAddress()
        {
            return address;
        }
        public void SetAddress(string argAddress)
        {
            address=argAddress;
        }
        

        



    }
}
