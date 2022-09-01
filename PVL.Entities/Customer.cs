 using System;
//a784390bFatih
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFL.Entities
{
    public class Customer
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Age { get; set; }
        public GenderType Gender { get; set; }
        public string Country { get; set; }
        public string TelNo { get; set; }
    }
    public enum GenderType
    {
        Female=1,
        Male=2,
        None=3,
    }
}
