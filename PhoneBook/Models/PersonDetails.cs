using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace PhoneBook.Models
{
    public class PersonDetails
    {
      
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
        [DataType(DataType.Date)]
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
        
        public DateTime AddedOn { get; set; }
       
        public string AddedBy { get; set; }
        [Required]
        [Display(Name = " Image Path")]
        public string ImagePath { get; set; }
        [Required]
        [Display(Name = " Update On")]
        [DataType(DataType.Date)]
        public DateTime UpdateOn { get; set; }
    }
}