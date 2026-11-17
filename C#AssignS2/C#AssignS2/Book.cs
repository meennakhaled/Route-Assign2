using System;
using System.Collections.Generic;
using System.Text;

namespace C_AssignS2
{
    internal class Book
    {
        public string Title;
        public int Pages;

        public override string ToString()
        {
            return $"Title: {Title}, Pages: {Pages}";
        }
    }
}
