using System;
using System.ComponentModel.DataAnnotations;

namespace sparkRestro.Api.Entities
{
    public class Food
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public double Discount { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [MaxLength(200)]
        public string ImagePath { get; set; }
    }
}
