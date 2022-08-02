using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class Customer
    {
        //private instance variables
        private int id;
        private string name;
        private string address;
     
        //Methods for Id
        public int GetId()
        {
            return id;
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
