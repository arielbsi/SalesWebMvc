using System.ComponentModel.DataAnnotations.Schema;

namespace SalesWebMvc.Models
{
    [Table("Teste")]
    public class Teste
    {
        [Column("Funcionario_Id")]
        public int Id { get; set; }
        [Column("Nome")]
        public string Nome { get; set; }
    }
}
