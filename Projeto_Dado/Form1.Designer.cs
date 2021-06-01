
namespace Projeto_Dado
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dado1 = new System.Windows.Forms.PictureBox();
            this.dado2 = new System.Windows.Forms.PictureBox();
            this.jogar1 = new System.Windows.Forms.Button();
            this.jogar2 = new System.Windows.Forms.Button();
            this.jogador1 = new System.Windows.Forms.Label();
            this.jogador2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.reiniciar = new System.Windows.Forms.Button();
            this.ponto1 = new System.Windows.Forms.Label();
            this.ponto2 = new System.Windows.Forms.Label();
            this.vencedor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dado1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dado2)).BeginInit();
            this.SuspendLayout();
            // 
            // dado1
            // 
            this.dado1.Image = global::Projeto_Dado.Properties.Resources.dice0;
            this.dado1.Location = new System.Drawing.Point(226, 152);
            this.dado1.Name = "dado1";
            this.dado1.Size = new System.Drawing.Size(246, 228);
            this.dado1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dado1.TabIndex = 0;
            this.dado1.TabStop = false;
            // 
            // dado2
            // 
            this.dado2.Image = global::Projeto_Dado.Properties.Resources.dice0;
            this.dado2.Location = new System.Drawing.Point(645, 152);
            this.dado2.Name = "dado2";
            this.dado2.Size = new System.Drawing.Size(246, 228);
            this.dado2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dado2.TabIndex = 1;
            this.dado2.TabStop = false;
            // 
            // jogar1
            // 
            this.jogar1.Location = new System.Drawing.Point(240, 463);
            this.jogar1.Name = "jogar1";
            this.jogar1.Size = new System.Drawing.Size(209, 71);
            this.jogar1.TabIndex = 2;
            this.jogar1.Text = "JOGAR";
            this.jogar1.UseVisualStyleBackColor = true;
            this.jogar1.Click += new System.EventHandler(this.jogar1_Click);
            // 
            // jogar2
            // 
            this.jogar2.Location = new System.Drawing.Point(657, 463);
            this.jogar2.Name = "jogar2";
            this.jogar2.Size = new System.Drawing.Size(216, 71);
            this.jogar2.TabIndex = 3;
            this.jogar2.Text = "JOGAR";
            this.jogar2.UseVisualStyleBackColor = true;
            this.jogar2.Click += new System.EventHandler(this.jogar2_Click);
            // 
            // jogador1
            // 
            this.jogador1.AutoSize = true;
            this.jogador1.Location = new System.Drawing.Point(222, 407);
            this.jogador1.Name = "jogador1";
            this.jogador1.Size = new System.Drawing.Size(76, 20);
            this.jogador1.TabIndex = 4;
            this.jogador1.Text = "Jogador1";
            // 
            // jogador2
            // 
            this.jogador2.AutoSize = true;
            this.jogador2.Location = new System.Drawing.Point(641, 407);
            this.jogador2.Name = "jogador2";
            this.jogador2.Size = new System.Drawing.Size(76, 20);
            this.jogador2.TabIndex = 5;
            this.jogador2.Text = "Jogador2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pontos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(641, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pontos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 682);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "VENCEDOR:";
            // 
            // reiniciar
            // 
            this.reiniciar.Location = new System.Drawing.Point(381, 585);
            this.reiniciar.Name = "reiniciar";
            this.reiniciar.Size = new System.Drawing.Size(314, 61);
            this.reiniciar.TabIndex = 9;
            this.reiniciar.Text = "REINICIAR";
            this.reiniciar.UseVisualStyleBackColor = true;
            // 
            // ponto1
            // 
            this.ponto1.AutoSize = true;
            this.ponto1.Location = new System.Drawing.Point(291, 71);
            this.ponto1.Name = "ponto1";
            this.ponto1.Size = new System.Drawing.Size(18, 20);
            this.ponto1.TabIndex = 10;
            this.ponto1.Text = "0";
            // 
            // ponto2
            // 
            this.ponto2.AutoSize = true;
            this.ponto2.Location = new System.Drawing.Point(710, 71);
            this.ponto2.Name = "ponto2";
            this.ponto2.Size = new System.Drawing.Size(18, 20);
            this.ponto2.TabIndex = 11;
            this.ponto2.Text = "0";
            // 
            // vencedor
            // 
            this.vencedor.AutoSize = true;
            this.vencedor.Location = new System.Drawing.Point(346, 682);
            this.vencedor.Name = "vencedor";
            this.vencedor.Size = new System.Drawing.Size(56, 20);
            this.vencedor.TabIndex = 12;
            this.vencedor.Text = "NOME";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Dado.Properties.Resources.dicemaster;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1133, 757);
            this.ControlBox = false;
            this.Controls.Add(this.vencedor);
            this.Controls.Add(this.ponto2);
            this.Controls.Add(this.ponto1);
            this.Controls.Add(this.reiniciar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.jogador2);
            this.Controls.Add(this.jogador1);
            this.Controls.Add(this.jogar2);
            this.Controls.Add(this.jogar1);
            this.Controls.Add(this.dado2);
            this.Controls.Add(this.dado1);
            this.Name = "Form1";
            this.Text = "Projeto_Dado";
            ((System.ComponentModel.ISupportInitialize)(this.dado1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dado2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox dado1;
        private System.Windows.Forms.PictureBox dado2;
        private System.Windows.Forms.Button jogar1;
        private System.Windows.Forms.Button jogar2;
        private System.Windows.Forms.Label jogador1;
        private System.Windows.Forms.Label jogador2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button reiniciar;
        private System.Windows.Forms.Label ponto1;
        private System.Windows.Forms.Label ponto2;
        private System.Windows.Forms.Label vencedor;
    }
}

