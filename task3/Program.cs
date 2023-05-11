using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using task3.products;
using task3.customer;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<products_> ps = new List<products_>();
            List<customer_> cs = new List<customer_>();
            int option;
            bool runned=false;
            while (true)
            {
                option = menu();
                Console.Clear();
                if (option == 1)
                {
                    
                    
                        ps.Add(admin(cs, ps));
                    
                    if(ps.Last()==null)
                        option=menu();
                }
                if (option == 2)
                {
                    
                        cs.Add(customer(ps, cs,ref runned));
                    if(cs.Last()==null)
                        runned = false;
                }
            }  
        }
        static int menu()
        {
            int option;
            
            
                Console.WriteLine("1.Admin");

                Console.WriteLine("2.Customer");
                option = int.Parse(Console.ReadLine());
                return option;
            
        }
        static products_ admin(List<customer_> cs, List<products_> ps)
        {
            int option;
            string name, category;
            int price;
            while (true)
            {
                Console.WriteLine("1.Add a product: ");
                Console.WriteLine("2.Customer data: ");
                Console.WriteLine("0.Exit.");
                option = int.Parse(Console.ReadLine());
                if (option == 0)
                {
                    return null;
                }
                if (option == 1)
                {
                    Console.WriteLine("Enter name: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter the category: ");
                    category = Console.ReadLine();
                    Console.WriteLine("Enter the price: ");
                    price = int.Parse(Console.ReadLine());
                    products_ p = new products_(name, category, price);
                    return p;
                }
                if (option == 2)
                {
                    customer_data(ps, cs);
                }
            }
            
        }
        static customer_ customer (List<products_> ps,List<customer_> cs, ref bool runned)
        {
            string name="a", address="b",product;
            int contact=0,no;
         
            if (runned == false)
            {
                Console.WriteLine("Enter name: ");
                name = Console.ReadLine();
                Console.WriteLine("Enter Address: ");
                address = Console.ReadLine();
                Console.WriteLine("Enter contact: ");
                contact = int.Parse(Console.ReadLine());
         
                runned = true;
                
            }
            customer_ c = new customer_(name, address, contact);
            Console.WriteLine("1.Buy products");
            Console.WriteLine("0.Exit");
            int option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                Console.WriteLine("Enter the no of products you want to buy:");
                no = int.Parse(Console.ReadLine());
                for (int x = 0; x < no; x++)
                {
                    Console.WriteLine("Enter the product you want to buy:");
                    product = (Console.ReadLine());
                    c.buy_products(product);
                }
                
            }
            return c;
        }
        static void customer_data(List<products_> ps,List<customer_> cs)
        {
            int total_price = 0;
                float total_tax=0;
            string name;
            Console.WriteLine("Enter the name of the customer: ");
            name = Console.ReadLine();
            int x = 0;
            for( x=0;x<cs.Count;x++)
            {
               if(name==cs[x].name)
                {

                    total_price+= customer_.total_purchases(name,x,cs,ps);
                    total_tax += customer_.tax(name, x, cs, ps);
                }
            }
            Console.WriteLine("The customer {0}'s total purchase is {1} and total tax is {2}", cs[x-1].name, total_price, total_tax);
        }
    }
}
