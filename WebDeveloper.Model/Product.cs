
using System;
using System.ComponentModel.DataAnnotations;

namespace WebDeveloper.Model
{
    public class Product
    {
        public int ID { get; set; }
        [Display(Name = "Description")]
        [Required(ErrorMessage = "This Description is required")]
        public string Description { get; set; }

        public double Price { get; set; }

        public DateTime? RegistrationDate { get; set; }
    }
}
