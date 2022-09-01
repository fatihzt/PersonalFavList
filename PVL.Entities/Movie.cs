using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFL.Entities
{
    public class Movie
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string DirectorName { get; set; }
        public int IMDB { get; set; }
        public string Summary { get; set; }
        public string LeadRole { get; set; }
        public Type Type { get; set; }

        public int Gate { get; set; }
    }
    public enum Type
    {
        Movie=1,
        TvSeries=2,
    }
}
