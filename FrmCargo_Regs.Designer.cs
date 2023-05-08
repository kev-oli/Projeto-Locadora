namespace Projeto_Locadora
{
    partial class FrmCargo_Regs
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
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.BtnInativos = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvListarCargos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CmbStatus = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListarCargos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.BackColor = System.Drawing.Color.Brown;
            this.BtnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtualizar.Location = new System.Drawing.Point(570, 255);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(126, 46);
            this.BtnAtualizar.TabIndex = 32;
            this.BtnAtualizar.Text = "Atualizar";
            this.BtnAtualizar.UseVisualStyleBackColor = false;
            this.BtnAtualizar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAtualizar);
            // 
            // BtnInativos
            // 
            this.BtnInativos.BackColor = System.Drawing.Color.Brown;
            this.BtnInativos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInativos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInativos.Location = new System.Drawing.Point(570, 354);
            this.BtnInativos.Name = "BtnInativos";
            this.BtnInativos.Size = new System.Drawing.Size(126, 46);
            this.BtnInativos.TabIndex = 31;
            this.BtnInativos.Text = "Inativos";
            this.BtnInativos.UseVisualStyleBackColor = false;
            this.BtnInativos.Click += new System.EventHandler(this.BtnInativos_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.BackColor = System.Drawing.Color.Transparent;
            this.BtnHome.BackgroundImage = global::Projeto_Locadora.Properties.Resources.ftCasa;
            this.BtnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnHome.FlatAppearance.BorderSize = 0;
            this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHome.Location = new System.Drawing.Point(650, 12);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(46, 46);
            this.BtnHome.TabIndex = 48;
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
            this.btnCancelar.Location = new System.Drawing.Point(689, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 46);
            this.btnCancelar.TabIndex = 47;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 62);
            this.panel1.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "CARGOS REGISTRADOS";
            // 
            // DgvListarCargos
            // 
            this.DgvListarCargos.BackgroundColor = System.Drawing.Color.White;
            this.DgvListarCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListarCargos.Location = new System.Drawing.Point(38, 231);
            this.DgvListarCargos.Name = "DgvListarCargos";
            this.DgvListarCargos.Size = new System.Drawing.Size(472, 216);
            this.DgvListarCargos.TabIndex = 44;
            this.DgvListarCargos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListarCargos_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.CmbStatus);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(38, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 122);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DEPARTAMENTO";
            // 
            // CmbStatus
            // 
            this.CmbStatus.BackColor = System.Drawing.Color.Black;
            this.CmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CmbStatus.ForeColor = System.Drawing.Color.White;
            this.CmbStatus.FormattingEnabled = true;
            this.CmbStatus.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.CmbStatus.Location = new System.Drawing.Point(87, 82);
            this.CmbStatus.Name = "CmbStatus";
            this.CmbStatus.Size = new System.Drawing.Size(444, 28);
            this.CmbStatus.TabIndex = 50;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(11, 82);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 25);
            this.label15.TabIndex = 49;
            this.label15.Text = "Status:";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.Black;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.SystemColors.Info;
            this.txtNome.Location = new System.Drawing.Point(87, 47);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(444, 29);
            this.txtNome.TabIndex = 26;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.Black;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.SystemColors.Info;
            this.txtId.Location = new System.Drawing.Point(51, 14);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(480, 29);
            this.txtId.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 25);
            this.label10.TabIndex = 9;
            this.label10.Text = "ID:";
            // 
            // FrmCargo_Regs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(755, 459);
            this.Controls.Add(this.BtnHome);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DgvListarCargos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnAtualizar);
            this.Controls.Add(this.BtnInativos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCargo_Regs";
            this.Text = "FrmCargo_Regs";
            this.Load += new System.EventHandler(this.FrmCargo_Regs_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListarCargos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAtualizar;
        private System.Windows.Forms.Button BtnInativos;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvListarCargos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox CmbStatus;
    }
}