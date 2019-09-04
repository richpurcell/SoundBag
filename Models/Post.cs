using System.ComponentModel.DataAnnotations;
using System;

namespace SoundBag.Models
{
    public class Post
    {
        public int id {get;set;}
        public int UserId {get;set;}
        [Required]
        public string PostContent {get;set;}
        public int FestivalId {get;set;}
        [DataType(DataType.DateTime)]
        public DateTime created_at {get;set;} = DateTime.Now;
        [DataType(DataType.DateTime)]
        public DateTime updated_at {get;set;} = DateTime.Now;
    }
}