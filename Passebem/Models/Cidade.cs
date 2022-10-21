using System.ComponentModel.DataAnnotations.Schema;

namespace Passebem.Models
{
    [Table("Cidade")]
    public class Cidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string EstadoId { get; set; }
    }
}