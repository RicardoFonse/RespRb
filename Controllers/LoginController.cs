using Microsoft.AspNetCore.Mvc;
using SenaiAlimentos.Contexts;
using SenaiAlimentos.Models;
using SenaiAlimentos.ViewModels;

namespace SenaiAlimentos.Controllers;

public class LoginController : Controller
{

    private readonly AppDbContext _context;

    public LoginController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index(){
        ViewData["TipoConta"] = "Escolha o tipo de conta";
        var niveis = _context.Niveis.ToList();
    
   
        var viewModel = new ListaNivelViewModel{Niveis = niveis};

        return View(viewModel);
    }

    }
