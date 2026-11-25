using Microsoft.AspNetCore.Mvc;
using StudyFlow.Data;
using StudyFlow.Models;

namespace StudyFlow.Controllers;

public class ModulesController : Controller
{
    private readonly StudyFlowRepository _repo;
    public ModulesController(StudyFlowRepository repo) => _repo = repo;

    public IActionResult Index() => View(_repo.GetModules());

    [HttpGet]
    public IActionResult Create() => View(new Module());

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Module module)
    {
        if (!ModelState.IsValid) return View(module);
        _repo.AddModule(module);
        TempData["Success"] = "Module added.";
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        var m = _repo.GetModule(id);
        if (m == null) return NotFound();
        return View(m);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(Module module)
    {
        if (!ModelState.IsValid) return View(module);
        _repo.UpdateModule(module);
        TempData["Success"] = "Module updated.";
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Delete(int id)
    {
        _repo.DeleteModule(id);
        TempData["Success"] = "Module deleted.";
        return RedirectToAction(nameof(Index));
    }
}
