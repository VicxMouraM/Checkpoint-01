namespace Jokempo.Core.Models
{
    public class Estatisticas
    {
        public int Vitorias { get; private set; }
        public int Derrotas { get; private set; }
        public int Empates { get; private set; }

        public void RegistrarVitoria()
        {
            Vitorias++;
        }

        public void RegistrarDerrota()
        {
            Derrotas++;
        }

        public void RegistrarEmpate()
        {
            Empates++;
        }
    }
}