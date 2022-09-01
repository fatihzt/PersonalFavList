using PFL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFL.Business.Request.Customer
{
    public class CustomerUpdateRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Age { get; set; }
        public GenderType Gender { get; set; }
        public string Country { get; set; }
        public string TelNo { get; set; }
    }
}
