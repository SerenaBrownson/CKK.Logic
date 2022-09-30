using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Interfaces;
using CKK.Logic.Exceptions;


namespace CKK.Logic.Models
{
    public class ShoppingCart : IShoppingCart
    {
        //initial values
        private Customer Customer;
        private List<ShoppingCartItem> products;



        //constructor 
        public ShoppingCart(Customer argCust)
        {
            Customer = argCust;
            products = new List<ShoppingCartItem>();
        }


        public Customer customer
        {
            get; set;
        }

        public Product Products
        {
            get; set;
        }




        //GetIDMethod
        public int GetCustomerId()
        {
            return Customer.GetId();
        }
        
         public ShoppingCartItem GetProductById( int ID) 
        { if (ID < 0) { throw new InvalidIdException("Invalid ID"); }
            else 
            {
                return products.FirstOrDefault(x => x.GetProduct().GetId() == ID);
            }
        }

        public ShoppingCartItem AddProduct(Product prod)
        {
            return AddProduct(prod, 1); 
        }
        public ShoppingCartItem AddProduct(Product prod, int quantity) 
        {
            var item = GetProductById(prod.GetId());
            if (quantity >= 1)
            {
                if (item != null)
                {
                    item.SetQuantity(quantity + item.GetQuantity());

                    return item;
                }
                else
                {
                    var itemAdd = new ShoppingCartItem(prod, quantity);
                    products.Add(itemAdd);
                    return itemAdd;
                }
            }
            else { throw new InventoryItemStockTooLowException("Quantity is less than or equal to 0, Inventory Item Stock Too Low"); }
            
           
        }

        public ShoppingCartItem RemoveProduct(int id, int quantity) 
        {
            var item = GetProductById(id);

            if (quantity < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else if (item != null)
            {
                int startingQuantity = item.GetQuantity();
                if (startingQuantity - quantity > 0)
                {
                    item.SetQuantity(startingQuantity - quantity);
                    return item;
                }
                else
                {
                    item.SetQuantity(0);
                    products.Remove(item);
                    return item;
                }
            }

            else 
            {
                throw new ProductDoesNotExistException("Product Does not Exist");
            }
        }
    

        public decimal GetTotal() 
        {
            var shoppingtotal = 0.0M;
            foreach ( var product in products)
            {
                shoppingtotal += product.GetProduct().GetPrice() * product.GetQuantity();
            }
            return shoppingtotal; 
            
        }
        
        public List<ShoppingCartItem> GetProducts() 
        {
            return products;
        }


    }
}
