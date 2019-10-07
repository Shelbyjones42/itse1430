﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Itse1430.MovieLib.Host
{
    public partial class MovieForm : Form
    {
        //Base ctor is always called unless specified
        public MovieForm () //: base()
        {
            InitializeComponent ();
        }

        // Call default ctor first
        public MovieForm ( string title ) : this()
        {
            //Handled by ctor chaining
            //InitializeComponent ();

            Text = title;
        }

        //Must be a property...
        public Movie Movie { get; set; }

        protected override void OnLoad ( EventArgs e )
        {
            //Call base type
            //OnLoad(e);

            base.OnLoad (e);

            if  (Movie != null)
            {
                _txtName.Text = Movie.Title;
                _txtDescription.Text = Movie.Description;
                _txtReleaseYear.Text = Movie.ReleaseYear.ToString();
                _txtRunLength.Text = Movie.RunLength.ToString();
                cbRating.Text = Movie.Rating;
                chkHasSeen.Checked = Movie.HasSeen;
            };

            ValidateChildren ();
        }

        private void OnSave ( object sender, EventArgs e )
        {
            if (!ValidateChildren ())
                return;

            var movie = new Movie ();
            //Movie.set_title(_txtName.Text);
            movie.Title = _txtName.Text;
            movie.Description =  _txtDescription.Text;
            movie.ReleaseYear = GetAsInt32 (_txtReleaseYear);
            movie.RunLength = GetAsInt32 (_txtRunLength);
            movie.Rating = cbRating.Text;
            movie.HasSeen = chkHasSeen.Checked;

            //Validate
            var message = movie.Validate ();
            if (!String.IsNullOrEmpty (message))
            {
                MessageBox.Show (this, message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;    
            };

            //TODO: Save it
            Movie = movie;
            DialogResult = DialogResult.OK;
            Close ();

        }

        private int GetAsInt32 ( TextBox control)
        {
            if (Int32.TryParse (control.Text, out var result))
                return result;

            return 0;
        }

        private void BtnCancel_Click ( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close ();
        }

        private void OnValidatingName ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;

            // Name is requried
            if (control.Text == "")
            {
                e.Cancel = true;
                _errors.SetError (control, "Name is required");
            } else
            {
                _errors.SetError (control, "");
            }
        }

        private void OnValidatingReleaseYear ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;

            var value = GetAsInt32 (control);
            if (value < 1900)
            {
                e.Cancel = true;
                _errors.SetError (control, "Release Year >= 1900");
            } else
            {
                _errors.SetError (control, "");
            }

        }
        private void OnValidatigRunLength ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;

            var value = GetAsInt32 (control);
            if (value < 0)
            {
                e.Cancel = true;
                _errors.SetError (control, "Run Length must be >= 0");
            } else
            {
                _errors.SetError (control, "");
            }

        }
        private void OnValidatingRating ( object sender, CancelEventArgs e )
        {
            var control = sender as ComboBox;

            // Text is requried
            if (control.SelectedIndex == -1)
            {
                e.Cancel = true;
                _errors.SetError (control, "Rating is required");
            } else
            {
                _errors.SetError (control, "");
            }

        }
    

        }
}
