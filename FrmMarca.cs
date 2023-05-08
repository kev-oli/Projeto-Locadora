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
    public partial class FrmMarca : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["locadora_2dsiem_2021"].ConnectionString;

        public FrmMarca()
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

                string sql_insert = @"insert into tb_marca
                                 (
                                    TB_MARCA_NOME
                                 )
                                   values
                                 (
                                    @MARCA_NOME
                                 )";

                MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con);

                executacmdMySql_insert.Parameters.AddWithValue("@MARCA_NOME", nome);
                con.Open();
                executacmdMySql_insert.ExecuteNonQuery();

                string sql_select_marca = "select * from tb_marca";

                MySqlCommand executacmdMySql_select_marca = new MySqlCommand(sql_select_marca, con);
                executacmdMySql_select_marca.ExecuteNonQuery();

                DataTable tabela_marca = new DataTable();

                MySqlDataAdapter da_marca = new MySqlDataAdapter(executacmdMySql_select_marca);
                da_marca.Fill(tabela_marca);

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
            FrmMarca_Regs FrmMarca_Regs = new FrmMarca_Regs();
            FrmMarca_Regs.ShowDialog();
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
