using System;
using System.ComponentModel.DataAnnotations;

namespace ChefsNDishes.Models
{
    public class Dish
    {
        [Key]
        public int DishId {get;set;}

        [Required]
        public string DishName {get;set;}

        [Required]
        public int ChefId {get;set;}

        [Required]
        public int Calories {get;set;}


        [Required]
        [Range(0, 5)]
        public int Tastiness {get;set;}

        [Required]
        public string Description {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}