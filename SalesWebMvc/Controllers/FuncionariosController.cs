using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Data;
using SalesWebMvc.Services;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers
{
    public class FuncionariosController : Controller
    {
        private readonly FuncionarioServices _funcionarioService;

        public FuncionariosController(FuncionarioServices funcionarioService)
        {
            _funcionarioService = funcionarioService;
        }   

        public IActionResult Index()
        {
            var list = _funcionarioService.SelecionarTodos();   
            return View(list);
        }

        public IActionResult Create()
        {

            return View();  
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Funcionario funcionario) { 
        
            _funcionarioService.insert(funcionario);
        return RedirectToAction(nameof(Index));   
        }
    }
}
