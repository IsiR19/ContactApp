using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Phonebook.Data.Models;
using Phonebook.Interfaces;

namespace Phonebook.Data
{
    public class ContactRepository : IContactRepository
    {
        private readonly DataContext _context;

        public ContactRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Contacts> GetContactByIdAsync(string Id)
        {
            return await _context.Contacts.FindAsync(Id);
        }

        public async Task<Contacts> GetContactByName(string name)
        {
            return await _context.Contacts.SingleOrDefaultAsync(x => x.Name == name);
        }

        public async Task<IEnumerable<Contacts>> GetContactsAsync()
        {
            return await _context.Contacts.ToListAsync();
        }

        public async Task<bool> SaveAllAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void Update(Contacts contact)
        {
            _context.Entry(contact).State = EntityState.Modified;
        }
    }
}
