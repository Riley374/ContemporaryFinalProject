using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FavoriteThingsAPI.Models
{
    public class TeamMember
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime Birthdate { get; set; }
        public string CollegeProgram { get; set; }
        public string YearInProgram { get; set; }
    }
}


