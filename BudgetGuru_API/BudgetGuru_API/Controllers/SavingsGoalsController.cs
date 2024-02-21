using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BudgetGuru_API.Data;
using BudgetGuru_API.Models;

namespace BudgetGuru_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SavingsGoalsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SavingsGoalsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/SavingsGoals
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SavingsGoal>>> GetSavingsGoals()
        {
            return await _context.SavingsGoals.ToListAsync();
        }

        // GET: api/SavingsGoals/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SavingsGoal>> GetSavingsGoal(int id)
        {
            var savingsGoal = await _context.SavingsGoals.FindAsync(id);

            if (savingsGoal == null)
            {
                return NotFound();
            }

            return savingsGoal;
        }

        // PUT: api/SavingsGoals/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSavingsGoal(int id, SavingsGoal savingsGoal)
        {
            if (id != savingsGoal.SavingsGoalID)
            {
                return BadRequest();
            }

            _context.Entry(savingsGoal).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SavingsGoalExists(id))
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

        // POST: api/SavingsGoals
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SavingsGoal>> PostSavingsGoal(SavingsGoal savingsGoal)
        {
            _context.SavingsGoals.Add(savingsGoal);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSavingsGoal", new { id = savingsGoal.SavingsGoalID }, savingsGoal);
        }

        // DELETE: api/SavingsGoals/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSavingsGoal(int id)
        {
            var savingsGoal = await _context.SavingsGoals.FindAsync(id);
            if (savingsGoal == null)
            {
                return NotFound();
            }

            _context.SavingsGoals.Remove(savingsGoal);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SavingsGoalExists(int id)
        {
            return _context.SavingsGoals.Any(e => e.SavingsGoalID == id);
        }
    }
}
