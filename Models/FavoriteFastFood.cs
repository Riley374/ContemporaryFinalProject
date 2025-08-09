using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FavoriteThingsAPI.Models
{
    public class FavoriteFastFood
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Burgers { get; set; }
        public string Fries { get; set; }
        public string ChickenSandwich { get; set; }
        public string FriedChicken { get; set; }
        public string Pizza { get; set; }
    }
}

