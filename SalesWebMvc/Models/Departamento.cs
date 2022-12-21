using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System.Collections.Generic;
using System;
using System.Linq;

namespace SalesWebMvc.Models
{
    [Table("Departamento")]
    public class Departamento
    {
        [Column("Departamento_Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }
        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        public ICollection<Funcionario> Funcionario { get; set; } = new List<Funcionario>();

        public Departamento()
        {

        }

        public Departamento(int id, string nome)
        {
            Id = id;
            Nome = nome;

        }

        public void AddFunc(Funcionario funcionario)
        {

            Funcionario.Add(funcionario);
        }

        public double TotalVendas(DateTime inicial, DateTime final)
        {
            return Funcionario.Sum(func => func.TotalVendas(inicial, final));

        }
    }
}
