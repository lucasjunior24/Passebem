using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Passebem.Models
{
    [Table("PrevisaoClima")]
    public class PrevisaoClima
    {
        public int Id { get; set; }
        public TiposDeClima Clima { get; set; }
        public int CidadeId { get; set; }

        public Cidade Cidade { get; set; }
        public DateTime DataPrevisao { get; set; }
        public int TemperaturaMaxima { get; set; }
        public int TemperaturaMinima { get; set; }

        public void GravarDataDaSolicitacao()
        {
            DataPrevisao = DateTime.Now;
        }
    }

}


