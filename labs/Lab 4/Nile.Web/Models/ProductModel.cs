﻿/*
 * ITSE 1430 
 * 
 * Model for movies.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Nile.Web.Models
{
    public class ProductModel
    {
        public int Id { get; set; }

        [Required (AllowEmptyStrings = false)]
        public string Name { get; set; }

        [Required (AllowEmptyStrings = false)]
        public string Description { get; set; }

        [Range (0, Int32.MaxValue, ErrorMessage ="Price must be >= 0")]
        public decimal Price { get; set; }

        public bool IsDiscontinued { get; set; }


    }
}