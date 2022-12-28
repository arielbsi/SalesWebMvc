using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Data;
using SalesWebMvc.Services;
using SalesWebMvc.Models;
using SalesWebMvc.Models.ViewModels;

namespace SalesWebMvc.Controllers
{
    public class FuncionariosController : Controller
    {
        private readonly FuncionarioServices _funcionarioService;
        private readonly DepartamentoService _departamentoService;
        public FuncionariosController(FuncionarioServices funcionarioService, DepartamentoService departamentoService)
        {
            _funcionarioService = funcionarioService;
            _departamentoService= departamentoService;  
        }   

        public IActionResult Index()
        {
            var list = _funcionarioService.SelecionarTodos();   
            return View(list);
        }

        public IActionResult Create()
        {
            var departamentos =  _departamentoService.SelecionarTodos();
            var viewModel = new FuncionarioFormViewModel { Departamentos = departamentos };
            return View(viewModel);  
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Funcionario funcionario) { 
        
            _funcionarioService.Insert(funcionario);
            return RedirectToAction(nameof(Index));   
        }
    }
}
