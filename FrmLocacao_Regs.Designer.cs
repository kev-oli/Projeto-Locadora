namespace Projeto_Locadora
{
    partial class FrmLocacao_Regs
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbAutomovel = new System.Windows.Forms.ComboBox();
            this.cmbFunci = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.txtDtFinal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDtInicio = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnHome = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvListarLocacoes = new System.Windows.Forms.DataGridView();
            this.BtnDeletar = new System.Windows.Forms.Button();
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarLocacoes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 69);
            this.panel1.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOCAÇÕES REGISTRADAS";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmbAutomovel);
            this.groupBox2.Controls.Add(this.cmbFunci);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cmbCliente);
            this.groupBox2.Controls.Add(this.txtDtFinal);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtDtInicio);
            this.groupBox2.Location = new System.Drawing.Point(471, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(443, 237);
            this.groupBox2.TabIndex = 69;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(17, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 26);
            this.label9.TabIndex = 90;
            this.label9.Text = "Funcionario:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(17, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 26);
            this.label7.TabIndex = 92;
            this.label7.Text = "Automovel:";
            // 
            // cmbAutomovel
            // 
            this.cmbAutomovel.BackColor = System.Drawing.Color.Black;
            this.cmbAutomovel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cmbAutomovel.ForeColor = System.Drawing.Color.White;
            this.cmbAutomovel.FormattingEnabled = true;
            this.cmbAutomovel.Location = new System.Drawing.Point(145, 145);
            this.cmbAutomovel.Name = "cmbAutomovel";
            this.cmbAutomovel.Size = new System.Drawing.Size(281, 33);
            this.cmbAutomovel.TabIndex = 91;
            // 
            // cmbFunci
            // 
            this.cmbFunci.BackColor = System.Drawing.Color.Black;
            this.cmbFunci.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cmbFunci.ForeColor = System.Drawing.Color.White;
            this.cmbFunci.FormattingEnabled = true;
            this.cmbFunci.Location = new System.Drawing.Point(152, 187);
            this.cmbFunci.Name = "cmbFunci";
            this.cmbFunci.Size = new System.Drawing.Size(274, 33);
            this.cmbFunci.TabIndex = 89;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(17, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 26);
            this.label8.TabIndex = 94;
            this.label8.Text = "Cliente:";
            // 
            // cmbCliente
            // 
            this.cmbCliente.BackColor = System.Drawing.Color.Black;
            this.cmbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cmbCliente.ForeColor = System.Drawing.Color.White;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(109, 98);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(317, 33);
            this.cmbCliente.TabIndex = 93;
            // 
            // txtDtFinal
            // 
            this.txtDtFinal.BackColor = System.Drawing.Color.Black;
            this.txtDtFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtDtFinal.ForeColor = System.Drawing.Color.White;
            this.txtDtFinal.Location = new System.Drawing.Point(137, 60);
            this.txtDtFinal.Name = "txtDtFinal";
            this.txtDtFinal.Size = new System.Drawing.Size(289, 32);
            this.txtDtFinal.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 26);
            this.label4.TabIndex = 48;
            this.label4.Text = "Data de Inicio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(14, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 26);
            this.label6.TabIndex = 57;
            this.label6.Text = "Data Final:";
            // 
            // txtDtInicio
            // 
            this.txtDtInicio.BackColor = System.Drawing.Color.Black;
            this.txtDtInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtDtInicio.ForeColor = System.Drawing.Color.White;
            this.txtDtInicio.Location = new System.Drawing.Point(171, 22);
            this.txtDtInicio.Name = "txtDtInicio";
            this.txtDtInicio.Size = new System.Drawing.Size(255, 32);
            this.txtDtInicio.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(16, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 26);
            this.label10.TabIndex = 65;
            this.label10.Text = "Status:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.BackColor = System.Drawing.SystemColors.MenuText;
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cmbStatus.ForeColor = System.Drawing.Color.White;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.cmbStatus.Location = new System.Drawing.Point(99, 148);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(327, 33);
            this.cmbStatus.TabIndex = 66;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtTipo);
            this.groupBox1.Controls.Add(this.cmbStatus);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtValor);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 210);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtTipo
            // 
            this.txtTipo.BackColor = System.Drawing.Color.Black;
            this.txtTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtTipo.ForeColor = System.Drawing.Color.White;
            this.txtTipo.Location = new System.Drawing.Point(80, 68);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(346, 32);
            this.txtTipo.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 26);
            this.label3.TabIndex = 52;
            this.label3.Text = "Tipo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 26);
            this.label5.TabIndex = 54;
            this.label5.Text = "Valor:";
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.Black;
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtValor.ForeColor = System.Drawing.Color.White;
            this.txtValor.Location = new System.Drawing.Point(90, 110);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(336, 32);
            this.txtValor.TabIndex = 55;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.Black;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtId.ForeColor = System.Drawing.Color.White;
            this.txtId.Location = new System.Drawing.Point(54, 30);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(372, 32);
            this.txtId.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 26);
            this.label2.TabIndex = 46;
            this.label2.Text = "ID:";
            // 
            // BtnHome
            // 
            this.BtnHome.BackColor = System.Drawing.Color.Transparent;
            this.BtnHome.BackgroundImage = global::Projeto_Locadora.Properties.Resources.ftCasa;
            this.BtnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnHome.FlatAppearance.BorderSize = 0;
            this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHome.Location = new System.Drawing.Point(774, 23);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(66, 76);
            this.BtnHome.TabIndex = 72;
            this.BtnHome.UseVisualStyleBackColor = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackgroundImage = global::Projeto_Locadora.Properties.Resources.ftDesligar;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(835, 30);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(79, 62);
            this.btnCancelar.TabIndex = 71;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvListarLocacoes
            // 
            this.dgvListarLocacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarLocacoes.Location = new System.Drawing.Point(37, 417);
            this.dgvListarLocacoes.Name = "dgvListarLocacoes";
            this.dgvListarLocacoes.Size = new System.Drawing.Size(747, 311);
            this.dgvListarLocacoes.TabIndex = 73;
            this.dgvListarLocacoes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListarLocacoes);
            // 
            // BtnDeletar
            // 
            this.BtnDeletar.BackColor = System.Drawing.Color.Brown;
            this.BtnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeletar.Location = new System.Drawing.Point(805, 578);
            this.BtnDeletar.Name = "BtnDeletar";
            this.BtnDeletar.Size = new System.Drawing.Size(126, 46);
            this.BtnDeletar.TabIndex = 82;
            this.BtnDeletar.Text = "Inativos";
            this.BtnDeletar.UseVisualStyleBackColor = false;
            this.BtnDeletar.Click += new System.EventHandler(this.BtnDeletar_Click);
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.BackColor = System.Drawing.Color.Brown;
            this.BtnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtualizar.Location = new System.Drawing.Point(805, 472);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(126, 46);
            this.BtnAtualizar.TabIndex = 81;
            this.BtnAtualizar.Text = "Atualizar";
            this.BtnAtualizar.UseVisualStyleBackColor = false;
            this.BtnAtualizar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAtualizar);
            // 
            // FrmLocacao_Regs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(952, 711);
            this.Controls.Add(this.BtnDeletar);
            this.Controls.Add(this.BtnAtualizar);
            this.Controls.Add(this.dgvListarLocacoes);
            this.Controls.Add(this.BtnHome);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLocacao_Regs";
            this.Text = "FrmLocacao_Regs";
            this.Load += new System.EventHandler(this.FrmLocacao_Regs_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarLocacoes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDtFinal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDtInicio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvListarLocacoes;
        private System.Windows.Forms.Button BtnDeletar;
        private System.Windows.Forms.Button BtnAtualizar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbAutomovel;
        private System.Windows.Forms.ComboBox cmbFunci;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbCliente;
    }
}