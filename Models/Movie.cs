using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace budget_app.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }



        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "Genre must start with a capital letter and contain only letters and spaces.")]
        [Required]
        [StringLength(30)]
        public string? Genre { get; set; }

        [Range(1, 100), DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }


        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$", ErrorMessage = "Rating must be alphanumeric and start with a capital letter.")]
        [StringLength(5, ErrorMessage = "Rating must not exceed 5 characters.")]
        [Required]
        public string Rating { get; set; } = string.Empty;
    }
}