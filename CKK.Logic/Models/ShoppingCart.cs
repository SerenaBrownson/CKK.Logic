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
            return AddProduct(prod, 1); 
        }
        public ShoppingCartItem AddProduct(Product prod, int quantity) //I think something in here is messing with GetTotal Method.
        {   if ( quantity >= 1)
            {
                if (Product1 != null && Product1.GetProduct().GetId() == prod.GetId()) //Example from Instruct
                {
                    Product1.SetQuantity(Product1.GetQuantity() + quantity);
                }
                else if (Product2 != null && Product2.GetProduct().GetId() == prod.GetId()) 
                {
                    Product2.SetQuantity(Product2.GetQuantity() + quantity);
                }
                else if (Product3 != null && Product3.GetProduct().GetId() == prod.GetId()) 
                {
                    Product3.SetQuantity(Product3.GetQuantity() + quantity);
                }
                 
                if (Product1 == null)
                {
                    Product1 = new ShoppingCartItem(prod, quantity);
                    return Product1;
                }
                else if (Product2 == null)
                {
                     Product2 = new ShoppingCartItem(prod, quantity);
                    return Product2;
                }
                else if (Product3 == null)
                {
                   Product3 = new ShoppingCartItem(prod, quantity);
                    return Product3;
                }
            }
            return null;
        }
         
        public ShoppingCartItem RemoveProduct(Product prod, int quantity) // Passing Now
        {
            if (quantity >= 1)
            {
                if (Product1 != null && Product1.GetProduct().GetId() == prod.GetId()) //Example from Instruct
                {
                    Product1.SetQuantity(Product1.GetQuantity() - quantity);
                    return Product1;
                }
                else if (Product2 != null && Product2.GetProduct().GetId() == prod.GetId()) 
                {
                    Product2.SetQuantity(Product2.GetQuantity() - quantity);
                    return Product2;
                }
                else if (Product3 != null && Product3.GetProduct().GetId() == prod.GetId())
                {
                    Product3.SetQuantity(Product3.GetQuantity() - quantity);
                    return Product3;
                }
            }

            return null;
        }

        public decimal GetTotal() //not currently working
        {
            return Product1.GetTotal() + Product2.GetTotal() + Product3.GetTotal();
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
