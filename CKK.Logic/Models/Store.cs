﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class Store
    {
        private int id;
        private string name;
        private List<StoreItem> items;



        public Store()
        {
            items = new List<StoreItem>(); //maybe?
           
        }

        public int GetId()
        {
            return id;
        }

        public void SetId(int argId)
        {
            id = argId;
        }

        public string GetName()
        {
            return name;
        }
        public void SetName(string argName)
        {
            name = argName;
        }

        public StoreItem AddStoreItem(Product prod, int quantity)    //Add Return Product as StoreItem && Add Quantity Argument 
        {
            var item = items.FirstOrDefault(x => x.GetProduct() == prod); ///might be causing error 


            if (items.Contains(item))
            {
                int startingQuantity = item.GetQuantity();
                item.SetQuantity(quantity + startingQuantity);
                
                return item;
            }
            else
            {
                items.Add(item);
                return item;
            }
        }
       
        public StoreItem RemoveStoreItem(int productNum, int quantity)  //Add return type as StoreItem && add quantity argument
        {
            var item = items.FirstOrDefault(x => x.GetProduct().GetId() == productNum);

            if (item != null)
            {
                int startingQuantity = item.GetQuantity();

                if (startingQuantity > quantity)
                {
                    int endingQuantity = startingQuantity - quantity;
                    item.SetQuantity(endingQuantity);
                    return item;
                }

                else
                {
                    item.SetQuantity(0);
                    return item;
                }

            }

            else return null;
        }

        public List<StoreItem> GetStoreItems() //remove argument and return list
        {
            return items;

        }

        public StoreItem FindStoreItemById(int Id) //change retrn type to store item. 
        {
            return items.FirstOrDefault(x => x.GetProduct().GetId() == Id);
        }

    }

}
