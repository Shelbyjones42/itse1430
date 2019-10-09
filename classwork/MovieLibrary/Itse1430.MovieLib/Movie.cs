using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itse1430.MovieLib
{
    /// <summary>Represents movie data.</summary>
    public class Movie
    {

        public int Id { get; set; }

        /// <summary>Gets or sets the title of the movie.</summary>
        public string Title
        {
            //null coalescing
            // !String.IsNullOrEmpty(_title) ? _title : ""
            get { return _title ?? ""; }
            set { _title = value; }
        }

        /// <summary>Gets or sets the description of the movie.</summary>
        public string Description
        {
            get { return _description ?? ""; }
            set { _description = value; }
        }

        /// <summary>Gets or sets the rating of the movie.</summary>
        public string Rating
        {
            get { return _rating ?? ""; }
            set { _rating = value; }
        }

        /// <summary>Gets or sets the release year of the movie.</summary>
        public int ReleaseYear { get; set; } = 1900; // Auto Property
        
        //Full property
        //public int ReleaseYear
        //{
        //      get { return _releaseyear; }
        //      set { _releaseYear = value; }
        //}

        /// <summary>Gets or sets the run length of the movie.</summary>
        public int RunLength { get; set; }
        //{
        //  get { return _runLength; }
        //  set { _runLength = value; }
        ///}

        public bool HasSeen { get; set; }
        //{
        //  get { return _hasSeen; }
        //  set { _hasSeen = value; }
        //}

        //Value is 1939, read only, and public
        //public int ReleaseYearForColor { get; } = 1939;

        //Constant field
        //public const int ReleaseYearForColor = 1939;
        public readonly int ReleaseYearForColor = 1939;

        /// <summary>Dermines if a movie is B&W.</summary>
        public bool IsBlackAndWhite
        {
            //Calculated propterty, no backing field
            //Just calculating a value
            get { return ReleaseYear <= ReleaseYearForColor; }
            
            //Not settable by anyone
            //set { }
        }

        //Mixed accessibility - property must be most visible
        public string TestAccessibility
        {
            //Single accessor can be more restictive
            get { return ""; }

            //Not writable outside class
            private set { }
        }

        public override string ToString ()
        {
            return $"{Title} ({ReleaseYear})";
        }

        // Fields - data to be stored
        // TODO: Never make fields public!!
        private string _title = "";
        private string _description = "";
        private int _releaseYear = 1900;
        private string _rating = "";
        private bool _hasSeen;
        private int _runLength;

       /// <summary>Validates the movie.</summary>
       /// <returns>An error message if validation fails or empty string otherwise.</returns>
        public string Validate ()
        {
            // this is implicit first parameter, represents instance
            var title = "";

            //Name is required
            if (String.IsNullOrEmpty (this.Title))
                return "Title is Required";

            //Release year >= 1900
            if (ReleaseYear < 1900)
                return "Release Year must be >= 1900";

            // Runlength >= 0
            if (RunLength < 0)
                return "Run Length must be >= 0";

            //Rating is required
            if (String.IsNullOrEmpty (Rating))
                return "Rating is required";
            return "";

        }
        // Can new up other objects
        // Can't use with the fields above 
        //private Movie orginalMovie = new Movie ();
    }   
}       
           