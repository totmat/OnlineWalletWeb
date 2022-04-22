using OnlineWalletAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineWalletAPI.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class FelhasznalokController : ControllerBase
    {
        private readonly onlinewalletContext _context;

        public FelhasznalokController(onlinewalletContext context)
        {
            _context = context;
        }

        //GET: api/Felhasznalok
        [HttpGet]
        [Route("api/Felhasznalok")]
        public async Task<ActionResult<IEnumerable<felhasznalo>>> GetFelhasznalok()
        {
            return await _context.felhasznalo.ToListAsync();
        }

        //Működő api 
        //Id alapján - kitöltött adatok esetén sikeresen továbbítja az adatot az adatbázisba
        //összes adat kitöltése esetén küldi el a POST üzenetet / tesztelve RESTED google
        //PostMan - csak json adatot feltöltése lehetséges

        //POST: api/postfelhasznalok
        [HttpPost]
        [Route("api/postfelhasznalok")]
        public async Task<ActionResult<int>> PostFelhasznalok(felhasznalo felhasznalo)
        {
            _context.Add(felhasznalo);
            await _context.SaveChangesAsync();
            return felhasznalo.ID;
        }
        //DELETE: api/deletefelhasznalok
        [HttpDelete]
        [Route("api/deletefelhasznalok/{id}")]
        public async Task<IActionResult> DeleteFelhasznalok(int id)
        {
            var felhasznalok = await _context.felhasznalo.FindAsync(id);
            if (felhasznalok == null)
            {
                return NotFound();
            }
            _context.felhasznalo.Remove(felhasznalok);
            await _context.SaveChangesAsync();
            return NoContent();

        }
        private bool felhasznalokExists(int id)
        {
            return _context.felhasznalo.Any(e => e.ID == id);
        }
    }
}
