using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Phonebook.Data.Models;

namespace Phonebook.Interfaces
{
   public interface IContactRepository
   {
       void Update(Contacts contact);
       Task<bool> SaveAllAsync();
       Task<IEnumerable<Contacts>> GetContactsAsync();
       Task<Contacts> GetContactByIdAsync(string Id);
       Task<Contacts> GetContactByName(string name);
   }
}
