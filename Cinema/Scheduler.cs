using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema
{
    public class Scheduler
    {
        public static List<Movie> AllMovies { get; set; }
        public Schedule BestSchedule { get; set; }
        public Schedule CurrentSchedule { get; set; }
        public static int WorkTime { get; set; }
        public int FreeTime { get; set; }

        public List<Schedule> AllSchedules { get; set; }
        public Scheduler ()
        {
            BestSchedule = new Schedule(WorkTime);
            FreeTime = WorkTime;
            AllSchedules = new List<Schedule>();
        }
        public Schedule setFirstBestSchedule()
        {
            for (int i = 0; i < AllMovies.Count; ++i)
            {
                if (!BestSchedule.Movies.Contains(AllMovies[i]))
                {
                    ++BestSchedule.UniqMovies;
                }
                if (BestSchedule.FreeTime >= AllMovies[i].Length)
                {
                    BestSchedule.Movies.Add(new Movie(AllMovies[i]));
                    BestSchedule.FreeTime -= AllMovies[i].Length;
                }
                else
                {
                    break;
                }
            }
            if (BestSchedule.FreeTime >= AllMovies[0].Length)
            {
                setFirstBestSchedule();
            }
            return BestSchedule;
        }
        public void FindBestSchedule(Schedule currentSchedule = null)
        {
            foreach(Movie m in AllMovies)
            {
                if (currentSchedule is null)
                {
                    currentSchedule = new Schedule(WorkTime);
                }
                bool isAdded = false;
                if (currentSchedule.FreeTime >= m.Length)
                {
                    currentSchedule.Movies.Add(new Movie(m));
                    currentSchedule.FreeTime -= m.Length;
                    FindBestSchedule(currentSchedule);
                    isAdded = true;
                }
                AllSchedules.Add(new Schedule(currentSchedule));
                if (CompareScheduleToBest(BestSchedule, currentSchedule))
                {
                    SetBestSchedule(currentSchedule);
                }
                if (isAdded)
                {
                    currentSchedule.FreeTime += currentSchedule.Movies[currentSchedule.Movies.Count - 1].Length;
                    currentSchedule.Movies.RemoveAt(currentSchedule.Movies.Count - 1);
                }
            }
        }
        public bool CompareScheduleToBest (Schedule best, Schedule current)
        {
            if (best.FreeTime < current.FreeTime)
            {
                return false;
            }
            else if (best.FreeTime == current.FreeTime)
            {
                if(best.UniqMovies < current.UniqMovies)
                {
                    return true;
                }
                else 
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }
        private void SetBestSchedule (Schedule current)
        {
            BestSchedule = new Schedule(current);
        }
    }
}
