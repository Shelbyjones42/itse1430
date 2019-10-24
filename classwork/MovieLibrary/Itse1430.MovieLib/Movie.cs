using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itse1430.MovieLib
{
    /// <summary>Represents movie data.</summary>
    public class Movie : IValidatableObject
    {

        public int Id { get; set; }

        /// <summary>Gets or sets the title of the movie.</summary>
        public string Title
        {
            //null coalescing
            // !String.IsNullOrEmpty(_title) ? _title : ""
            //get { return _title ?? ""; }
            get => _title ?? "";
            //set { _title = value; }
            set => _title = value;
        }

        /// <summary>Gets or sets the description of the movie.</summary>
        public string Description
        {
            get => _description ?? ""; 
            set => _description = value; 
        }

        /// <summary>Gets or sets the rating of the movie.</summary>
        public string Rating
        {
            get => _rating ?? ""; 
            set => _rating = value; 
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
        public const int ReleaseYearForColor = 1939;
        //public readonly int ReleaseYearForColor = 1939;

        /// <summary>Dermines if a movie is B&W.</summary>
        public bool IsBlackAndWhite
        
            //Calculated propterty, no backing field
            //Just calculating a value
            => ReleaseYear <= ReleaseYearForColor; 
            
            //Not settable by anyone
            //set { }
        

        //Mixed accessibility - property must be most visible
        public string TestAccessibility
        {
            //Single accessor can be more restictive
            get =>  ""; 

            //Not writable outside class
            private set { }
        }

        public override string ToString ()
            =>  $"{Title} ({ReleaseYear})";
        //{
        //    return
        //}

        

       /// <summary>Validates the movie.</summary>
       /// <returns>An error message if validation fails or empty string otherwise.</returns>
        //public string Validate ()
        //{
        //    // this is implicit first parameter, represents instance
        //    //var title = "";
        //
        //    //Name is required
        //    if (String.IsNullOrEmpty (this.Title))
        //        return "Title is Required";
        //
        //    //Release year >= 1900
        //    if (ReleaseYear < 1900)
        //        return "Release Year must be >= 1900";
        //
        //    // Runlength >= 0
        //    if (RunLength < 0)
        //        return "Run Length must be >= 0";
        //
        //    //Rating is required
        //    if (String.IsNullOrEmpty (Rating))
        //        return "Rating is required";
        //    return "";
        //}

        public IEnumerable<ValidationResult> Validate ( ValidationContext validationContext )
        {
            //Iterator syntax
            //var results = new List<ValidationResult> ();

            //Name is required
            if (String.IsNullOrEmpty (Title))
                //results.Add(new ValidationResult( "Title is Required"));
                yield return new ValidationResult ("Title is Required");

            //Release year >= 1900
            if (ReleaseYear < 1900)
                //results.Add (new ValidationResult ("Release Year must be >= 1900"));
                yield return new ValidationResult ("Release Year must be >= 1900");

            // Runlength >= 0
            if (RunLength < 0)
                //results.Add (new ValidationResult ("Run Length must be >= 0"));
                yield return new ValidationResult ("Run Length must be >= 0");

            //Rating is required
            if (String.IsNullOrEmpty (Rating))
                //results.Add (new ValidationResult("Rating is required"));
                yield return new ValidationResult ("Rating is required");
            

            //return results;
        }
        // Can new up other objects
        // Can't use with the fields above 
        //private Movie orginalMovie = new Movie ();
        
        // Fields - data to be stored
        // TODO: Never make fields public!!
        private string _title = "";
        private string _description = "";
        private string _rating = "";

        //private int _releaseYear = 1900;
        //private bool _hasSeen;
        //private int _runLength;
        //private readonly int _releaseYearForColo = 1938;

    }
}       
           