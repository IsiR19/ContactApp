using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phonebook.Data.Models
{
    public class Entry
    {
        public Guid ID { get; set; }
        public string ContactID { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }
}
