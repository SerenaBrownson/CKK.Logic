﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Models;


namespace CKK.Logic.Interfaces
{
   public abstract class Entity
    {
        public  int id { get; set; }
        public string name { get; set; }
    }
}
