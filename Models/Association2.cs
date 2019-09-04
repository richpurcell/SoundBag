using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; // Add this to use [NotMapped]
namespace SoundBag.Models
{
    public class Association2
    {
        // Add Id and use [Key] as the validator
        [Key]
        public int Association2Id {get;set;}
        public int UserId {get;set;} // This is UserId
        public int FestivalId {get;set;}
        public User Attendee {get;set;}
        public Festival Event {get;set;}
    }
}