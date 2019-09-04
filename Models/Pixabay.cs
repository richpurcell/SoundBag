using System.Collections.Generic;
using Newtonsoft.Json;

namespace SoundBag.Models
{
    public class Pixabay
    {
        public int totalHits { get; set; }
        public PixPhoto[] hits { get; set; }
        public int total { get; set; }
    }

    public class PixPhoto
    {
        public string largeImageURL { get; set; }
        public int webformatHeight { get; set; }
        public int webformatWidth { get; set; }
        public int likes {get;set;}
        public int imageWidth {get;set;}
        public int id {get;set;}
        public int user_id {get;set;}
        public int views {get;set;}
        public int comments { get; set; }
        public string pageURL { get; set; }
        public int imageHeight { get; set; }
        public string webformatURL {get;set;}
        public string type {get;set;}
        public int previewHeight {get;set;}
        public string tags {get;set;}
        public int downloads {get;set;}
        public string user {get;set;}
        public int favorites {get;set;}
        public int imageSize {get;set;}
        public int previewWidth {get;set;}
        public string userImageURL {get;set;}
        public string previewURL {get;set;}

    }

}
