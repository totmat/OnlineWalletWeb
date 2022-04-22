using IskolaAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IskolaAPI.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class BankkartyaController : ControllerBase
    {
        private readonly onlinewalletContext _context;

        public BankkartyaController(onlinewalletContext context)
        {
            _context = context;
        }

        //GET: api/Bankkartyak

        [HttpGet]
        [Route("api/Bankkartyak")]
        public async Task<ActionResult<IEnumerable<bankkartya>>> GetBankkartyak()
        {
            return await _context.bankkartya.ToListAsync();
        }

        //POST: api/postbankkartya
        //TODO: nem működik a bankártyák post /RESTED google
        [HttpPost]
        [Route("api/postbankkartyak")]
        public async Task<ActionResult<int>> PostBankkartyak(bankkartya bankkartya)
        {
            _context.Add(bankkartya);
            await _context.SaveChangesAsync();
            return bankkartya.ID;
        }

    }
}
