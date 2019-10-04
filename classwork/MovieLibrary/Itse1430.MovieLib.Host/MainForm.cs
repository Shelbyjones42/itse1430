﻿using System;
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
                AddMovie (form.Movie);
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
                RemoveMovie (movie);
                //RemoveMovie (form.Movie);
                AddMovie (form.Movie);
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
            RemoveMovie (movie);
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
            var movies = GetMovies ();

            // Programmatic approach
            //_lstMovies.Items.Clear ();
            //_lstMovies.Items.AddRange (movies);

            // For more complex bindings
            _lstMovies.DataSource = movies;
        }

        private void AddMovie (Movie movie)
        {
            //Add to array
            for (var index = 0; index < _movies.Length; ++index)
            {
                if (_movies[index] == null)
                {
                    _movies[index] = movie;
                    return;
                };
            };
        }

        private void RemoveMovie (Movie movie)
        {
            //Remove from array
            for (var index = 0; index < _movies.Length; ++index)
            {
                //This won't work
                if(_movies[index] == movie)
                {
                    _movies[index] = null;
                        return;
                };
            };
        }

        private Movie[] GetMovies ()
        {
            //TODO: Filter out empty movies
            var count = 0;
            foreach (var movie in _movies)
                if (movie != null)
                    ++count;

            var index = 0;
            var movies = new Movie[count];
            foreach (var movie in _movies)
                if(movie != null)
                movies[index++] = movie;

            return movies;
        }

        private Movie[] _movies = new Movie[100];

        private void _lstMovies_SelectedIndexChanged ( object sender, EventArgs e )
        {

        }
    }

}
