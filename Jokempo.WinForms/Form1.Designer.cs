namespace Jokempo.WinForms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.grpJogador = new System.Windows.Forms.GroupBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.grpJogadas = new System.Windows.Forms.GroupBox();
            this.btnTesoura = new System.Windows.Forms.Button();
            this.btnPapel = new System.Windows.Forms.Button();
            this.btnPedra = new System.Windows.Forms.Button();
            this.grpResultado = new System.Windows.Forms.GroupBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblJogadaComputador = new System.Windows.Forms.Label();
            this.lblJogadaJogador = new System.Windows.Forms.Label();
            this.grpEstatisticas = new System.Windows.Forms.GroupBox();
            this.lblEmpates = new System.Windows.Forms.Label();
            this.lblDerrotas = new System.Windows.Forms.Label();
            this.lblVitorias = new System.Windows.Forms.Label();
            this.grpJogador.SuspendLayout();
            this.grpJogadas.SuspendLayout();
            this.grpResultado.SuspendLayout();
            this.grpEstatisticas.SuspendLayout();
            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitulo.Location = new System.Drawing.Point(300, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(150, 37);
            this.lblTitulo.Text = "JOKENPO";

            // lblSubtitulo
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubtitulo.Location = new System.Drawing.Point(286, 60);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(190, 19);
            this.lblSubtitulo.Text = "Pedra, Papel e Tesoura";

            // grpJogador
            this.grpJogador.Controls.Add(this.btnIniciar);
            this.grpJogador.Controls.Add(this.txtNome);
            this.grpJogador.Controls.Add(this.lblNome);
            this.grpJogador.Location = new System.Drawing.Point(30, 100);
            this.grpJogador.Name = "grpJogador";
            this.grpJogador.Size = new System.Drawing.Size(680, 90);
            this.grpJogador.Text = "Jogador";

            // lblNome
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(20, 38);
            this.lblNome.Text = "Nome:";

            // txtNome
            this.txtNome.Location = new System.Drawing.Point(80, 34);
            this.txtNome.Size = new System.Drawing.Size(380, 25);
            this.txtNome.Name = "txtNome";

            // btnIniciar
            this.btnIniciar.Location = new System.Drawing.Point(500, 32);
            this.btnIniciar.Size = new System.Drawing.Size(140, 34);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Text = "Iniciar Jogo";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);

            // grpJogadas
            this.grpJogadas.Controls.Add(this.btnTesoura);
            this.grpJogadas.Controls.Add(this.btnPapel);
            this.grpJogadas.Controls.Add(this.btnPedra);
            this.grpJogadas.Location = new System.Drawing.Point(30, 210);
            this.grpJogadas.Size = new System.Drawing.Size(680, 90);
            this.grpJogadas.Text = "Escolha sua jogada";

            // btnPedra
            this.btnPedra.Location = new System.Drawing.Point(80, 32);
            this.btnPedra.Size = new System.Drawing.Size(150, 35);
            this.btnPedra.Name = "btnPedra";
            this.btnPedra.Text = "Pedra";
            this.btnPedra.Click += new System.EventHandler(this.btnPedra_Click);

            // btnPapel
            this.btnPapel.Location = new System.Drawing.Point(265, 32);
            this.btnPapel.Size = new System.Drawing.Size(150, 35);
            this.btnPapel.Name = "btnPapel";
            this.btnPapel.Text = "Papel";
            this.btnPapel.Click += new System.EventHandler(this.btnPapel_Click);

            // btnTesoura
            this.btnTesoura.Location = new System.Drawing.Point(450, 32);
            this.btnTesoura.Size = new System.Drawing.Size(150, 35);
            this.btnTesoura.Name = "btnTesoura";
            this.btnTesoura.Text = "Tesoura";
            this.btnTesoura.Click += new System.EventHandler(this.btnTesoura_Click);

            // grpResultado
            this.grpResultado.Controls.Add(this.lblResultado);
            this.grpResultado.Controls.Add(this.lblJogadaComputador);
            this.grpResultado.Controls.Add(this.lblJogadaJogador);
            this.grpResultado.Location = new System.Drawing.Point(30, 320);
            this.grpResultado.Size = new System.Drawing.Size(325, 130);
            this.grpResultado.Text = "Resultado da rodada";

            // lblJogadaJogador
            this.lblJogadaJogador.AutoSize = true;
            this.lblJogadaJogador.Location = new System.Drawing.Point(20, 35);
            this.lblJogadaJogador.Text = "Sua jogada: -";

            // lblJogadaComputador
            this.lblJogadaComputador.AutoSize = true;
            this.lblJogadaComputador.Location = new System.Drawing.Point(20, 65);
            this.lblJogadaComputador.Text = "Computador: -";

            // lblResultado
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(20, 95);
            this.lblResultado.Text = "Resultado: aguardando...";

            // grpEstatisticas
            this.grpEstatisticas.Controls.Add(this.lblEmpates);
            this.grpEstatisticas.Controls.Add(this.lblDerrotas);
            this.grpEstatisticas.Controls.Add(this.lblVitorias);
            this.grpEstatisticas.Location = new System.Drawing.Point(385, 320);
            this.grpEstatisticas.Size = new System.Drawing.Size(325, 130);
            this.grpEstatisticas.Text = "Estatísticas";

            // lblVitorias
            this.lblVitorias.AutoSize = true;
            this.lblVitorias.Location = new System.Drawing.Point(20, 35);
            this.lblVitorias.Text = "Vitórias: 0";

            // lblDerrotas
            this.lblDerrotas.AutoSize = true;
            this.lblDerrotas.Location = new System.Drawing.Point(20, 65);
            this.lblDerrotas.Text = "Derrotas: 0";

            // lblEmpates
            this.lblEmpates.AutoSize = true;
            this.lblEmpates.Location = new System.Drawing.Point(20, 95);
            this.lblEmpates.Text = "Empates: 0";

            // Form1
            this.ClientSize = new System.Drawing.Size(760, 520);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.grpJogador);
            this.Controls.Add(this.grpJogadas);
            this.Controls.Add(this.grpResultado);
            this.Controls.Add(this.grpEstatisticas);
            this.Name = "Form1";
            this.Text = "Jokempo";

            this.grpJogador.ResumeLayout(false);
            this.grpJogador.PerformLayout();
            this.grpJogadas.ResumeLayout(false);
            this.grpResultado.ResumeLayout(false);
            this.grpResultado.PerformLayout();
            this.grpEstatisticas.ResumeLayout(false);
            this.grpEstatisticas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.GroupBox grpJogador;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox grpJogadas;
        private System.Windows.Forms.Button btnTesoura;
        private System.Windows.Forms.Button btnPapel;
        private System.Windows.Forms.Button btnPedra;
        private System.Windows.Forms.GroupBox grpResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblJogadaComputador;
        private System.Windows.Forms.Label lblJogadaJogador;
        private System.Windows.Forms.GroupBox grpEstatisticas;
        private System.Windows.Forms.Label lblEmpates;
        private System.Windows.Forms.Label lblDerrotas;
        private System.Windows.Forms.Label lblVitorias;
    }
}