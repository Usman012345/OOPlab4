using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using task2.Book;
using task2.Books;
using task2.chapters;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int returned;
            List<books> bookmarks = new List<books>();
            List<chapter> cs = new List<chapter>();
            List<books> books = new List<books>();
            int option = menu();
            while (true)
            {
                if(option==0)
                {
                     option = menu();

                }
                if (option == 1)
                {
                   returned= adminmenu(cs, books,bookmarks);
                   if(returned==0)
                    {
                        option = 0;
                    }
                }
                if (option == 2)
                {
                    returned=usermenu(cs, books,bookmarks);
                    if (returned == 0)
                    {
                        option = 0;
                    }
                }
            }
        }
        static int menu()
        {

            Console.Clear();
                int option = 0;
                Console.WriteLine("1.Admin");
                Console.WriteLine("2.User");
                /*Console.WriteLine("3.See bookmark");
                Console.WriteLine("4.See chapter");*/
                option = int.Parse(Console.ReadLine());
                return option;
            
        }
       static int adminmenu(List<chapter> cs, List<books> books, List<books> bookmarks)
        {
            Console.Clear();
            bool avaliable;
            int count = 0,bcount=0;
            /*List<books> books = new List<books>();*/
            int option;
            Console.WriteLine("1.Add book");
            Console.WriteLine("2.Add chapters");
            Console.WriteLine("3.Set bookmark");
            Console.WriteLine("4.check avaliability");
            Console.WriteLine("0.Exit");
            option = int.Parse(Console.ReadLine());
            if(option==0)
            {
                return 0;
            }
            if(option==1)
            {
               books.Add( addbook());
                count++;
            }
            if(option==2)
            {
               cs.Add( addchapters());
            }
            if(option==3)
            {
               bookmarks.Add( bookmark());
                bcount++;
            }
            if(option==4)
            {
               avaliable= checkavaliability(books);
                if (avaliable == true)
                {
                    Console.WriteLine("Book is avaliable.");
                }
                else
                    Console.WriteLine("Book is borrowed.");
                Console.ReadKey();
            }
            return 5;

        }
      static int usermenu(List<chapter> cs, List<books> books, List<books> bookmarks)
        {
            Console.Clear();

            books b = new books();
            int bookmark;  
            bool avaliable;
            int option;
            Console.WriteLine("1.check if book is avaliable: ");
            Console.WriteLine("2.see bookmark");
            Console.WriteLine("3.Name of chapter");
            Console.WriteLine("0.Exit");
            option = int.Parse(Console.ReadLine());
            Console.WriteLine("0.Exit");
            if (option == 0)
            {
                return 0;
            }
            if (option==1)
            {
                avaliable = checkavaliability(books);
                if (avaliable == true)
                {
                    Console.WriteLine("Book is avaliable.");
                }
                else
                    Console.WriteLine("Book is borrowed.");
                Console.ReadKey();
            }
            if(option==2)
            {
               bookmark= see_bookmark(b,books,bookmarks);
                if(bookmark!=0)
                {
                    Console.WriteLine("Page {0} is bookmarked", bookmark);
                }
                else
                    Console.WriteLine("No page is bookmarked");
                Console.ReadLine();
            }
            if(option==3)
            {
                see_chapter(cs,b, books);
            }
            return 5;
        }
        static int see_bookmark(books b,List<books> books, List<books> bookmarks)
        {
            string title;
            Console.WriteLine("Enter the book title");
            title = Console.ReadLine();
           return b.getbookmark(bookmarks);
            
        }
       static int see_chapter(List<chapter> cs, books b,List<books> books)
        {
            int ch;
            string chapter;
            Console.WriteLine("Enter the no of chapter");
            ch = int.Parse(Console.ReadLine());
          chapter=  b.getchapter(ch, cs);
            Console.WriteLine(chapter);
            Console.ReadLine();
            return 0;
        }
        static books addbook()
        {
            
            string author,title;
            int pages, price;
            Console.WriteLine("Enter title");
           title= Console.ReadLine();
            Console.WriteLine("Enter the author: ");
            author = Console.ReadLine();
            Console.WriteLine("Enter the no of pages: ");
            pages = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter price: ");
            price = int.Parse(Console.ReadLine());
            books book = new books(title,author, pages, price);
            /*List<books> books = new List<books>();*/
            return book;
        }
        static chapter addchapters()
        {
            string chapter;
            Console.WriteLine("Enter the name of chapter: ");
          chapter=  Console.ReadLine();
            chapter c = new chapter(chapter);
            return c;
        }
       static books bookmark()
        {
            books b = new books();
            int page_no;
            Console.WriteLine("Enter the page number: ");
            page_no=int.Parse(Console.ReadLine());
            b.setbookmark(page_no);
            return b;
        }
      static bool checkavaliability(List<books> books)
        {
            string title;
            Console.WriteLine("Enter the book title: ");
           title= Console.ReadLine();
            foreach (books data in books)
            {
                if(data.title==title && data.borrow==true)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
