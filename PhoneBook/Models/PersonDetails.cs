using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PhoneBook.Models
{
    public class PersonDetails
    {
        [Required]
        [Display(Name = "Person ID")]
        public int personId { get; set; }
        [Required]
        [Display(Name = " First Name")]
        public string FirstName { get; set; }
        [Display(Name = " Middle Name")]
        public string MiddleName { get; set; }
        [Required]
        [Display(Name = " Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = " Date Of Birth")]

        public DateTime dateOfBirth { get; set; }
        [Required]
        [Display(Name = " Home Address")]
        public string Homeaddress { get; set; }
        [Required]
        [Display(Name = " Home City")]
        public string HomeCity { get; set; }
        [Required]
        [Display(Name = " Facebook ID")]
        public string FacebookId { get; set; }
        [Required]
        [Display(Name = " Email ID")]
        public string EmailId { get; set; }
        [Required]
        [Display(Name = " Twitter ID")]
        public string TweeterId { get; set; }
        [Required]
        [Display(Name = " lINKED id")]
        public string LinkedInId { get; set; }
        [Required]
        [Display(Name = " Added On")]
        public DateTime AddedOn { get; set; }
        [Required]
        [Display(Name = " Added By")]
        public string AddedBy { get; set; }
        [Required]
        [Display(Name = " Image Path")]
        public string ImagePath { get; set; }
        [Required]
        [Display(Name = " Update On")]
        public DateTime UpdateOn { get; set; }
    }
}