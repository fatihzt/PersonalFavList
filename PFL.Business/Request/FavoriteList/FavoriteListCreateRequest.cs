using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFL.Business.Request.FavoriteList
{
    public class FavoriteListCreateRequest
    {
        public int MovieId { get; set; }
        public int SongId { get; set; }
        public int CustomerId { get; set; }

    }
}
