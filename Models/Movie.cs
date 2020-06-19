﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }


        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }


        [Display(Name = "Release Date"), DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }


        [Display(Name = "Genre")]
        //[RegularExpression(@"^[A-Z]+[a-zA-Z]*$"), Required, StringLength(30)]
        public int GenreId { get; set; } //was Genre of type string


        [Range(1, 100), DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }


        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$"), StringLength(5)]
        public string Rating { get; set; }
        

        //Display the the Image based on the URL
        [Display(Name="Image URL")]
        public string ImageUrl { get; set; }


        /*Navigation Properties*/
        public Genre Genre { get; set; }
    }
}