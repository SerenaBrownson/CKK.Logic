﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Models;

namespace CKK.Logic.Interfaces
{
   public abstract class InventoryItem
    {
      public Product product { get; set; }
       public int quantity { get; set; }
    }
}
