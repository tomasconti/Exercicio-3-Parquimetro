namespace Exercício_3
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.radValor3 = new System.Windows.Forms.RadioButton();
            this.radValor2 = new System.Windows.Forms.RadioButton();
            this.radValor4 = new System.Windows.Forms.RadioButton();
            this.grpMoedas = new System.Windows.Forms.GroupBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.grpHoras = new System.Windows.Forms.GroupBox();
            this.radValor1 = new System.Windows.Forms.RadioButton();
            this.radHora1 = new System.Windows.Forms.RadioButton();
            this.radHora2 = new System.Windows.Forms.RadioButton();
            this.radHora3 = new System.Windows.Forms.RadioButton();
            this.radHora4 = new System.Windows.Forms.RadioButton();
            this.lblTexto = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblRS = new System.Windows.Forms.Label();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.btnCancela = new System.Windows.Forms.Button();
            this.lblTitulosaldo = new System.Windows.Forms.Label();
            this.lblRS2 = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblConfirma = new System.Windows.Forms.Label();
            this.grpMoedas.SuspendLayout();
            this.grpHoras.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.SystemColors.Control;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(200, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(386, 31);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "Exercício 3 - Parquímetro C#";
            // 
            // radValor3
            // 
            this.radValor3.AutoSize = true;
            this.radValor3.Location = new System.Drawing.Point(97, 19);
            this.radValor3.Name = "radValor3";
            this.radValor3.Size = new System.Drawing.Size(70, 17);
            this.radValor3.TabIndex = 15;
            this.radValor3.Text = "R$ 0.50";
            this.radValor3.UseVisualStyleBackColor = true;
            // 
            // radValor2
            // 
            this.radValor2.AutoSize = true;
            this.radValor2.Location = new System.Drawing.Point(6, 42);
            this.radValor2.Name = "radValor2";
            this.radValor2.Size = new System.Drawing.Size(70, 17);
            this.radValor2.TabIndex = 16;
            this.radValor2.Text = "R$ 0,10";
            this.radValor2.UseVisualStyleBackColor = true;
            // 
            // radValor4
            // 
            this.radValor4.AutoSize = true;
            this.radValor4.Location = new System.Drawing.Point(97, 42);
            this.radValor4.Name = "radValor4";
            this.radValor4.Size = new System.Drawing.Size(70, 17);
            this.radValor4.TabIndex = 17;
            this.radValor4.Text = "R$ 1,00";
            this.radValor4.UseVisualStyleBackColor = true;
            this.radValor4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // grpMoedas
            // 
            this.grpMoedas.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpMoedas.Controls.Add(this.radValor1);
            this.grpMoedas.Controls.Add(this.radValor4);
            this.grpMoedas.Controls.Add(this.radValor2);
            this.grpMoedas.Controls.Add(this.radValor3);
            this.grpMoedas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMoedas.Location = new System.Drawing.Point(67, 79);
            this.grpMoedas.Name = "grpMoedas";
            this.grpMoedas.Size = new System.Drawing.Size(200, 82);
            this.grpMoedas.TabIndex = 18;
            this.grpMoedas.TabStop = false;
            this.grpMoedas.Text = "Selecione a moeda";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(300, 98);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(105, 46);
            this.btnAdicionar.TabIndex = 19;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // grpHoras
            // 
            this.grpHoras.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpHoras.Controls.Add(this.radHora4);
            this.grpHoras.Controls.Add(this.radHora3);
            this.grpHoras.Controls.Add(this.radHora2);
            this.grpHoras.Controls.Add(this.radHora1);
            this.grpHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpHoras.Location = new System.Drawing.Point(67, 193);
            this.grpHoras.Name = "grpHoras";
            this.grpHoras.Size = new System.Drawing.Size(200, 65);
            this.grpHoras.TabIndex = 20;
            this.grpHoras.TabStop = false;
            this.grpHoras.Text = "Selecione as Horas";
            // 
            // radValor1
            // 
            this.radValor1.AutoSize = true;
            this.radValor1.Checked = true;
            this.radValor1.Location = new System.Drawing.Point(6, 19);
            this.radValor1.Name = "radValor1";
            this.radValor1.Size = new System.Drawing.Size(70, 17);
            this.radValor1.TabIndex = 14;
            this.radValor1.TabStop = true;
            this.radValor1.Text = "R$ 0,05";
            this.radValor1.UseVisualStyleBackColor = true;
            // 
            // radHora1
            // 
            this.radHora1.AutoSize = true;
            this.radHora1.Checked = true;
            this.radHora1.Location = new System.Drawing.Point(6, 19);
            this.radHora1.Name = "radHora1";
            this.radHora1.Size = new System.Drawing.Size(63, 17);
            this.radHora1.TabIndex = 18;
            this.radHora1.TabStop = true;
            this.radHora1.Text = "1 Hora";
            this.radHora1.UseVisualStyleBackColor = true;
            this.radHora1.CheckedChanged += new System.EventHandler(this.radHora1_CheckedChanged);
            // 
            // radHora2
            // 
            this.radHora2.AutoSize = true;
            this.radHora2.Location = new System.Drawing.Point(6, 42);
            this.radHora2.Name = "radHora2";
            this.radHora2.Size = new System.Drawing.Size(69, 17);
            this.radHora2.TabIndex = 18;
            this.radHora2.Text = "2 Horas";
            this.radHora2.UseVisualStyleBackColor = true;
            this.radHora2.CheckedChanged += new System.EventHandler(this.radHora2_CheckedChanged);
            // 
            // radHora3
            // 
            this.radHora3.AutoSize = true;
            this.radHora3.Location = new System.Drawing.Point(98, 19);
            this.radHora3.Name = "radHora3";
            this.radHora3.Size = new System.Drawing.Size(69, 17);
            this.radHora3.TabIndex = 19;
            this.radHora3.Text = "3 Horas";
            this.radHora3.UseVisualStyleBackColor = true;
            this.radHora3.CheckedChanged += new System.EventHandler(this.radHora3_CheckedChanged);
            // 
            // radHora4
            // 
            this.radHora4.AutoSize = true;
            this.radHora4.Location = new System.Drawing.Point(98, 42);
            this.radHora4.Name = "radHora4";
            this.radHora4.Size = new System.Drawing.Size(69, 17);
            this.radHora4.TabIndex = 20;
            this.radHora4.Text = "4 Horas";
            this.radHora4.UseVisualStyleBackColor = true;
            this.radHora4.CheckedChanged += new System.EventHandler(this.radHora4_CheckedChanged);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.BackColor = System.Drawing.SystemColors.Control;
            this.lblTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.ForeColor = System.Drawing.Color.Black;
            this.lblTexto.Location = new System.Drawing.Point(273, 212);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(226, 25);
            this.lblTexto.TabIndex = 21;
            this.lblTexto.Text = "Valor a ser cobrado:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.BackColor = System.Drawing.SystemColors.Control;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.Black;
            this.lblValor.Location = new System.Drawing.Point(537, 212);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(58, 25);
            this.lblValor.TabIndex = 22;
            this.lblValor.Text = "1.50";
            // 
            // lblRS
            // 
            this.lblRS.AutoSize = true;
            this.lblRS.BackColor = System.Drawing.SystemColors.Control;
            this.lblRS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRS.ForeColor = System.Drawing.Color.Black;
            this.lblRS.Location = new System.Drawing.Point(494, 212);
            this.lblRS.Name = "lblRS";
            this.lblRS.Size = new System.Drawing.Size(41, 25);
            this.lblRS.TabIndex = 23;
            this.lblRS.Text = "R$";
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.Location = new System.Drawing.Point(300, 292);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(214, 55);
            this.btnConsulta.TabIndex = 24;
            this.btnConsulta.Text = "Consulta saldo";
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnConfirma
            // 
            this.btnConfirma.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnConfirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirma.Location = new System.Drawing.Point(206, 364);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(105, 46);
            this.btnConfirma.TabIndex = 25;
            this.btnConfirma.Text = "Confirmar";
            this.btnConfirma.UseVisualStyleBackColor = false;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // btnCancela
            // 
            this.btnCancela.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCancela.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancela.Location = new System.Drawing.Point(490, 364);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(105, 46);
            this.btnCancela.TabIndex = 26;
            this.btnCancela.Text = "Cancelar";
            this.btnCancela.UseVisualStyleBackColor = false;
            this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);
            // 
            // lblTitulosaldo
            // 
            this.lblTitulosaldo.AutoSize = true;
            this.lblTitulosaldo.BackColor = System.Drawing.SystemColors.Control;
            this.lblTitulosaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulosaldo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulosaldo.Location = new System.Drawing.Point(528, 305);
            this.lblTitulosaldo.Name = "lblTitulosaldo";
            this.lblTitulosaldo.Size = new System.Drawing.Size(79, 25);
            this.lblTitulosaldo.TabIndex = 27;
            this.lblTitulosaldo.Text = "Saldo:";
            // 
            // lblRS2
            // 
            this.lblRS2.AutoSize = true;
            this.lblRS2.BackColor = System.Drawing.SystemColors.Control;
            this.lblRS2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRS2.ForeColor = System.Drawing.Color.Black;
            this.lblRS2.Location = new System.Drawing.Point(599, 305);
            this.lblRS2.Name = "lblRS2";
            this.lblRS2.Size = new System.Drawing.Size(41, 25);
            this.lblRS2.TabIndex = 28;
            this.lblRS2.Text = "R$";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.BackColor = System.Drawing.SystemColors.Control;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.ForeColor = System.Drawing.Color.Black;
            this.lblSaldo.Location = new System.Drawing.Point(646, 305);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(19, 25);
            this.lblSaldo.TabIndex = 29;
            this.lblSaldo.Text = ".";
            // 
            // lblConfirma
            // 
            this.lblConfirma.AutoSize = true;
            this.lblConfirma.BackColor = System.Drawing.SystemColors.Control;
            this.lblConfirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirma.ForeColor = System.Drawing.Color.Black;
            this.lblConfirma.Location = new System.Drawing.Point(288, 413);
            this.lblConfirma.Name = "lblConfirma";
            this.lblConfirma.Size = new System.Drawing.Size(19, 25);
            this.lblConfirma.TabIndex = 30;
            this.lblConfirma.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblConfirma);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblRS2);
            this.Controls.Add(this.lblTitulosaldo);
            this.Controls.Add(this.btnCancela);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.lblRS);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.grpHoras);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.grpMoedas);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Exercício 3";
            this.grpMoedas.ResumeLayout(false);
            this.grpMoedas.PerformLayout();
            this.grpHoras.ResumeLayout(false);
            this.grpHoras.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.RadioButton radValor3;
        private System.Windows.Forms.RadioButton radValor2;
        private System.Windows.Forms.RadioButton radValor4;
        private System.Windows.Forms.GroupBox grpMoedas;
        private System.Windows.Forms.RadioButton radValor1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.GroupBox grpHoras;
        private System.Windows.Forms.RadioButton radHora4;
        private System.Windows.Forms.RadioButton radHora3;
        private System.Windows.Forms.RadioButton radHora2;
        private System.Windows.Forms.RadioButton radHora1;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblRS;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.Label lblTitulosaldo;
        private System.Windows.Forms.Label lblRS2;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblConfirma;
    }
}

