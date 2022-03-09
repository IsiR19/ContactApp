using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Phonebook.Data;
using Phonebook.Data.Models;

namespace src.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactsController : ControllerBase
    {
        #region Properties
        private readonly ILogger<ContactsController> _logger;
        private readonly DataContext _context;
        #endregion

        #region Constructors
        public ContactsController(ILogger<ContactsController> logger, DataContext context
        )
        {
            _logger = logger;
            _context = context;
        }

        #endregion

        #region Methods

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Contacts>>> GetContacts()
        {
            return await _context.Contacts.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Contacts>> GetContactsById(string Id)
        {
            return await _context.Contacts.FindAsync(Id);

        }

        [HttpGet("{name}")]
        public async Task<ActionResult<IEnumerable<Contacts>>> GetContactsByName(string name)
        {
            return await _context.Contacts.ToListAsync();
        }

        #endregion

    }
}
