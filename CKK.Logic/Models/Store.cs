using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Interfaces;
using CKK.Logic.Exceptions;

namespace CKK.Logic.Models
{
    public class Store : Entity , IStore
    {
        
       
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
            var item = FindStoreItemById(prod.GetId()); ///might be causing error 
            if (quantity >= 1)
            {
                if (item != null)
                {

                    item.SetQuantity(quantity + item.GetQuantity());

                    return item;
                }
                else
                {
                    var newItem = new StoreItem(prod, quantity);
                    items.Add(newItem);
                    return newItem;
                }
            }
            else 
            {
                throw new InventoryItemStockTooLowException("Quantity given is less than or equal to 0, inventory item stock too low");
            };
        }
       
        public StoreItem RemoveStoreItem(int productNum, int quantity)  
        {
            var item = FindStoreItemById(productNum);

            if (quantity < 0) { throw new ArgumentOutOfRangeException(); }

            else if (item != null)
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

            else 
            {
                throw new ProductDoesNotExistException("Product does not exist");
            }
        }

        public List<StoreItem> GetStoreItems() 
        {
            return items;

        }

        public StoreItem FindStoreItemById(int Id) 
        {
            if (Id < 0) { throw new InvalidIdException("Invalid Id"); }
            else { return items.FirstOrDefault(x => x.GetProduct().GetId() == Id); }
        }

    }

}
