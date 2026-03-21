using System;
using Jokempo.Core.Enums;
using Jokempo.Core.Models;

namespace Jokempo.Core.Services
{
    public class JokempoService
    {
        private readonly Random random = new Random();

        public Rodada Jogar(Jogada jogadaJogador, Estatisticas estatisticas)
        {
            Jogada jogadaComputador = (Jogada)random.Next(0, 3);

            Rodada rodada = new Rodada
            {
                JogadaJogador = jogadaJogador,
                JogadaComputador = jogadaComputador,
                Resultado = ""
            };

            if (jogadaJogador == jogadaComputador)
            {
                rodada.Resultado = "Empate";
                estatisticas.RegistrarEmpate();
            }
            else if (
                (jogadaJogador == Jogada.Pedra && jogadaComputador == Jogada.Tesoura) ||
                (jogadaJogador == Jogada.Papel && jogadaComputador == Jogada.Pedra) ||
                (jogadaJogador == Jogada.Tesoura && jogadaComputador == Jogada.Papel)
            )
            {
                rodada.Resultado = "Vitória";
                estatisticas.RegistrarVitoria();
            }
            else
            {
                rodada.Resultado = "Derrota";
                estatisticas.RegistrarDerrota();
            }

            return rodada;
        }
    }
}