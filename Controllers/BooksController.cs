using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiCrud;
using ApiCrud.Models;

namespace ApiCrud.Controllers
{
    [Route("api/book")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly TodoContext _context;

        public BooksController(TodoContext context)
        {
            _context = context;
            context.OnJeroen();
        }

        // GET: api/Books
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TblBook>>> GetTblBook()
        {
            return await _context.TblBook.ToListAsync();
        }

        // GET: api/Books/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblBook>> GetTblBook(int id)
        {
            var tblBook = await _context.TblBook.FindAsync(id);

            if (tblBook == null)
            {
                return NotFound();
            }

            return tblBook;
        }

        // PUT: api/Books/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblBook(int id, TblBook tblBook)
        {
            if (id != tblBook.BookId)
            {
                return BadRequest();
            }

            _context.Entry(tblBook).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblBookExists(id))
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

        // POST: api/Books
        [HttpPost]
        public async Task<ActionResult<TblBook>> PostTblBook(TblBook tblBook)
        {
            _context.TblBook.Add(tblBook);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblBook", new { id = tblBook.BookId }, tblBook);
        }

        // DELETE: api/Books/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TblBook>> DeleteTblBook(int id)
        {
            var tblBook = await _context.TblBook.FindAsync(id);
            if (tblBook == null)
            {
                return NotFound();
            }

            _context.TblBook.Remove(tblBook);
            await _context.SaveChangesAsync();

            return tblBook;
        }

        private bool TblBookExists(int id)
        {
            return _context.TblBook.Any(e => e.BookId == id);
        }
    }
}
