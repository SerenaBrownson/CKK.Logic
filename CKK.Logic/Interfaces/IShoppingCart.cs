﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Models;

namespace CKK.Logic.Interfaces
{
     public interface IShoppingCart
    {
        int GetCustomerId();

        ShoppingCartItem AddProduct(Product prod, int quantity);

        ShoppingCartItem RemoveProduct(int id, int quantity);

        decimal GetTotal();

        ShoppingCartItem GetProductById(int ID);

        List<ShoppingCartItem> GetProducts();

    }
}
