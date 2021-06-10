
namespace Cinema
{
    partial class CinemaForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAddMovie = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxStartTime = new System.Windows.Forms.TextBox();
            this.textBoxFinishTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTimeDisplay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMovieName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMovieLength = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxAllMovies = new System.Windows.Forms.TextBox();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxSchedule = new System.Windows.Forms.TextBox();
            this.buttonGenerateSchedule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddMovie
            // 
            this.buttonAddMovie.Location = new System.Drawing.Point(15, 192);
            this.buttonAddMovie.Name = "buttonAddMovie";
            this.buttonAddMovie.Size = new System.Drawing.Size(165, 23);
            this.buttonAddMovie.TabIndex = 0;
            this.buttonAddMovie.Text = "Add Movie";
            this.buttonAddMovie.UseVisualStyleBackColor = true;
            this.buttonAddMovie.Click += new System.EventHandler(this.buttonAddMovie_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start Time";
            // 
            // textBoxStartTime
            // 
            this.textBoxStartTime.Location = new System.Drawing.Point(79, 16);
            this.textBoxStartTime.Name = "textBoxStartTime";
            this.textBoxStartTime.PlaceholderText = "10,00";
            this.textBoxStartTime.Size = new System.Drawing.Size(38, 23);
            this.textBoxStartTime.TabIndex = 2;
            this.textBoxStartTime.TextChanged += new System.EventHandler(this.textBoxStartTime_TextChanged);
            // 
            // textBoxFinishTime
            // 
            this.textBoxFinishTime.Location = new System.Drawing.Point(79, 47);
            this.textBoxFinishTime.Name = "textBoxFinishTime";
            this.textBoxFinishTime.PlaceholderText = "24,00";
            this.textBoxFinishTime.Size = new System.Drawing.Size(38, 23);
            this.textBoxFinishTime.TabIndex = 4;
            this.textBoxFinishTime.TextChanged += new System.EventHandler(this.textBoxFinishTime_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Finish Time";
            // 
            // textBoxTimeDisplay
            // 
            this.textBoxTimeDisplay.Location = new System.Drawing.Point(79, 79);
            this.textBoxTimeDisplay.Name = "textBoxTimeDisplay";
            this.textBoxTimeDisplay.PlaceholderText = "840";
            this.textBoxTimeDisplay.Size = new System.Drawing.Size(38, 23);
            this.textBoxTimeDisplay.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Work Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "min.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Add new movie";
            // 
            // textBoxMovieName
            // 
            this.textBoxMovieName.Location = new System.Drawing.Point(79, 134);
            this.textBoxMovieName.Name = "textBoxMovieName";
            this.textBoxMovieName.PlaceholderText = "name";
            this.textBoxMovieName.Size = new System.Drawing.Size(101, 23);
            this.textBoxMovieName.TabIndex = 10;
            this.textBoxMovieName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxMovieName.TextChanged += new System.EventHandler(this.textBoxMovieName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Name";
            // 
            // textBoxMovieLength
            // 
            this.textBoxMovieLength.Location = new System.Drawing.Point(79, 163);
            this.textBoxMovieLength.Name = "textBoxMovieLength";
            this.textBoxMovieLength.PlaceholderText = "length";
            this.textBoxMovieLength.Size = new System.Drawing.Size(101, 23);
            this.textBoxMovieLength.TabIndex = 12;
            this.textBoxMovieLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxMovieLength.TextChanged += new System.EventHandler(this.textBoxMovieLength_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Length";
            // 
            // textBoxAllMovies
            // 
            this.textBoxAllMovies.Location = new System.Drawing.Point(15, 221);
            this.textBoxAllMovies.Multiline = true;
            this.textBoxAllMovies.Name = "textBoxAllMovies";
            this.textBoxAllMovies.ReadOnly = true;
            this.textBoxAllMovies.Size = new System.Drawing.Size(165, 250);
            this.textBoxAllMovies.TabIndex = 13;
            this.textBoxAllMovies.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonRandom
            // 
            this.buttonRandom.Location = new System.Drawing.Point(15, 477);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(73, 23);
            this.buttonRandom.TabIndex = 14;
            this.buttonRandom.Text = "Random";
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(107, 477);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(73, 23);
            this.buttonDelete.TabIndex = 15;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxSchedule
            // 
            this.textBoxSchedule.Location = new System.Drawing.Point(207, 113);
            this.textBoxSchedule.Multiline = true;
            this.textBoxSchedule.Name = "textBoxSchedule";
            this.textBoxSchedule.ReadOnly = true;
            this.textBoxSchedule.Size = new System.Drawing.Size(521, 358);
            this.textBoxSchedule.TabIndex = 16;
            this.textBoxSchedule.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonGenerateSchedule
            // 
            this.buttonGenerateSchedule.Location = new System.Drawing.Point(563, 78);
            this.buttonGenerateSchedule.Name = "buttonGenerateSchedule";
            this.buttonGenerateSchedule.Size = new System.Drawing.Size(165, 23);
            this.buttonGenerateSchedule.TabIndex = 17;
            this.buttonGenerateSchedule.Text = "Generate Schedule";
            this.buttonGenerateSchedule.UseVisualStyleBackColor = true;
            this.buttonGenerateSchedule.Click += new System.EventHandler(this.buttonGenerateSchedule_Click);
            // 
            // CinemaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 512);
            this.Controls.Add(this.buttonGenerateSchedule);
            this.Controls.Add(this.textBoxSchedule);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonRandom);
            this.Controls.Add(this.textBoxAllMovies);
            this.Controls.Add(this.textBoxMovieLength);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxMovieName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTimeDisplay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxFinishTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxStartTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddMovie);
            this.Name = "CinemaForm";
            this.Text = "Start Time";
            this.Load += new System.EventHandler(this.CinemaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddMovie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxStartTime;
        private System.Windows.Forms.TextBox textBoxFinishTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTimeDisplay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMovieName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxMovieLength;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxAllMovies;
        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxSchedule;
        private System.Windows.Forms.Button buttonGenerateSchedule;
    }
}

