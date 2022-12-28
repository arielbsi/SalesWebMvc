using SalesWebMvc.Models;
using System.Collections.Generic;
using System.Linq;
using SalesWebMvc.Data;

namespace SalesWebMvc.Services
{
    public class FuncionarioServices
    {
        private readonly SalesWebMvcContext _context;


        public FuncionarioServices(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Funcionario> SelecionarTodos()
        {
            return _context.Funcionario.ToList();
        }


        public void Insert(Funcionario obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Funcionario ObterId(int id)
        {
            return _context.Funcionario.FirstOrDefault(obj => obj.Id == id);    

        }

        public void Remover(int id)
        {
            var obj = _context.Funcionario.Find(id);
            _context.Funcionario.Remove(obj);   

        }

    }


}
