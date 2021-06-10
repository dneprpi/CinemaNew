using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class CinemaForm : Form
    {
        public int WorkTime { get; set; }
        public Schedule BestSchedule { get; set; }
        public Schedule CurentSchedule { get; set; }
        private int StartTimeHours { get; set; }
        private int FinishTimeHours { get; set; }
        private int StartTimeMinutes { get; set; }
        private int FinishTimeMinutes { get; set; }
        private Movie CurrentMovie { get; set; }
        private List<Movie> AllMovies { get; set; }
        
        private Scheduler _scheduler;

        public CinemaForm()
        {
            InitializeComponent();
        }

        private void CinemaForm_Load(object sender, EventArgs e)
        {
            StartTimeHours = 10;
            StartTimeMinutes = 0;
            FinishTimeHours = 24;
            FinishTimeMinutes = 0;
            WorkTime = 840;
            textBoxTimeDisplay.Text = WorkTime.ToString();
            CurrentMovie = new Movie();
            AllMovies = new List<Movie>();
            BestSchedule = new Schedule(WorkTime);
            CurentSchedule = new Schedule(WorkTime);
        }

        private void textBoxStartTime_TextChanged(object sender, EventArgs e)
        {
            if (textBoxStartTime.Text.Length > 0)
            {
                double StartTime = Convert.ToDouble(textBoxStartTime.Text);
                StartTimeHours = (int)(Math.Floor(StartTime));
                StartTimeMinutes = (int)(StartTime - StartTimeHours);
                WorkTime = (FinishTimeHours - StartTimeHours) * 60 + (FinishTimeMinutes - StartTimeMinutes);
                textBoxTimeDisplay.Text = WorkTime.ToString();
            }
        }

        private void textBoxFinishTime_TextChanged(object sender, EventArgs e)
        {
            if (textBoxFinishTime.Text.Length > 0)
            {
                double FinishTime = Convert.ToDouble(textBoxFinishTime.Text);
                FinishTimeHours = (int)Math.Floor(FinishTime);
                FinishTimeMinutes = (int)(FinishTime - FinishTimeHours);
                WorkTime = (FinishTimeHours - StartTimeHours) * 60 + (FinishTimeMinutes - StartTimeMinutes);
                textBoxTimeDisplay.Text = WorkTime.ToString();
            }
        }

        private void textBoxMovieName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxMovieName.Text.Length > 0)
            {
                CurrentMovie.Name = textBoxMovieName.Text.Trim();
            }
        }

        private void textBoxMovieLength_TextChanged(object sender, EventArgs e)
        {
            if (textBoxMovieLength.Text.Length > 0)
            {
                CurrentMovie.Length = Convert.ToInt32(textBoxMovieLength.Text);
            }
        }

        private void buttonAddMovie_Click(object sender, EventArgs e)
        {
            Movie newMovie = new Movie(CurrentMovie.Name, CurrentMovie.Length);
            AllMovies.Add(newMovie);
            textBoxAllMovies.Text += CurrentMovie.Name + ", " + CurrentMovie.Length + " min." + Environment.NewLine;
        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            textBoxAllMovies.Clear();
            Movie Movie1 = new Movie("Lion King", 90);
            Movie Movie2 = new Movie("Wizard of OZ", 80);
            Movie Movie3 = new Movie("Mickey Mouse", 70);
            AllMovies.Add(Movie1);
            AllMovies.Add(Movie2);
            AllMovies.Add(Movie3);
            for (int i = 0; i < AllMovies.Count; ++i)
            {
                textBoxAllMovies.Text += AllMovies[i].Name + ", " + AllMovies[i].Length + " min." + Environment.NewLine;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            AllMovies.RemoveAt(AllMovies.Count - 1);
            textBoxAllMovies.Clear();
            for (int i = 0; i < AllMovies.Count; ++i)
            {
                textBoxAllMovies.Text += AllMovies[i].Name + ", " + AllMovies[i].Length + " min." + Environment.NewLine;
            }
        }

        private void buttonGenerateSchedule_Click(object sender, EventArgs e)
        {
            Scheduler.AllMovies = AllMovies;
            Scheduler.WorkTime = WorkTime;
            _scheduler = new Scheduler();
            
            BestSchedule = _scheduler.setFirstBestSchedule();
            _scheduler.FindBestSchedule();
            List<Schedule> AllSchedules = _scheduler.AllSchedules;
            textBoxSchedule.Text = BestSchedule.WriteSchedule();
        }
    }
}
