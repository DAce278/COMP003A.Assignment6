using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.WebRequestMethods;

namespace COMP003A.Assignment6
{
    internal class Book
    {
        public int BookNumber;
        public string Title;
        public int Pages;
        public bool Completion;

        public Book(int bookNumber, string title, int pages, bool completion)
        {
            BookNumber = bookNumber;
            Title = title;
            Pages = pages;
            Completion = completion;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Item {BookNumber}: Title={Title}, Pages={Pages}, Completed?={Completion}");
        }
    }
}
