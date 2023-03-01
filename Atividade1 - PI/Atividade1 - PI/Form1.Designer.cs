namespace Atividade1___PI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCima = new System.Windows.Forms.Button();
            this.btnDireita = new System.Windows.Forms.Button();
            this.btnEsquerda = new System.Windows.Forms.Button();
            this.btnBaixo = new System.Windows.Forms.Button();
            this.pnlPersonagem = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnCima
            // 
            this.btnCima.Location = new System.Drawing.Point(351, 27);
            this.btnCima.Name = "btnCima";
            this.btnCima.Size = new System.Drawing.Size(92, 37);
            this.btnCima.TabIndex = 0;
            this.btnCima.Text = "Cima";
            this.btnCima.UseVisualStyleBackColor = true;
            this.btnCima.Click += new System.EventHandler(this.btnCima_Click);
            // 
            // btnDireita
            // 
            this.btnDireita.Location = new System.Drawing.Point(647, 201);
            this.btnDireita.Name = "btnDireita";
            this.btnDireita.Size = new System.Drawing.Size(92, 39);
            this.btnDireita.TabIndex = 1;
            this.btnDireita.Text = "Direita";
            this.btnDireita.UseVisualStyleBackColor = true;
            this.btnDireita.Click += new System.EventHandler(this.btnDireita_Click);
            // 
            // btnEsquerda
            // 
            this.btnEsquerda.Location = new System.Drawing.Point(70, 200);
            this.btnEsquerda.Name = "btnEsquerda";
            this.btnEsquerda.Size = new System.Drawing.Size(92, 41);
            this.btnEsquerda.TabIndex = 2;
            this.btnEsquerda.Text = "Esquerda";
            this.btnEsquerda.UseVisualStyleBackColor = true;
            this.btnEsquerda.Click += new System.EventHandler(this.btnEsquerda_Click);
            // 
            // btnBaixo
            // 
            this.btnBaixo.Location = new System.Drawing.Point(351, 358);
            this.btnBaixo.Name = "btnBaixo";
            this.btnBaixo.Size = new System.Drawing.Size(92, 37);
            this.btnBaixo.TabIndex = 3;
            this.btnBaixo.Text = "Baixo";
            this.btnBaixo.UseVisualStyleBackColor = true;
            this.btnBaixo.Click += new System.EventHandler(this.btnBaixo_Click);
            // 
            // pnlPersonagem
            // 
            this.pnlPersonagem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlPersonagem.BackgroundImage")));
            this.pnlPersonagem.Location = new System.Drawing.Point(351, 174);
            this.pnlPersonagem.Name = "pnlPersonagem";
            this.pnlPersonagem.Size = new System.Drawing.Size(92, 66);
            this.pnlPersonagem.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(824, 461);
            this.Controls.Add(this.pnlPersonagem);
            this.Controls.Add(this.btnBaixo);
            this.Controls.Add(this.btnEsquerda);
            this.Controls.Add(this.btnDireita);
            this.Controls.Add(this.btnCima);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCima;
        private System.Windows.Forms.Button btnDireita;
        private System.Windows.Forms.Button btnEsquerda;
        private System.Windows.Forms.Button btnBaixo;
        private System.Windows.Forms.Panel pnlPersonagem;
    }
}

