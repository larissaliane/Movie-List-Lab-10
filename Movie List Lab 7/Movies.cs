using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_List_Lab_7
{
    public class Movies
    {
        public string Title { get; set; }
        public string Category { get; set; }
    
        public  Movies()
        {
     
        }
        public Movies(string title, string category)
        {
            Title = title;
            Category = category;
        }
    }
}
