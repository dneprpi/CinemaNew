using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema
{
    public class Schedule
    {
        public List<Movie> Movies { get; set; }
        public int TotalLength { get; set; }
        public int FreeTime { get; set; }
        public int UniqMovies { get; set; }
        public Schedule (int freeTime)
        {
            FreeTime = freeTime;
            Movies = new List<Movie>();
            UniqMovies = 0;
            TotalLength = 0;
        }
        public Schedule (Schedule curent)
        {
            FreeTime = curent.FreeTime;
            Movies = new List<Movie>(curent.Movies);
            UniqMovies = curent.UniqMovies;
            TotalLength = curent.TotalLength;
        }
        public string WriteSchedule ()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Movie m in Movies)
            {
                sb.Append(m.Name + " - ");
                sb.Append(m.Length + " min.");
                sb.Append(Environment.NewLine);
            }
            return sb.ToString().Trim();
        }
    }
}
