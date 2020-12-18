using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ChefsNDishes.Validations;

namespace ChefsNDishes.Models
{
    public class Chef
    {
        [Key]
        public int ChefId {get;set;}

        [Required]
        public string FName {get;set;}

        [Required]
        public string LName {get;set;}

        [Required]
        [OverEighteen]
        public DateTime DateOfBirth {get;set;}

        public DateTime UpdatedAt {get;set;} = DateTime.Now;
        public DateTime CreatedAt {get;set;} = DateTime.Now;

        public List<Dish> ChefsDishes {get;set;}

    }
}