using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Services
{
    public class DepartamentoService
    {
        private readonly SalesWebMvcContext _context;


        public DepartamentoService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Departamento> SelecionarTodos() {
        return _context.Departamento.OrderBy(x=> x.Nome).ToList();
        }

    }
}
