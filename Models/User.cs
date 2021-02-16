using System;
using System.ComponentModel.DataAnnotations;
using Form_Submission.Controllers;
namespace Form_Submission.Models
{
    public class User
    {
        [Required(ErrorMessage = "Please Enter Your First Name")]
        [Display(Name = "First Name")]
        [MinLength(2, ErrorMessage = "First Name Must Be at Least 2 Characters.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please Enter your last name")]
        [MinLength(2, ErrorMessage = "Last Name must be at least 2 characters")]
        [Display(Name = "Last Name")]
        [DataType(DataType.Text)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter your age!")]
        [Range(0, 105, ErrorMessage = "Your age must be a positive number")]
        [DataType(DataType.Text)]
        public int Age { get; set; }

        [Required(ErrorMessage = "Please Enter Your Email Address")]
        [EmailAddress(ErrorMessage = "Please Enter A Valid Email Adress")]
        [Display(Name = "Email Address")]
        [DataType (DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Create A Password at least 8 Characters in Length")]
        [MinLength(8, ErrorMessage = "Please create a password that is at least 8 characters in length!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}