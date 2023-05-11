using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3.customer;

namespace task3.products
{
    class products_
    {
        string name, category;
        int price;
        public products_(string name,string category,int price)
        {
            this.name = name;
            this.category = category;
            this.price = price;
        }
        public static int product_price(string product_name, List<products_> ps)
        {
            int price=0;
            foreach(products_ data in ps)
            {
                if(product_name==data.name)
                {
                    price += data.price;
                }

            }
            return price;
        }
        public static float product_tax(string product_name, List<products_> ps)
        {
            float tax = 0.0F;
            foreach (products_ data in ps)
            {
                if (product_name == data.name)
                {
                    return tax += (5.0F/100.0F)*data.price;
                }

            }
            return 0.0F;
        }
    }
}
