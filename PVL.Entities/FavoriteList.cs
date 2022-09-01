using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace PFL.Entities
{
    public class FavoriteList
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("MovieId")]
        public int MovieId { get; set; }
        [ForeignKey("SongId")]
        public int SongId { get; set; }
        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }
        public virtual Movie Movie { get; set; }
        public virtual Song Song { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
