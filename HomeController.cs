using Microsoft.AspNetCore.Mvc;
using StudyFlow.Data;
using StudyFlow.Models;

namespace StudyFlow.Controllers;

public class HomeController : Controller
{
    private readonly StudyFlowRepository _repo;
    public HomeController(StudyFlowRepository repo) => _repo = repo;

    public IActionResult Index()
    {
        var sessions = _repo.GetSessions();
        ViewBag.Modules = _repo.GetModules();
        return View(sessions);
    }
}
