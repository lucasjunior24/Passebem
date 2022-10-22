using Passebem.Models;
using System.Collections.Generic;

namespace Passebem.ViewModel
{
    public class ClimaViewModel
    {
        public List<PrevisaoClima> CidadesMaisQuestes { get; set; }

        public List<PrevisaoClima> CidadesMaisFrias { get; set; }

        public Cidade CidadeEscolhida { get; set; }

        public List<Cidade> Cidades { get; set; }

    }
}