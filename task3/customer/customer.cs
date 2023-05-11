using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3.products;

namespace task3.customer
{
    class customer_
    {
       public string name,address;
        int contact;
        public List<string> products = new List<string>();
        public customer_(string name,string address,int contact)
        {
            this.name = name;
            this.address = address;
            this.contact = contact;
        }
        public void buy_products(string product)
        {
            this.products.Add(product);
        }
        public static int total_purchases(string name,int x, List<customer_> cs, List<products_> ps)
        {
            int total_price=0;
            foreach(string data in cs[x].products)
            {
               total_price+= products_.product_price(data,ps);
            }
           
            return total_price;
        }
        public static float tax(string name, int x, List<customer_> cs, List<products_> ps)
        {
            float total_tax = 0;
            foreach (string data in cs[x].products)
            {
                total_tax = products_.product_tax(data, ps);
            }

            return total_tax;
        }
    }
}
