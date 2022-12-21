using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System;


namespace SalesWebMvc.Models
{
    [Table("Funcionario")]
    public class Funcionario
    {
        [Column("Funcionario_Id")]
        public int Id { get; set; }
        [Column("Nome")]
        public string Nome { get; set; }
        [Column("Email")]
        public string Email { get; set; }
        [Column("Nascimento")]
        public DateTime Nascimento { get; set; }
        [Column("Base_Salarial")]
        public double BaseSalarial { get; set; }
        [Column("Departamento_Id")]
        public Departamento Departamento { get; set; }
        public ICollection<RegistroVendas> RegistroVendas = new List<RegistroVendas>();

        public Funcionario()
        {

        }

        public Funcionario(int id, string nome, string email, DateTime nascimento, double baseSalarial, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Nascimento = nascimento;
            BaseSalarial = baseSalarial;
            Departamento = departamento;
        }

        public Funcionario(string nome, string email, DateTime nascimento, double baseSalarial, Departamento departamento)
        {
           
            Nome = nome;
            Email = email;
            Nascimento = nascimento;
            BaseSalarial = baseSalarial;
            Departamento = departamento;
        }

        public void AddVenda(RegistroVendas rv)
        {

            RegistroVendas.Add(rv);

        }

        public void RemoverVenda(RegistroVendas rv)
        {

            RegistroVendas.Remove(rv);

        }

        public double TotalVendas(DateTime inicial, DateTime final)
        {
            return RegistroVendas.Where(rv => rv.Data >= inicial && rv.Data <= final).Sum(rv => rv.Quantia);

        }
    }
}
