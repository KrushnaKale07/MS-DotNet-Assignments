
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplDay9.Models;
using WebApplDay9.Data;

public class StateController : Controller
{
    private readonly Day9DbContext _context;

    public StateController(Day9DbContext context)
    {
        _context = context;
    }

    // GET: STATES
    public async Task<IActionResult> Index()    
    {
        return View(await _context.States.ToListAsync());
    }

    // GET: STATES/Details/5
    public async Task<IActionResult> Details(int? stateid)
    {
        if (stateid == null)
        {
            return NotFound();
        }

        var state = await _context.States
            .FirstOrDefaultAsync(m => m.StateId == stateid);
        if (state == null)
        {
            return NotFound();
        }

        return View(state);
    }

    // GET: STATES/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: STATES/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("StateId,StateName,ContryId,Contry")] State state)
    {
        if (ModelState.IsValid)
        {
            _context.Add(state);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(state);
    }

    // GET: STATES/Edit/5
    public async Task<IActionResult> Edit(int? stateid)
    {
        if (stateid == null)
        {
            return NotFound();
        }

        var state = await _context.States.FindAsync(stateid);
        if (state == null)
        {
            return NotFound();
        }
        return View(state);
    }

    // POST: STATES/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? stateid, [Bind("StateId,StateName,ContryId,Contry")] State state)
    {
        if (stateid != state.StateId)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(state);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StateExists(state.StateId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }
        return View(state);
    }

    // GET: STATES/Delete/5
    public async Task<IActionResult> Delete(int? stateid)
    {
        if (stateid == null)
        {
            return NotFound();
        }

        var state = await _context.States
            .FirstOrDefaultAsync(m => m.StateId == stateid);
        if (state == null)
        {
            return NotFound();
        }

        return View(state);
    }

    // POST: STATES/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? stateid)
    {
        var state = await _context.States.FindAsync(stateid);
        if (state != null)
        {
            _context.States.Remove(state);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool StateExists(int? stateid)
    {
        return _context.States.Any(e => e.StateId == stateid);
    }
}
