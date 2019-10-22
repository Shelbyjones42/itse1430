using System;
using System.Collections.Generic;
using System.Linq;

namespace Itse1430.MovieLib
{
    /// <summary>Manages the movies in a database.</summary>
    public abstract class MovieDatabase : IMovieDatabase
    {
        public Movie Add ( Movie movie )
        {
            //TODO: Validation
            if (movie == null)
                return null;

            //if (!String.IsNullOrEmpty (movie.Validate ()))
            //var context = new ValidationContext (movie);
            //var results = movie.Validate (context);
            var results = ObjectValidator.TryValidateObject (movie);
            if (results.Count () > 0)
                return null;

            //Name must be unique
            var existing = GetByNameCore (movie.Title);
            if (existing != null)
                return null;

            return AddCore (movie);
        }

        /// <summary>Add a movie to database.</summary>
        /// <param name="movie">Movie to add.</param>
        /// <returns>Updated Movie</returns>
        public void Remove ( int id )
        {
            //TODO: Validate ID
            RemoveCore (id);
        }

        public Movie Get ( int id )
        {
            //TODO: Validate
            if (id <= 0)
                return null;

            return GetCore (id);
            // lab 2
            //var movie = FindMovie (id);
            //return movie != null ? Clone (new Movie (), movie) : null;
        }

        
        public IEnumerable<Movie> GetAll ()
        {
            return GetAllCore ();

            // Lab 2
            //foreach  (var movie in _movies)
            //{
            //    yield return Clone (new Movie (), movie);
            //}
            ////Filter out empty movies
            //var count = 0;
            //foreach (var movie in _movies)
            //    if (movie != null)
            //        ++count;


            //Using an array, the hard way
            //var index = 0;
            //var movies = new Movie[_movies.Count];
            //foreach (var movie in _movies)
            //    if (movie != null)
            //        movies[index++] = Clone (new Movie (), movie);
            //
            //return movies;
        }

        

        public void Update ( int id, Movie newMovie )
        {
            //TODO: Validate
            if (id <= 0)
                return;
            if (newMovie == null)
                return;

            //if (!String.IsNullOrEmpty (newMovie.Validate ()))
            //var context = new ValidationContext (newMovie);
            //var results = newMovie.Validate (context);
            var results = ObjectValidator.TryValidateObject (newMovie);

            if (results.Count () > 0)
                return;

            //Must be unique
            var existing = GetByNameCore (newMovie.Title);
            if (existing != null && existing.Id != id)
                return;

            UpdateCore (id, newMovie);
            // Lab 2
            //existing = FindMovie (id);
            //if (existing == null)
            //    return; //TODO: Error
            //
            ////Update existing movie
            //newMovie.Id = id;
            //Clone (existing, newMovie);
        }

        // Lab 2
        //private Movie Clone ( Movie target, Movie source )
        //{
        //    target.Id = source.Id;
        //    target.Description = source.Description;
        //    target.HasSeen = source.HasSeen;
        //    target.Rating = source.Rating;
        //    target.ReleaseYear = source.ReleaseYear;
        //    target.RunLength = source.RunLength;
        //    target.Title = source.Title;
        //
        //    return target;
        //}
        protected abstract Movie AddCore ( Movie movie );
        protected abstract Movie GetCore ( int id );
        protected abstract IEnumerable<Movie> GetAllCore ();
        protected abstract Movie GetByNameCore ( string name );
        protected abstract void RemoveCore ( int id );
        protected abstract Movie UpdateCore ( int id, Movie newMovie );
    }
}
