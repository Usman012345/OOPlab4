using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2.chapters;

namespace task2.Book
{
    class books
    {
       public bool borrow;
        public string title;
        public int count = 0;
        public int[] chapter_no=new int[1000];
        public string author;
        public int pages;
        public List<string> chapters_ = new List<string>();
        public int bookmark;
        public int price;
        public books(string title="",string author="",int pages=0,int price=0)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
            this.price = price;
        }
        public string getchapter(int chapter_no, List<chapter> css)
        {
            for (int x = 0; x < css.Count; x++)
            {
                if (x == chapter_no - 1)
                {
                    return css[x].chapter_;
                }
            }
            return null;
        }
        public int getbookmark(List<books> bookmarks)
        {
            foreach (books data in bookmarks)
            {
                if (data.title == title && data.bookmark != 0)
                {
                    return data.bookmark;
                }
            }
            return 0;
        }
        public void setbookmark(int page_no)
        {
            this.bookmark = page_no;
        }
       public int getbookprice()
        {
           
            return this.price;
        }
        public void setbookprice(int price)
        {
            this.price = price;
        }
    }
}
