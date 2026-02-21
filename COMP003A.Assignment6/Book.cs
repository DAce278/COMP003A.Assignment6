using System;
using System.Collections.Generic;
using System.Text;

namespace COMP003A.Assignment6
{
    internal class Book
    {
        public string Title;
        public int Pages;
        public bool Completion;

        public Book(string title, int pages, bool completion)
        {
            Title = title;
            Pages = pages;
            Completion = completion;
        }


    }
}
