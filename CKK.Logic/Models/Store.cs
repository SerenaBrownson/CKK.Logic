using System;
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
        private Product product1;
        private Product product2;
        private Product product3;

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
     
        public void AddStoreItem(Product prod)
        {
           // Adds a product to the next available product
            if (product1 == null)
            {
                prod = product1;
            }
            else if (product2 == null)
            {
                prod = product2;
            }
            else if( product3 == null)
            {
                prod = product3;
            }
            //If there is no available product, it will not add a product at all

            if (product1 != null && product2 != null && product3 != null )
            {
                prod = null;
            }

            //If there is an item in spot two, but not spot one or three, then it should put the item in spot 1
            if(product1 != null && product3 != null)
            {
                prod = product1;
            }

        }
       
        public void RemoveStoreItem(int productNum)
        {
            //Removes a product from  the desired product

            if (productNum == 1)
            {
                product1 = null;
            }
            if(productNum==2)
            {
                product2 = null;
            }

            if (productNum == 3)
            {
                product3 = null;
            }

            //If there are no products, does nothing
            if(product1 == null && product2 == null && product3 == null)
            {
                product1 = null;
                product2 = null;
                product3 = null;
            }
            //If product is out of range, does nothing
            if(productNum != 1 || productNum != 2 ||productNum != 3)
            {
                //not sure what to put here. can this be left empty?
            }
            

        }

        public Product GetStoreItem(int productNum)
        {
            return productNum == 1 ? product1 : productNum == 2 ? product2 : productNum == 3 ? product3 : null;
            //checks for if statements in an return statement, if all false returns null
            //check for functionality
        }

        public Product FindStoreByItemId(int Id)
        {
            return Id == product1.GetId() ? product1 : Id == product2.GetId() ? product2 : Id == product3.GetId() ? product3: null;
            //check for functionality
        }

    }

}
