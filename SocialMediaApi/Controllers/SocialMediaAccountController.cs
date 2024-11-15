using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SocialMediaApi.Models;
using System;

namespace SocialMediaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaAccountController : ControllerBase
    {
        private readonly SocialMediaContext _context;

        public SocialMediaAccountController(SocialMediaContext context)
        {
            _context = context;
        }

        // GET: api/SocialMediaAccount
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SocialMediaAccount>>> GetAccounts()
        {
            return await _context.SocialMediaAccounts.ToListAsync();
        }

        // GET: api/SocialMediaAccount/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<SocialMediaAccount>> GetAccount(int id)
        {
            var account = await _context.SocialMediaAccounts.FindAsync(id);

            if (account == null)
            {
                return NotFound();
            }

            return account;
        }

        // POST: api/SocialMediaAccount
        [HttpPost]
        public async Task<ActionResult<SocialMediaAccount>> CreateAccount(SocialMediaAccount account)
        {
            _context.SocialMediaAccounts.Add(account);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAccount), new { id = account.SocialMediaAccountId }, account);
        }

        // PUT: api/SocialMediaAccount/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAccount(int id, SocialMediaAccount account)
        {
            if (id != account.SocialMediaAccountId)
            {
                return BadRequest();
            }

            _context.Entry(account).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AccountExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/SocialMediaAccount/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAccount(int id)
        {
            var account = await _context.SocialMediaAccounts.FindAsync(id);
            if (account == null)
            {
                return NotFound();
            }

            _context.SocialMediaAccounts.Remove(account);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AccountExists(int id)
        {
            return _context.SocialMediaAccounts.Any(e => e.SocialMediaAccountId == id);
        }
    }
}
