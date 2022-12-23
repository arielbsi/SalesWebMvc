using System.Collections.Generic;

namespace SalesWebMvc.Models.ViewModels
{
    public class FuncionarioFormViewModel
    {
        public Funcionario Funcionario { get; set; }
        public ICollection<Departamento> Departamentos { get; set; }    
    }
}
