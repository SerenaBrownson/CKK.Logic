using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CKK.Logic.Models
{
    public class ShoppingCart
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
        //GetIDMethod
        public int GetCustomerId()
        {
            return Customer.GetId();
        }
        
         public ShoppingCartItem GetProductById( int ID) 
        {
            var item = new Product();
            item.SetId(ID);
            var find = new ShoppingCartItem(item, 1);
            products.Contains(find );
            return find;
        }

        public ShoppingCartItem AddProduct(Product prod)
        {
            return AddProduct(prod, 1); 
        }
        public ShoppingCartItem AddProduct(Product prod, int quantity) 
        {   if (quantity >= 1) 
            {
                var item = new ShoppingCartItem(prod, quantity);
                products.Add(item);
                return item;
            }
            else return null;
        }

        public ShoppingCartItem RemoveProduct(int id, int quantity)
        {
            var item = products.FirstOrDefault(x => x.GetProduct().GetId() == id);

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
                    products.Remove(item);
                    return null;
                }

            }

            return null;
        }
    

        public decimal GetTotal() 
        {
            var shoppingtotal = 0.0M;
            foreach ( var product in products)
            {
                shoppingtotal = product.GetProduct().GetPrice() * product.GetQuantity();
            }
            return shoppingtotal; 
            
        }
        
        public List<ShoppingCartItem> GetProducts() 
        {
            return products;
        }


    }
}
