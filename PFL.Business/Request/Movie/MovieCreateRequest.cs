using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFL.Business.Request.Movie
{
    public class MovieCreateRequest
    {
        public string Name { get; set; }
        public string DirectorName { get; set; }
        public int IMDB { get; set; }
        public string Summary { get; set; }
        public string LeadRole { get; set; }
        public Type Type { get; set; }
        public int Gate { get; set; }

    }
}
