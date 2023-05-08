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
    public partial class FrmMarca_Regs : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["locadora_2dsiem_2021"].ConnectionString;

        public FrmMarca_Regs()
        {
            InitializeComponent();
        }

        private void FrmMarca_Regs_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            string sql_select_marca = "select * from tb_marca";

            MySqlCommand executacmdMySql_select_marca = new MySqlCommand(sql_select_marca, con);
            executacmdMySql_select_marca.ExecuteNonQuery();

            DataTable tabela_marca = new DataTable();

            MySqlDataAdapter da_marca = new MySqlDataAdapter(executacmdMySql_select_marca);
            da_marca.Fill(tabela_marca);

            DgvListarMarcas.DataSource = tabela_marca;
            con.Close();
        }

        //private void DgvListarMarca(object sender, DataGridViewCellEventArgs e)
        //{
        //    txtId.Text = DgvListarMarcas.CurrentRow.Cells[0].Value.ToString();
        //    txtNome.Text = DgvListarMarcas.CurrentRow.Cells[1].Value.ToString();
        //}

        private void btnAtualizar(object sender, MouseEventArgs e)
        {
            try
            {
                string nome, status;
                int id;

                nome = txtNome.Text;
                id = int.Parse(txtId.Text);
                status = CmbStatus.Text;

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_update_marca = @"update tb_marca
                                set TB_MARCA_NOME = @MARCA_NOME,
                                    TB_MARCA_STATUS = @MARCA_STATUS
                                where TB_MARCA_ID = @MARCA_ID";

                MySqlCommand executacmdMySql_update_marca = new MySqlCommand(sql_update_marca, con);

                executacmdMySql_update_marca.Parameters.AddWithValue("@MARCA_ID", id);
                executacmdMySql_update_marca.Parameters.AddWithValue("@MARCA_NOME", nome);
                executacmdMySql_update_marca.Parameters.AddWithValue("@MARCA_STATUS", status);


                executacmdMySql_update_marca.ExecuteNonQuery();

                string sql_select_marca = "select * from tb_marca where TB_MARCA_STATUS = 'ATIVO' ";

                MySqlCommand executacmdMySql_select_marca = new MySqlCommand(sql_select_marca, con);
                executacmdMySql_select_marca.ExecuteNonQuery();

                DataTable tabela_marca = new DataTable();

                MySqlDataAdapter da_marca = new MySqlDataAdapter(executacmdMySql_select_marca);
                da_marca.Fill(tabela_marca);

                DgvListarMarcas.DataSource = tabela_marca;
                //con.Close();

                MessageBox.Show("Registro Atualizado!");

                con.Close();

                txtId.Clear();
                txtNome.Clear();
                CmbStatus.Text = string.Empty;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }
        }

        private void DgvListarMarcas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = DgvListarMarcas.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = DgvListarMarcas.CurrentRow.Cells[1].Value.ToString();
            CmbStatus.Text = DgvListarMarcas.CurrentRow.Cells[2].Value.ToString();
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            string sql_select_marca = "select * from tb_marca where tb_marca_status = 'INATIVO' ";

            MySqlCommand executacmdMySql_select_marca = new MySqlCommand(sql_select_marca, con);
            executacmdMySql_select_marca.ExecuteNonQuery();

            DataTable tabela_marca_status = new DataTable();

            DgvListarMarcas.DataSource = tabela_marca_status;

            MySqlDataAdapter da_marca = new MySqlDataAdapter(executacmdMySql_select_marca);
            da_marca.Fill(tabela_marca_status);

            con.Close();
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
