﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Models;

namespace CKK.Logic.Interfaces
{
    public interface IStore
    {
        StoreItem AddStoreItem(Product prod, int quantity);

        StoreItem RemoveStoreItem(int productNum, int quantity);

        StoreItem FindStoreItemById(int Id);

        List<StoreItem> GetStoreItems();


    }
}
