/*
 * ITSE 1430 
 * 
 * Represents a movie instance.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nile.Web.Models
{
    public static class ProductModelExgtensions
    {
        public static ProductModel ToModel (this Product source)
        {
            if (source == null)
                return null;

            return new ProductModel () {
                Id = source.Id,
                Name = source.Name,
                Description = source.Description,
                Price = source.Price,
                IsDiscontinued = source.IsDiscontinued
            };
        }

        public static Product ToDomain ( this ProductModel source )
        {
            if (source == null)
                return null;

            return new Product () {
                Id = source.Id,
                Name = source.Name,
                Description = source.Description,
                Price = source.Price,
                IsDiscontinued = source.IsDiscontinued
            };
        }
    }

}