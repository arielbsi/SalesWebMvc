using SalesWebMvc.Models.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System;

namespace SalesWebMvc.Models
{
    [Table("RegistroVendas")]
    public class RegistroVendas
    {
        [Column("Registro_Venda_Id")]
        public int Id { get; set; }
        [Column("Data")]
        public DateTime Data { get; set; }
        [Column("Quantia")]
        public double Quantia { get; set; }
        [Column("Status")]
        public StatusVendas Status { get; set; }
        [Column("Funcionario_Id")]
        public Funcionario Funcionario { get; set; }

        public RegistroVendas()
        {

        }

        public RegistroVendas(int id, DateTime data, double quantia, StatusVendas status, Funcionario funcionario)
        {
            Id = id;
            Data = data;
            Quantia = quantia;
            Status = status;
            Funcionario = funcionario;
        }
    }
}
