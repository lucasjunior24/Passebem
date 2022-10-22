using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Passebem.Models
{
    [Table("Estado")]
    public class Estado
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string UF { get; set; }

        public List<Cidade> Cidade { get; set; }
    }
}