using System.ComponentModel;

namespace Passebem.Models
{
    public enum TiposDeClima
    {
        [Description("instavel")]
        instavel,
        [Description("tempestuoso")]
        tempestuoso,
        [Description("chuvoso")]
        chuvoso,
        [Description("nublado")]
        nublado,
        [Description("ensolarado")]
        ensolarado,
    }
}
