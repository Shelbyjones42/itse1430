﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Itse1430.MovieLib.SqlServer
{
    /// <summary> Provides a movie database backed by SQL.</summary>
    public class SqlMovieDatabase : MovieDatabase
    {
        public SqlMovieDatabase (string connectionString)
        {
            _connectionString = connectionString;
        }
        protected override Movie AddCore ( Movie movie ) => throw new NotImplementedException ();
        protected override IEnumerable<Movie> GetAllCore ()
        {
            // Create a connection and open
            var ds = new DataSet ();
            {
                using (var conn = CreateConnection ())
                
                // Create a command - option 1
                //var cmd = new SqlCommand("GetAllMovies", conn);

                // Option 2 (don't use)
                //var cmd = new SqlCommand ("GetAllMovies") { Connection = conn };

                // Option 3
                using (var cmd = conn.CreateCommand ())
                {
                    cmd.CommandText = "GetMovies";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    var da = new SqlDataAdapter () {
                        SelectCommand = cmd
                    };

                    da.Fill (ds);

                };
            };
                    var table = ds.Tables.OfType<DataTable>().FirstOrDefault ();
                    if (table != null)
                    {
                        foreach (var row in table.Rows.OfType<DataRow>())
                        {
                            var movie = new Movie () {
                                Id = (int)row[0],
                                Title = row["Name"] as string,
                                Description = row.Field<string> ("Description"),
                                Rating = row.Field<string> ("Rating"),
                                RunLength = row.Field<int>("RunLength"),
                                ReleaseYear = row.Field<int>("ReleaseYear"),
                                HasSeen = row.Field<bool>("HasSeen"),
                            };

                            yield return movie;
                        }
                    }
             
        }
        protected override Movie GetByNameCore ( string name )
        {
            return null;
        }
        protected override Movie GetCore ( int id )
        {
            return null;
        }
        protected override void RemoveCore ( int id ) => throw new NotImplementedException ();
        protected override Movie UpdateCore ( int id, Movie newMovie ) => throw new NotImplementedException ();

        private SqlConnection CreateConnection ()
        {

            var conn = new SqlConnection (_connectionString);
            conn.Open ();
            return conn;
        }

        private readonly string _connectionString;
    }
}
