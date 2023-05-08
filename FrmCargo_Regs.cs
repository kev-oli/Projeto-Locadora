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
    public partial class FrmCargo_Regs : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["locadora_2dsiem_2021"].ConnectionString;

        public FrmCargo_Regs()
        {
            InitializeComponent();
        }

        private void FrmCargo_Regs_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            string sql_select_cargo = "select * from tb_cargo";

            MySqlCommand executacmdMySql_select_cargo = new MySqlCommand(sql_select_cargo, con);
            executacmdMySql_select_cargo.ExecuteNonQuery();

            DataTable tabela_cargo = new DataTable();

            MySqlDataAdapter da_cargo = new MySqlDataAdapter(executacmdMySql_select_cargo);
            da_cargo.Fill(tabela_cargo);

            DgvListarCargos.DataSource = tabela_cargo;
            con.Close();
        }

        //private void DgvListarCargo(object sender, DataGridViewCellEventArgs e)
        //{
        //    txtId.Text = DgvListarCargos.CurrentRow.Cells[0].Value.ToString();
        //    txtNome.Text = DgvListarCargos.CurrentRow.Cells[1].Value.ToString();
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

                string sql_update_cargo = @"update tb_cargo
                                set TB_CARGO_NOME = @CARGO_NOME,
                                    TB_CARGO_STATUS = @CARGO_STATUS
                                where TB_CARGO_ID = @CARGO_ID";

                MySqlCommand executacmdMySql_update_cargo = new MySqlCommand(sql_update_cargo, con);

                executacmdMySql_update_cargo.Parameters.AddWithValue("@CARGO_ID", id);
                executacmdMySql_update_cargo.Parameters.AddWithValue("@CARGO_NOME", nome);
                executacmdMySql_update_cargo.Parameters.AddWithValue("@CARGO_STATUS", status);

                executacmdMySql_update_cargo.ExecuteNonQuery();

                string sql_select_cargo = "select * from tb_cargo where TB_CARGO_STATUS = 'ATIVO' ";

                MySqlCommand executacmdMySql_select_cargo = new MySqlCommand(sql_select_cargo, con);
                executacmdMySql_select_cargo.ExecuteNonQuery();

                DataTable tabela_cargo = new DataTable();

                MySqlDataAdapter da_cargo = new MySqlDataAdapter(executacmdMySql_select_cargo);
                da_cargo.Fill(tabela_cargo);

                DgvListarCargos.DataSource = tabela_cargo;
                //con.Close();
                //con.Close()

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

        //private void BtnDeletar_Click(object sender, EventArgs e)
        //{
        //    int id;

        //    id = int.Parse(txtId.Text);

        //    MySqlConnection con = new MySqlConnection(conexao);
        //    con.Open();

        //    string sql_delete_cargo = @"delete from tb_cargo where TB_CARGO_ID = @ID";
        //    string sql_select_cargo = "select * from tb_cargo";

        //    MySqlCommand executacmdMySql_select_cargo = new MySqlCommand(sql_select_cargo, con);
        //    executacmdMySql_select_cargo.ExecuteNonQuery();

        //    DataTable tabela_cargo = new DataTable();

        //    MySqlDataAdapter da_cargo = new MySqlDataAdapter(executacmdMySql_select_cargo);
        //    da_cargo.Fill(tabela_cargo);

        //    DgvListarCargos.DataSource = tabela_cargo;


        //    MySqlCommand executarcmdMySql_delete_cargo = new MySqlCommand(sql_delete_cargo, con);

        //    executarcmdMySql_delete_cargo.Parameters.AddWithValue("@id", id);

        //    executarcmdMySql_delete_cargo.ExecuteNonQuery();

        //    MessageBox.Show("Registro deletado!");
        //    con.Close();

        //    txtId.Clear();
        //    txtNome.Clear();
        //}

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
        private void DgvListarCargos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = DgvListarCargos.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = DgvListarCargos.CurrentRow.Cells[1].Value.ToString();
            CmbStatus.Text = DgvListarCargos.CurrentRow.Cells[2].Value.ToString();

        }


        private void BtnInativos_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();


            string sql_select_cargo = "select * from tb_cargo where tb_cargo_status = 'INATIVO' ";

            MySqlCommand executacmdMySql_select_cargo = new MySqlCommand(sql_select_cargo, con);
            executacmdMySql_select_cargo.ExecuteNonQuery();

            DataTable tabela_cargo_status = new DataTable();

            DgvListarCargos.DataSource = tabela_cargo_status;

            MySqlDataAdapter da_cargo = new MySqlDataAdapter(executacmdMySql_select_cargo);
            da_cargo.Fill(tabela_cargo_status);

            con.Close();
        }


    }
}
