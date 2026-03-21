using Jokempo.Core.Enums;

namespace Jokempo.Core.Models
{
    public class Rodada
    {
        public Jogada JogadaJogador { get; set; }
        public Jogada JogadaComputador { get; set; }
        public string Resultado { get; set; }
    }
}