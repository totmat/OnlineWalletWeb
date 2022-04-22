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
    ///[Route("api/[controller]")]
    [ApiController]
    public class IgazolvanyController : ControllerBase
    {
        private readonly onlinewalletContext _context;
        public IgazolvanyController(onlinewalletContext context)
        {
            _context = context;
        }
        //GET: api/Felhasznalok
        [HttpGet]
        [Route("api/Igazolvanyok")]
        public async Task<ActionResult<IEnumerable<igazolvany>>> GetIgazolvanyok()
        {
            return await _context.igazolvany.ToListAsync();
        }
    }
}
