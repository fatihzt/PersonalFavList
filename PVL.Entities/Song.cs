using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFL.Entities
{
    public class Song
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Singer { get; set; }
        public string ReleaseDate { get; set; }
        public SongType SongType { get; set; }

    }
    public enum SongType
    {
        Rap=1,
        Indie=2,
        Pop=3,
        Jaz=4,
        Classic=5,
        RockandMetal=6,
    }
}
