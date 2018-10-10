using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneBook.Models
{
    public class contact
    {
        public string Contactid { get; set; }
        public string Contactnumber { get; set; }
        public bool PersonId { get; set; }
        public bool type { get; set; }
    }
}