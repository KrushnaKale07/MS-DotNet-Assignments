
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplDay9.Models;
using WebApplDay9.Data;

public class ContryController : Controller
{
    private readonly Day9DbContext _context;

    public ContryController(Day9DbContext context)
    {
        _context = context;
    }

    // GET: CONTRYS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.Contries.ToListAsync());
    }

    // GET: CONTRYS/Details/5
    public async Task<IActionResult> Details(int? contryid)
    {
        if (contryid == null)
        {
            return NotFound();
        }

        var contry = await _context.Contries
            .FirstOrDefaultAsync(m => m.ContryId == contryid);
        if (contry == null)
        {
            return NotFound();
        }

        return View(contry);
    }

    // GET: CONTRYS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: CONTRYS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("ContryId,ContryName")] Contry contry)
    {
        if (ModelState.IsValid)
        {
            _context.Add(contry);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(contry);
    }

    // GET: CONTRYS/Edit/5
    public async Task<IActionResult> Edit(int? contryid)
    {
        if (contryid == null)
        {
            return NotFound();
        }

        var contry = await _context.Contries.FindAsync(contryid);
        if (contry == null)
        {
            return NotFound();
        }
        return View(contry);
    }

    // POST: CONTRYS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    public async Task<IActionResult> Edit(int? contryid, [Bind("ContryId,ContryName")] Contry contry)
    {
        if (contryid != contry.ContryId)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(contry);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContryExists(contry.ContryId))
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
        return View(contry);
    }

    // GET: CONTRYS/Delete/5
    public async Task<IActionResult> Delete(int? contryid)
    {
        if (contryid == null)
        {
            return NotFound();
        }

        var contry = await _context.Contries
            .FirstOrDefaultAsync(m => m.ContryId == contryid);
        if (contry == null)
        {
            return NotFound();
        }

        return View(contry);
    }

    // POST: CONTRYS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? contryid)
    {
        var contry = await _context.Contries.FindAsync(contryid);
        if (contry != null)
        {
            _context.Contries.Remove(contry);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool ContryExists(int? contryid)
    {
        return _context.Contries.Any(e => e.ContryId == contryid);
    }
}
