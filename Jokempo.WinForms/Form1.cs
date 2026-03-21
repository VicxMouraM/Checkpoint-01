using System;
using System.Drawing;
using System.Windows.Forms;
using Jokempo.Core.Enums;
using Jokempo.Core.Models;
using Jokempo.Core.Services;

namespace Jokempo.WinForms
{
    public partial class Form1 : Form
    {
        private Jogador jogador;
        private Estatisticas estatisticas;
        private JokempoService service;

        public Form1()
        {
            InitializeComponent();

            estatisticas = new Estatisticas();
            service = new JokempoService();

            ConfigurarFormulario();
            ConfigurarEstilo();
            AtualizarEstatisticas();
            BloquearJogadas();
        }

        private void ConfigurarFormulario()
        {
            this.Text = "Jokempo";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(760, 520);
            this.BackColor = Color.WhiteSmoke;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Font = new Font("Segoe UI", 10);

            lblTitulo.Text = "JOKENPO";
            lblSubtitulo.Text = "Pedra, Papel e Tesoura";

            lblJogadaJogador.Text = "Sua jogada: -";
            lblJogadaComputador.Text = "Computador: -";
            lblResultado.Text = "Resultado: aguardando...";

            lblVitorias.Text = "Vitórias: 0";
            lblDerrotas.Text = "Derrotas: 0";
            lblEmpates.Text = "Empates: 0";
        }

        private void ConfigurarEstilo()
        {
            btnIniciar.BackColor = Color.SteelBlue;
            btnIniciar.ForeColor = Color.White;
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.FlatAppearance.BorderSize = 0;

            btnPedra.BackColor = Color.LightSlateGray;
            btnPedra.ForeColor = Color.White;
            btnPedra.FlatStyle = FlatStyle.Flat;
            btnPedra.FlatAppearance.BorderSize = 0;

            btnPapel.BackColor = Color.MediumSeaGreen;
            btnPapel.ForeColor = Color.White;
            btnPapel.FlatStyle = FlatStyle.Flat;
            btnPapel.FlatAppearance.BorderSize = 0;

            btnTesoura.BackColor = Color.IndianRed;
            btnTesoura.ForeColor = Color.White;
            btnTesoura.FlatStyle = FlatStyle.Flat;
            btnTesoura.FlatAppearance.BorderSize = 0;

            lblResultado.ForeColor = Color.MidnightBlue;
            lblVitorias.ForeColor = Color.Green;
            lblDerrotas.ForeColor = Color.Firebrick;
            lblEmpates.ForeColor = Color.DarkGoldenrod;
        }

        private void BloquearJogadas()
        {
            btnPedra.Enabled = false;
            btnPapel.Enabled = false;
            btnTesoura.Enabled = false;
        }

        private void LiberarJogadas()
        {
            btnPedra.Enabled = true;
            btnPapel.Enabled = true;
            btnTesoura.Enabled = true;
        }

        private void AtualizarEstatisticas()
        {
            lblVitorias.Text = $"Vitórias: {estatisticas.Vitorias}";
            lblDerrotas.Text = $"Derrotas: {estatisticas.Derrotas}";
            lblEmpates.Text = $"Empates: {estatisticas.Empates}";
        }

        private void ResetarResultadoVisual()
        {
            lblJogadaJogador.Text = "Sua jogada: -";
            lblJogadaComputador.Text = "Computador: -";
            lblResultado.Text = "Resultado: aguardando...";
            lblResultado.ForeColor = Color.MidnightBlue;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Digite o nome do jogador.");
                txtNome.Focus();
                return;
            }

            jogador = new Jogador(txtNome.Text.Trim());
            estatisticas = new Estatisticas();

            AtualizarEstatisticas();
            ResetarResultadoVisual();
            LiberarJogadas();

            lblResultado.Text = $"Jogo iniciado para {jogador.Nome}!";
        }

        private void btnPedra_Click(object sender, EventArgs e)
        {
            Jogar(Jogada.Pedra);
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            Jogar(Jogada.Papel);
        }

        private void btnTesoura_Click(object sender, EventArgs e)
        {
            Jogar(Jogada.Tesoura);
        }

        private void Jogar(Jogada jogada)
        {
            if (jogador == null)
            {
                MessageBox.Show("Inicie o jogo primeiro.");
                return;
            }

            Rodada rodada = service.Jogar(jogada, estatisticas);

            lblJogadaJogador.Text = $"Sua jogada: {rodada.JogadaJogador}";
            lblJogadaComputador.Text = $"Computador: {rodada.JogadaComputador}";
            lblResultado.Text = $"Resultado: {rodada.Resultado}";

            if (rodada.Resultado == "Vitória")
                lblResultado.ForeColor = Color.Green;
            else if (rodada.Resultado == "Derrota")
                lblResultado.ForeColor = Color.Firebrick;
            else
                lblResultado.ForeColor = Color.DarkGoldenrod;

            AtualizarEstatisticas();
        }
    }
}