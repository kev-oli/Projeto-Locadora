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
    public partial class FrmFuncionario_Regs : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["locadora_2dsiem_2021"].ConnectionString;

        public FrmFuncionario_Regs()
        {
            InitializeComponent();
        }

        private void FrmFuncionario_Regs_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            string sql_select_funcionario = "select * from tb_funcionario";

            MySqlCommand executacmdMySql_select_funcionario = new MySqlCommand(sql_select_funcionario, con);
            executacmdMySql_select_funcionario.ExecuteNonQuery();

            DataTable tabela_funcionario = new DataTable();

            MySqlDataAdapter da_funcionario = new MySqlDataAdapter(executacmdMySql_select_funcionario);
            da_funcionario.Fill(tabela_funcionario);

            DgvListarFuncionarios.DataSource = tabela_funcionario;
            con.Close();

            /* populando a combobox cargo*/
            //MySqlConnection con = new MySqlConnection(conexao);
            string sqlselect_cargo = "select * from tb_cargo order by tb_cargo_nome";
            MySqlDataAdapter da_cargo = new MySqlDataAdapter(sqlselect_cargo, con);
            DataTable dtResultado_cargo = new DataTable();
            da_cargo.Fill(dtResultado_cargo);

            cmbCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCargo.DataSource = dtResultado_cargo;
            cmbCargo.ValueMember = "tb_cargo_id";
            cmbCargo.DisplayMember = "tb_cargo_nome";

            /*inicia a combobox sem nenhum valor selecionado*/
            cmbCargo.SelectedItem = null;
        }

        private void BtnAtualizar(object sender, MouseEventArgs e)
        {
            try
            {
                string nome, status, cargo, telefone;
                int id_funci;
                DateTime dt_contrato;

                id_funci = int.Parse(txtId.Text);
                nome = txtNome.Text;
                telefone = txtTel.Text;
                dt_contrato = Convert.ToDateTime(txtDtContrato.Text);
                cargo = (cmbCargo.SelectedValue.ToString());
                status = cmbStatus.Text;

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();
                

                string sql_update_funcionario = @"update tb_funcionario
                                set TB_FUNCIONARIO_NOME = @FUNCIONARIO_NOME,
                                    TB_FUNCIONARIO_TEL = @FUNCIONARIO_TEL,
                                    TB_FUNCIONARIO_DT_CONTRATO = @FUNCIONARIO_DT_CONTRATO,
                                    TB_CARGO_ID = @CARGO_ID,
                                    TB_FUNCIONARIO_STATUS = @FUNCIONARIO_STATUS
                                where TB_FUNCIONARIO_ID = @FUNCIONARIO_ID";

                MySqlCommand executacmdMySql_update_funcionario = new MySqlCommand(sql_update_funcionario, con);

                executacmdMySql_update_funcionario.Parameters.AddWithValue("@FUNCIONARIO_ID", id_funci);
                executacmdMySql_update_funcionario.Parameters.AddWithValue("@FUNCIONARIO_NOME", nome);
                executacmdMySql_update_funcionario.Parameters.AddWithValue("@FUNCIONARIO_TEL", telefone);
                executacmdMySql_update_funcionario.Parameters.AddWithValue("@FUNCIONARIO_DT_CONTRATO", dt_contrato);
                executacmdMySql_update_funcionario.Parameters.AddWithValue("@CARGO_ID", cargo);
                executacmdMySql_update_funcionario.Parameters.AddWithValue("@FUNCIONARIO_STATUS", status);
                executacmdMySql_update_funcionario.ExecuteNonQuery();

                string sql_select_funcionario = "select * from tb_funcionario where TB_FUNCIONARIO_STATUS = 'ATIVO' ";

                MySqlCommand executacmdMySql_select_funcionario = new MySqlCommand(sql_select_funcionario, con);
                executacmdMySql_select_funcionario.ExecuteNonQuery();

                DataTable tabela_funcionario = new DataTable();

                MySqlDataAdapter da_funcionario = new MySqlDataAdapter(executacmdMySql_select_funcionario);
                da_funcionario.Fill(tabela_funcionario);

                DgvListarFuncionarios.DataSource = tabela_funcionario;
                //con.Close();
                //con.Close()


                MessageBox.Show("Registro Atualizado!");

                con.Close();

                txtId.Clear();
                txtNome.Clear();
                txtTel.Clear();
                txtDtContrato.Clear();
                cmbCargo.Text = string.Empty;
                cmbStatus.Text = string.Empty;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            }
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
        }

        private void btnInativos_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_select_funcionario = "select * from tb_funcionario where tb_funcionario_status = 'INATIVO' ";

                MySqlCommand executacmdMySql_select_funcionario = new MySqlCommand(sql_select_funcionario, con);
                executacmdMySql_select_funcionario.ExecuteNonQuery();

                DataTable tabela_funcionario_status = new DataTable();

                DgvListarFuncionarios.DataSource = tabela_funcionario_status;

                MySqlDataAdapter da_funcionario = new MySqlDataAdapter(executacmdMySql_select_funcionario);
                da_funcionario.Fill(tabela_funcionario_status);

                con.Close();
            } catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void DgvListarFuncionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = DgvListarFuncionarios.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = DgvListarFuncionarios.CurrentRow.Cells[1].Value.ToString();
            txtTel.Text = DgvListarFuncionarios.CurrentRow.Cells[2].Value.ToString();
            txtDtContrato.Text = DgvListarFuncionarios.CurrentRow.Cells[3].Value.ToString();
            cmbCargo.Text = DgvListarFuncionarios.CurrentRow.Cells[4].Value.ToString();
            cmbStatus.Text = DgvListarFuncionarios.CurrentRow.Cells[5].Value.ToString();
        }

    }
}
