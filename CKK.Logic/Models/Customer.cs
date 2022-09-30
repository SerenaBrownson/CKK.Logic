﻿using System;
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
            return Id;
        }
        public void SetId(int argId)
        {
            Id = argId;
        }
        //Methods for Name;
        public string GetName()
        {
            return Name;
        }
        public void SetName(string argName)
        {
            Name = argName;
        }
        
        public string Address
        {
            get;set;
        }
        

        



    }
}
