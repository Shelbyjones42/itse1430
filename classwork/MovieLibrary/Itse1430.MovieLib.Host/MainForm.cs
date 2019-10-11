﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Itse1430.MovieLib.Host
{
    public partial class MainForm : Form
    {
        public MainForm ()
        {
            //int x = 10;
            InitializeComponent ();

            //Itse1430.MovieLib.Movie
            Movie movie = new Movie();
            movie.Title = "Jaws";
            movie.Description = movie.Title;
        }
        //Called when Movie\Add selected
        private void OnMovieAdd ( object sender, EventArgs e )
        {
            var form = new MovieForm ();
            //Modeless - does not block main window
            //form.Show ();

            ////Show the new movie form modally
            if (form.ShowDialog (this) == DialogResult.OK)
                _movies.Add (form.Movie);
                UpdateUI ();
        }

        private Movie GetSelectedMovie()
        {
            // return _lstMovies.SelectedItem as Movie;
            var item = _lstMovies.SelectedItem;
            // if (item ==null)
            //    return null;
            
            // Movie or null
            // Will use 90% of the time.
            return item as Movie;
            
            // // Other approaches
            // // C-style cast
            // (Movie)item;
            //
            // // Old approach 1
            // var tempVar = item as Movie;
            // if (tempVar != null)
            // {
            //
            // };
            //
            // // Old approach 2
            // if (item is Movie)
            // {
            //     var i = (Movie)item;
            //     // Do something with movie
            // }
            //
            // // Pattern matching
            // if (item is Movie movie)
            // {
            // };
        }

        private void OnMovieEdit ( object sender, EventArgs e )
        {
            //Get selected movie
            var movie = GetSelectedMovie ();
            if (movie == null)
                return;

            var form = new MovieForm ();
            form.Movie = movie;

            if (form.ShowDialog (this) == DialogResult.OK)
            {
                //TODO: Change to update
                _movies.Update (movie.Id, form.Movie);
                UpdateUI ();
            }
        }

        private void OnMovieDelete ( object sender, EventArgs e )
        {

            //Demo
            var menuItem = sender as Button;
            //This will crash if menuItem is null
            //var text = menuItem.Text;

            //Handle Null
            var text = "";
            if (menuItem != null)
                text = menuItem.Text;
            else
                text = "";

            //As expression
            var text2 = (menuItem != null) ? menuItem.Text : "";

            //Null coalescing menuItem ?? "";
            //Null conditional operater
            var text3 = menuItem?.Text ?? "";

            var movie = GetSelectedMovie ();
            if (movie == null)
                return;

            //Confirmation
            var msg = $"Are you sure you want to delete {movie.Title}?";
            var result = MessageBox.Show (msg, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            //TODO: Delete it
            _movies.Remove(movie.Id);
            UpdateUI ();
        }


        private void OnFileExit ( object sender, EventArgs e )
        {
            Close ();
        }

        private void OnHelpAbout ( object sender, EventArgs e )
        {
            var form = new AboutBox1 ();
            form.ShowDialog (this);
        }

        private void UpdateUI()
        {
            var movies = _movies.GetAll ();

            // Programmatic approach
            //_lstMovies.Items.Clear ();
            //_lstMovies.Items.AddRange (movies);

            // For more complex bindings
            _lstMovies.DataSource = movies;
        }

        private MovieDatabase _movies = new MovieDatabase ();

        private void MainForm_Load ( object sender, EventArgs e )
        {

        }
    }

}
