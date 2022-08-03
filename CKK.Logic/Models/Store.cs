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
     
    }

}
