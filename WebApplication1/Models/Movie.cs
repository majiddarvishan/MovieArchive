using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Movie:BaseModel
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public Genre Genre { get; set; }
        public DateTime Year { get; set; }
        public string Director { get; set; }
    
        public virtual ApplicationUser User { get; set; }

        public override bool IsValid()
        {
            if (string.IsNullOrEmpty(Name))
                return false;
            if (string.IsNullOrEmpty(Url))
                return false;
            return true;
        }
    }
    public enum Genre
    {
        Comedy,
        Deram,
        Epic,
        Historical,
        Action,
        Adventure,
        Documentory,
        Fantasi
    }

}