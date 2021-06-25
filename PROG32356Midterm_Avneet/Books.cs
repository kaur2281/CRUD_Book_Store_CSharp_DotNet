using System;
using System.Collections.Generic;
using System.Text;

namespace PROG32356Midterm_Avneet
{
    class Books
    {
        public string Title { get; set; }
        public String Genre { get; set; }
        public int Isbn { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return "ID: " + Title +" | Genre " + Genre + " | Isbn " + Isbn + " | Price " + Price ;
        }
    }
}
