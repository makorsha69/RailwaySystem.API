using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RailwaySystem.API.Model
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "ID will be automatically generated")]
        public int UserId { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "The train name cannot be empty.")]
        public string Name { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "The email cannot be empty.")]
        public string Email { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required(ErrorMessage = "The addressname cannot be empty.")]
        public string Address { get; set; }

        [MinLength(10, ErrorMessage = "Phone number cannot be less than 10 digits.")]
        [MaxLength(10, ErrorMessage = "Phone number cannot be more than 10 digits.")]
        public string Mobile { get; set; }

        [Column(TypeName = "varchar(25)")]
        [Required(ErrorMessage = "Password is Compulsory.")]
        public string Password { get; set; }

        [Column(TypeName = "varchar(15)")]
        public string Role { get; set; }

        public bool IsActive { get; set; }
    }
}
