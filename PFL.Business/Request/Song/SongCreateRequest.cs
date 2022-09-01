using PFL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFL.Business.Request.Song
{
    public class SongCreateRequest
    {
        public string Name { get; set; }
        public string Singer { get; set; }
        public string ReleaseDate { get; set; }
        public SongType SongType { get; set; }
    }
}
