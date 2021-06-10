using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema
{
    public class Movie
    {
        public string Name { get; set; }
        public int Length { get; set; }
        public Movie()
        {
        }
        public Movie (string name, int length)
        {
            Name = name;
            Length = length;
        }
        public Movie (Movie tmp)
        {
            Name = tmp.Name;
            Length = tmp.Length;
        }
    }
}
