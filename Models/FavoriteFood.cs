using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FavoriteThingsAPI.Models
{
    public class FavoriteFood
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Protein { get; set; }
        public string Vegetables { get; set; }
        public string Fruit { get; set; }
        public string Grain { get; set; }
        public string Dairy { get; set; }
    }
}

