using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phonebook.Data.Models
{
    public class Contacts
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public List<Entry> Entries { get; set; }
    }
}
