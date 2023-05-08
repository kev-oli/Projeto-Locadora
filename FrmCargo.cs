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
    public partial class FrmCargo : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["locadora_2dsiem_2021"].ConnectionString;

        public FrmCargo()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);

                string nome;
                // int id;
                nome = txtNome.Text;

                string sql_insert = @"insert into tb_cargo
                                 (
                                    TB_CARGO_NOME
                                 )
                                   values
                                 (
                                    @CARGO_NOME
                                 )";

                MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con);

                executacmdMySql_insert.Parameters.AddWithValue("@CARGO_NOME", nome);
                con.Open();
                executacmdMySql_insert.ExecuteNonQuery();

                string sql_select_cargo = "select * from tb_cargo";

                MySqlCommand executacmdMySql_select_cargo = new MySqlCommand(sql_select_cargo, con);
                executacmdMySql_select_cargo.ExecuteNonQuery();

                DataTable tabela_cargo = new DataTable();

                MySqlDataAdapter da_cargo = new MySqlDataAdapter(executacmdMySql_select_cargo);
                da_cargo.Fill(tabela_cargo);

                con.Close();
                MessageBox.Show("Cadastrado com sucesso!");

                txtId.Clear();
                txtNome.Clear();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }
        }

        private void BtnRegistrados_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmCargo_Regs FrmCargo_Regs = new FrmCargo_Regs();
            FrmCargo_Regs.ShowDialog();
            this.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmCliente FrmCliente = new FrmCliente();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmMenu FrmMenu = new FrmMenu();
            //FrmMenu.ShowDialog();
        }
    }
}
