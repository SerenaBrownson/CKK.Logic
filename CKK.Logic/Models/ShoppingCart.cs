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
       private ShoppingCartItem Product1;
       private ShoppingCartItem Product2;
       private ShoppingCartItem Product3;

        //constructor
        public ShoppingCart(Customer argCust)
        {
           Customer = argCust;
        }
        //GetIDMethod
        public int GetCustomerId()
        {
            return Customer.GetId();
        }
        
         public ShoppingCartItem GetProductById( int ID)
        {
            return ID == 1? Product1 : ID == 2? Product2 : ID == 3? Product3 : null;
        }

        public ShoppingCartItem AddProduct(Product prod)
        {
            return AddProduct(prod, quantity: 1); 
        }
        public ShoppingCartItem AddProduct(Product prod, int quantity) //Maybe???
        {
            if ( quantity >= 1)
            {
                if (Product1 == null)
                {
                    return Product1;
                }
                else if (Product2 == null)
                {
                    return Product2;
                }
                else if (Product3 == null)
                {
                    return Product3;
                }
            }
            return null;
        }
         
        public ShoppingCartItem RemoveProduct(Product prod, int quantity)
        {
            if (quantity >= 1)
            {
                return RemoveProduct(prod, quantity - quantity);
            }

            return null;
        }

        public decimal GetTotal() //maybe???
        {
            return (decimal) Product1.GetTotal() + (decimal)Product2.GetTotal() + (decimal)Product3.GetTotal();
        }
        
        public ShoppingCartItem GetProduct(int prodNum)
        {
            if (prodNum == 1)
            {
                return Product1;
            }
            else if (prodNum == 2)
            {
                return Product2;
            }
            else if (prodNum == 3)
            {
                return Product3;
            }
            else return null;
        }


    }
}
