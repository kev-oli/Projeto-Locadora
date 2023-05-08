namespace Projeto_Locadora
{
    partial class FrmFuncionario
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
            this.btnRegistrados = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.txtDtContrato = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegistrados
            // 
            this.btnRegistrados.Location = new System.Drawing.Point(655, 193);
            this.btnRegistrados.Name = "btnRegistrados";
            this.btnRegistrados.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrados.TabIndex = 43;
            this.btnRegistrados.Text = "Registrados";
            this.btnRegistrados.UseVisualStyleBackColor = true;
            this.btnRegistrados.Click += new System.EventHandler(this.btnRegistrados_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(655, 151);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 42;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label9.Location = new System.Drawing.Point(153, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 26);
            this.label9.TabIndex = 40;
            this.label9.Text = "Cargo:";
            // 
            // cmbCargo
            // 
            this.cmbCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Location = new System.Drawing.Point(236, 231);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(289, 33);
            this.cmbCargo.TabIndex = 37;
            this.cmbCargo.SelectedIndexChanged += new System.EventHandler(this.NOVO_CARGO);
            this.cmbCargo.Click += new System.EventHandler(this.Novo);
            // 
            // txtDtContrato
            // 
            this.txtDtContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtDtContrato.Location = new System.Drawing.Point(236, 193);
            this.txtDtContrato.Name = "txtDtContrato";
            this.txtDtContrato.Size = new System.Drawing.Size(289, 32);
            this.txtDtContrato.TabIndex = 36;
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtTel.Location = new System.Drawing.Point(236, 151);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(289, 32);
            this.txtTel.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.Location = new System.Drawing.Point(136, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 26);
            this.label5.TabIndex = 29;
            this.label5.Text = "Telefone:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtNome.Location = new System.Drawing.Point(236, 112);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(289, 32);
            this.txtNome.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Location = new System.Drawing.Point(54, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 26);
            this.label4.TabIndex = 27;
            this.label4.Text = "Data de Contrato:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(153, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 26);
            this.label3.TabIndex = 26;
            this.label3.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(195, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 26);
            this.label2.TabIndex = 25;
            this.label2.Text = "id:";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtId.Location = new System.Drawing.Point(236, 74);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(289, 32);
            this.txtId.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(313, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 26);
            this.label1.TabIndex = 23;
            this.label1.Text = "Funcionario";
            // 
            // FrmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegistrados);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbCargo);
            this.Controls.Add(this.txtDtContrato);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Name = "FrmFuncionario";
            this.Text = "FrmFuncionario";
            this.Load += new System.EventHandler(this.FrmFuncionario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrados;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.TextBox txtDtContrato;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
    }
}