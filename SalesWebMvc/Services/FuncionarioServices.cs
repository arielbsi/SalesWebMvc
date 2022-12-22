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
    

        public void insert(Funcionario obj) {
        
        _context.Add(obj);  
            _context.SaveChanges(); 
        
        }
    
    }


}
