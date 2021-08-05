using Berkshire.DAL;
using Berkshire.DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Berkshire.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReasonsController : ControllerBase
    {
        private BerkshireContext Context { get; init; }

        public ReasonsController(BerkshireContext context)
        {
            Context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<BerkshireReasoning>> Get()
        {
            return await Context.BerkshireReasons.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<BerkshireReasoning> Get(int id)
        {
            if (id <= 0)
            {
                Response.StatusCode = StatusCodes.Status404NotFound;
                return null;
            }
            
            return await Context.BerkshireReasons.FindAsync(id);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] string value)
        {
            if (string.IsNullOrEmpty(value))
                return BadRequest();

            var model = new BerkshireReasoning() { 
                Reason = value,
                Created = DateTime.UtcNow,
                Updated = DateTime.UtcNow
            };

            await Context.BerkshireReasons.AddAsync(model);
            await Context.SaveChangesAsync();

            return CreatedAtAction(nameof(ControllerContext), model);
        }

        [HttpPut("{id}")]
        public async Task<BerkshireReasoning> Put(int id, [FromBody] string reason)
        {
            if (string.IsNullOrEmpty(reason) || id <= 0)
            {
                Response.StatusCode = StatusCodes.Status400BadRequest;
                return null;
            }

            var existing = await Context.BerkshireReasons.FindAsync(id);
            if (existing != null)
            {
                existing.Reason = reason;
                existing.Updated = DateTime.UtcNow;
                await Context.SaveChangesAsync();
            }
            else
            {
                Response.StatusCode = StatusCodes.Status404NotFound;
                return null;
            }

            return existing;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            Context.Remove(await Context.BerkshireReasons.FindAsync(id));
            await Context.SaveChangesAsync();
            return Ok();
        }

        // Exception filter:
        // Problem(title: "An error occurred", detail: ex.Message, statusCode: StatusCodes.Status500InternalServerError);
    }
}
