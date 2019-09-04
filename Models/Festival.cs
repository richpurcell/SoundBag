using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
namespace SoundBag.Models
{
    public class Festival
    {
        [Key]
        public int FestivalId {get;set;}
        [Required]
        [Display(Name = "Title:")]
        public string Title {get;set;}
        [Required]
        [FutureDate]
        [DataType(DataType.Date)]
        [Display(Name = "Start Date:")]
        public DateTime StartDate {get;set;}
        [Required]
        [FutureDate]
        [DataType(DataType.Date)]
        [Display(Name = "End Date:")]
        public DateTime EndDate {get;set;}
        public string Type {get;set;}
        [Display(Name="Description:")]
        public string Description {get;set;}
        [Display(Name="Address:")]
        public string Address {get;set;}
        [Display(Name="City:")]
        public string City {get;set;}
        [Display(Name="State:")]
        public string State {get;set;}
        [Display(Name="Zip:")]
        public string ZipCode {get;set;}
        [Display(Name="Country:")]
        public string Country {get;set;}
        [Display(Name="Ticket Link:")]
        public string TicketLink {get;set;}
        [Display(Name="Lineup Link:")]
        public string LineupLink {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
        public int OrganizerId {get;set;}
        public List<Association2> Posts {get;set;}
        public List<Association> Attendees {get;set;}
        public Festival()
        {
            this.Country = "US";
            this.Type = "Music Festival";
        }
    }
    public class FutureDateAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if ((DateTime)value < DateTime.Today){
                return new ValidationResult("Date must be in the future");
            }
            return ValidationResult.Success;
        }
    }
    public class GreaterThan0Attribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if ((int)value <= 0){
                return new ValidationResult("Duration must be in greater than 0");
            }
            return ValidationResult.Success;
        }
    }
}