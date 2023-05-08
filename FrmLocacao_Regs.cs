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
    public partial class FrmLocacao_Regs : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["locadora_2dsiem_2021"].ConnectionString;

        public FrmLocacao_Regs()
        {
            InitializeComponent();
        }

        public void ListTodasLocAtiv() 
        {
            string sql_select_ativ_locacao = "select tb_locacao.TB_LOCACAO_ID as 'ID DA LOCAÇÃO', \r\n tb_locacao.TB_LOCACAO_TIPO as 'TIPO DE LOCAÇÃO', \r\n tb_locacao.TB_LOCACAO_VALOR as 'VALOR', \r\n tb_locacao.TB_LOCACAO_DT_INICIO as 'DATA DE INÍCIO', \r\n tb_locacao.TB_LOCACAO_DT_FIM as 'DATA FINAL', \r\n tb_cliente.TB_CLIENTE_NOME as 'CLIENTE', \r\n tb_funcionario.TB_FUNCIONARIO_NOME as 'FUNCIONÁRIO', \r\n tb_automovel.TB_AUTOMOVEL_NOME as 'AUTOMÓVEL', \r\n tb_locacao.TB_LOCACAO_STATUS as 'STATUS' \r\n from tb_locacao \r\n inner join tb_cliente on tb_locacao.TB_CLIENTE_ID = tb_cliente.TB_CLIENTE_ID \r\n inner join tb_funcionario on tb_locacao.TB_FUNCIONARIO_ID = tb_funcionario.TB_FUNCIONARIO_ID \r\n inner join tb_automovel on tb_locacao.TB_AUTOMOVEL_ID = tb_automovel.TB_AUTOMOVEL_ID where TB_LOCACAO_STATUS = 'ATIVO'; ";
        }

        private void FrmLocacao_Regs_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            string sql_select_locacao = @"select tb_locacao.TB_LOCACAO_ID as 'ID DA LOCAÇÃO',
                                          tb_locacao.TB_LOCACAO_TIPO as 'TIPO DE LOCAÇÃO',
                                          tb_locacao.TB_LOCACAO_VALOR as 'VALOR',
                                          tb_locacao.TB_LOCACAO_DT_INICIO as 'DATA DE INÍCIO',
                                          tb_locacao.TB_LOCACAO_DT_FIM as 'DATA FINAL',
                                          tb_cliente.TB_CLIENTE_NOME as 'CLIENTE',
                                          tb_funcionario.TB_FUNCIONARIO_NOME as 'FUNCIONÁRIO',
                                          tb_automovel.TB_AUTOMOVEL_NOME as 'AUTOMÓVEL',
                                          tb_locacao.TB_LOCACAO_STATUS as 'STATUS'
                                          from tb_locacao 
                                          inner join tb_cliente on tb_locacao.TB_CLIENTE_ID = tb_cliente.TB_CLIENTE_ID
                                          inner join tb_funcionario on tb_locacao.TB_FUNCIONARIO_ID = tb_funcionario.TB_FUNCIONARIO_ID
                                          inner join tb_automovel on tb_locacao.TB_AUTOMOVEL_ID = tb_automovel.TB_AUTOMOVEL_ID where TB_LOCACAO_STATUS = 'ATIVO';";

            MySqlCommand executacmdMySql_select_locacao = new MySqlCommand(sql_select_locacao, con);
            executacmdMySql_select_locacao.ExecuteNonQuery();

            DataTable tabela_locacao = new DataTable();

            MySqlDataAdapter da_locacao = new MySqlDataAdapter(executacmdMySql_select_locacao);
            da_locacao.Fill(tabela_locacao);

            dgvListarLocacoes.DataSource = tabela_locacao;
            con.Close();



            /* populando a combobox CLIENTE*/
            //MySqlConnection con = new MySqlConnection(conexao);
            string sqlselect_cliente = "select * from tb_cliente order by tb_cliente_nome";
            MySqlDataAdapter da_cliente = new MySqlDataAdapter(sqlselect_cliente, con);
            DataTable dtResultado_cliente = new DataTable();
            da_cliente.Fill(dtResultado_cliente);

            cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCliente.DataSource = dtResultado_cliente;
            cmbCliente.ValueMember = "tb_cliente_id";
            cmbCliente.DisplayMember = "tb_cliente_nome";


            /* populando a combobox AUTOMOVEL*/
            string sqlselect_automovel = "select * from tb_automovel order by tb_automovel_nome";
            MySqlDataAdapter da_automovel = new MySqlDataAdapter(sqlselect_automovel, con);
            DataTable dtResultado_automovel = new DataTable();
            da_automovel.Fill(dtResultado_automovel);

            cmbAutomovel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAutomovel.DataSource = dtResultado_automovel;
            cmbAutomovel.ValueMember = "tb_automovel_id";
            cmbAutomovel.DisplayMember = "tb_automovel_nome";


            /* populando a combobox FUNCIONARIO*/
            string sqlselect_funcionario = "select * from tb_funcionario order by tb_funcionario_nome";
            MySqlDataAdapter da_funcionario = new MySqlDataAdapter(sqlselect_funcionario, con);
            DataTable dtResultado_funcionario = new DataTable();
            da_funcionario.Fill(dtResultado_funcionario);

            cmbFunci.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFunci.DataSource = dtResultado_funcionario;
            cmbFunci.ValueMember = "tb_funcionario_id";
            cmbFunci.DisplayMember = "tb_funcionario_nome";


            /*inicia a combobox sem nenhum valor selecionado*/
            cmbCliente.SelectedItem = null;
            cmbAutomovel.SelectedItem = null;
            cmbFunci.SelectedItem = null;
        }

        private void btnAtualizar(object sender, MouseEventArgs e)
        {
            try
            {
                string cliente, automovel, funci, tipo, valor, status ;
                int id_locacao;
                DateTime dt_inicio;
                DateTime dt_final;

                id_locacao = int.Parse(txtId.Text);
                cliente = (cmbCliente.SelectedValue.ToString());
                automovel = (cmbAutomovel.SelectedValue.ToString());
                funci = (cmbFunci.SelectedValue.ToString());
                tipo = txtTipo.Text;
                valor = txtValor.Text;
                dt_inicio = Convert.ToDateTime(txtDtInicio.Text);
                dt_final = Convert.ToDateTime(txtDtFinal.Text);
                status = cmbStatus.Text;

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();


                string sql_update_locacao = @"update tb_locacao
                                set TB_CLIENTE_ID = @CLIENTE_ID,
                                    TB_AUTOMOVEL_ID = @AUTOMOVEL_ID,
                                    TB_FUNCIONARIO_ID = @FUNCIONARIO_ID,
                                    TB_LOCACAO_TIPO = @LOCACAO_TIPO,
                                    TB_LOCACAO_VALOR = @LOCACAO_VALOR,
                                    TB_LOCACAO_DT_INICIO = @LOCACAO_DT_INICIO,
                                    TB_LOCACAO_DT_FIM = @LOCACAO_DT_FIM,
                                    TB_LOCACAO_STATUS = @LOCACAO_STATUS
                                where TB_LOCACAO_ID = @LOCACAO_ID";

                MySqlCommand executacmdMySql_update_locacao = new MySqlCommand(sql_update_locacao, con);

                executacmdMySql_update_locacao.Parameters.AddWithValue("@LOCACAO_ID", id_locacao);
                executacmdMySql_update_locacao.Parameters.AddWithValue("@CLIENTE_ID", cliente);
                executacmdMySql_update_locacao.Parameters.AddWithValue("@AUTOMOVEL_ID", automovel);
                executacmdMySql_update_locacao.Parameters.AddWithValue("@FUNCIONARIO_ID", funci);
                executacmdMySql_update_locacao.Parameters.AddWithValue("@LOCACAO_TIPO", tipo);
                executacmdMySql_update_locacao.Parameters.AddWithValue("@LOCACAO_VALOR", valor);
                executacmdMySql_update_locacao.Parameters.AddWithValue("@LOCACAO_DT_INICIO", dt_inicio);
                executacmdMySql_update_locacao.Parameters.AddWithValue("@LOCACAO_DT_FIM", dt_final);
                executacmdMySql_update_locacao.Parameters.AddWithValue("@LOCACAO_STATUS", status);
                executacmdMySql_update_locacao.ExecuteNonQuery();

                string sql_select_locacao = @"select tb_locacao.TB_LOCACAO_ID as 'ID DA LOCAÇÃO',
                                              tb_locacao.TB_LOCACAO_TIPO as 'TIPO DE LOCAÇÃO',
                                              tb_locacao.TB_LOCACAO_VALOR as 'VALOR',
                                              tb_locacao.TB_LOCACAO_DT_INICIO as 'DATA DE INÍCIO',
                                              tb_locacao.TB_LOCACAO_DT_FIM as 'DATA FINAL',
                                              tb_cliente.TB_CLIENTE_NOME as 'CLIENTE',
                                              tb_funcionario.TB_FUNCIONARIO_NOME as 'FUNCIONÁRIO',
                                              tb_automovel.TB_AUTOMOVEL_NOME as 'AUTOMÓVEL',
                                              tb_locacao.TB_LOCACAO_STATUS as 'STATUS'
                                              from tb_locacao 
                                              inner join tb_cliente on tb_locacao.TB_CLIENTE_ID = tb_cliente.TB_CLIENTE_ID
                                              inner join tb_funcionario on tb_locacao.TB_FUNCIONARIO_ID = tb_funcionario.TB_FUNCIONARIO_ID
                                              inner join tb_automovel on tb_locacao.TB_AUTOMOVEL_ID = tb_automovel.TB_AUTOMOVEL_ID where TB_LOCACAO_STATUS = 'ATIVO'; ";

                MySqlCommand executacmdMySql_select_locacao = new MySqlCommand(sql_select_locacao, con);
                executacmdMySql_select_locacao.ExecuteNonQuery();

                DataTable tabela_locacao = new DataTable();

                MySqlDataAdapter da_locacao = new MySqlDataAdapter(executacmdMySql_select_locacao);
                da_locacao.Fill(tabela_locacao);

                dgvListarLocacoes.DataSource = tabela_locacao;
                //con.Close();
                //con.Close()


                MessageBox.Show("Registro Atualizado!");

                con.Close();

                txtId.Clear();
                cmbCliente.Text = String.Empty;
                cmbAutomovel.Text = String.Empty;
                cmbFunci.Text = String.Empty;
                txtTipo.Clear();
                txtValor.Clear();
                txtDtInicio.Clear();
                txtDtFinal.Clear();
                cmbStatus.Text = String.Empty;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            }
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_select_locacao = "select * from tb_locacao where tb_locacao_status = 'INATIVO' ";

                MySqlCommand executacmdMySql_select_locacao = new MySqlCommand(sql_select_locacao, con);
                executacmdMySql_select_locacao.ExecuteNonQuery();

                DataTable tabela_locacao_status = new DataTable();

                dgvListarLocacoes.DataSource = tabela_locacao_status;

                MySqlDataAdapter da_locacao = new MySqlDataAdapter(executacmdMySql_select_locacao);
                da_locacao.Fill(tabela_locacao_status);

                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void DgvListarLocacoes(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvListarLocacoes.CurrentRow.Cells[0].Value.ToString();
            cmbCliente.Text = dgvListarLocacoes.CurrentRow.Cells[5].Value.ToString();
            cmbAutomovel.Text = dgvListarLocacoes.CurrentRow.Cells[7].Value.ToString();
            cmbFunci.Text = dgvListarLocacoes.CurrentRow.Cells[6].Value.ToString();
            txtTipo.Text = dgvListarLocacoes.CurrentRow.Cells[1].Value.ToString();
            txtValor.Text = dgvListarLocacoes.CurrentRow.Cells[2].Value.ToString();
            txtDtInicio.Text = dgvListarLocacoes.CurrentRow.Cells[3].Value.ToString();
            txtDtFinal.Text = dgvListarLocacoes.CurrentRow.Cells[4].Value.ToString();
            cmbStatus.Text = dgvListarLocacoes.CurrentRow.Cells[8].Value.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLocacao FrmLocacao = new FrmLocacao();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmMenu FrmMenu = new FrmMenu();
        }
    }

}
