using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Projeto_Locadora
{
    public partial class FrmMenu : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["locadora_2dsiem_2021"].ConnectionString;
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmCliente frmCliente = new FrmCliente();
            frmCliente.ShowDialog();
            this.Visible = true;
        }

        private void BtnModelo_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmModelo frmModelo = new FrmModelo();
            frmModelo.ShowDialog();
            this.Visible = true;
        }

        private void BtnMarca_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmMarca frmMarca = new FrmMarca();
            frmMarca.ShowDialog();
            this.Visible = true;
        }

        private void BtnCargo_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmCargo frmCargo = new FrmCargo();
            frmCargo.ShowDialog();
            this.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            //FrmMenu FrmMenu = new FrmMenu();
            //FrmMenu.ShowDialog();
        }

        private void BtnAutomovel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmAutomovel frmAutomovel = new FrmAutomovel();
            frmAutomovel.ShowDialog();
            this.Visible = true;
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmFuncionario frmFuncionario = new FrmFuncionario();
            frmFuncionario.ShowDialog();
            this.Visible = true;
        }

        private void BtnLocacao_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmLocacao frmLocacao = new FrmLocacao();
            frmLocacao.ShowDialog();
            this.Visible = true;
        }
    }
}
