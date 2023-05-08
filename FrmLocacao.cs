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
    public partial class FrmLocacao : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["locadora_2dsiem_2021"].ConnectionString;
        public FrmLocacao()
        {
            InitializeComponent();
        }

        private void FrmLocacao_Load(object sender, EventArgs e)
        {
            /* populando a combobox funcionario*/
            MySqlConnection con = new MySqlConnection(conexao);
            string sqlselect_funcionario = "select * from tb_funcionario order by tb_funcionario_nome";
            MySqlDataAdapter da_funcionario = new MySqlDataAdapter(sqlselect_funcionario, con);
            DataTable dtResultado_funcionario = new DataTable();
            da_funcionario.Fill(dtResultado_funcionario);

            cmbFunci.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFunci.DataSource = dtResultado_funcionario;
            cmbFunci.ValueMember = "tb_funcionario_id";
            cmbFunci.DisplayMember = "tb_funcionario_nome";

            /*inicia a combobox sem nenhum valor selecionado*/
            cmbFunci.SelectedItem = null;


            //criar novo como ultomo item, configurar no click se for '= novo'

            /* populando a combobox cliente*/
            string sqlselect_cliente = "select * from tb_cliente order by tb_cliente_nome";
            MySqlDataAdapter da_cliente = new MySqlDataAdapter(sqlselect_cliente, con);
            DataTable dtResultado_cliente = new DataTable();
            da_cliente.Fill(dtResultado_cliente);

            cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCliente.DataSource = dtResultado_cliente;
            cmbCliente.ValueMember = "tb_cliente_id";
            cmbCliente.DisplayMember = "tb_cliente_nome";

            /*inicia a combobox sem nenhum valor selecionado*/
            cmbCliente.SelectedItem = null;





            /* populando a combobox automovel*/
            string sqlselect_automovel = "select * from tb_automovel order by tb_automovel_nome";
            MySqlDataAdapter da_automovel = new MySqlDataAdapter(sqlselect_automovel, con);
            DataTable dtResultado_automovel = new DataTable();
            da_automovel.Fill(dtResultado_automovel);

            cmbAutomovel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAutomovel.DataSource = dtResultado_automovel;
            cmbAutomovel.ValueMember = "tb_automovel_id";
            cmbAutomovel.DisplayMember = "tb_automovel_nome";


            /*inicia a combobox sem nenhum valor selecionado*/
            cmbAutomovel.SelectedItem = null;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);

                double valor;
                int id_cliente, id_funcionario, id_automovel;
                DateTime dt_fim, dt_inicio;
                string tipo;
                // int id;
                //nome = txtNome.Text;
                tipo = txtTipo.Text;
                valor = double.Parse(txtValor.Text);
                //id_loc = int.Parse(txtId.Text);
                id_automovel = int.Parse(cmbAutomovel.SelectedValue.ToString());
                id_cliente = int.Parse(cmbCliente.SelectedValue.ToString());
                id_funcionario = int.Parse(cmbFunci.SelectedValue.ToString());
                dt_inicio = Convert.ToDateTime(txtDtInicio.Text);
                dt_fim = Convert.ToDateTime(txtDtFinal.Text);

                string sql_insert = @"insert into tb_locacao
                                 (
                                    TB_LOCACAO_TIPO,
                                    TB_LOCACAO_DT_INICIO,
                                    TB_LOCACAO_DT_FIM,
                                    TB_LOCACAO_VALOR,   
                                    TB_FUNCIONARIO_ID,
                                    TB_CLIENTE_ID,
                                    TB_AUTOMOVEL_ID
                                 )
                                   values
                                 (
                                    @TB_LOCACAO_TIPO,
                                    @TB_LOCACAO_DT_INICIO,
                                    @TB_LOCACAO_DT_FIM,
                                    @TB_LOCACAO_VALOR,
                                    @TB_FUNCIONARIO_ID,
                                    @TB_CLIENTE_ID,
                                    @TB_AUTOMOVEL_ID
                                 )";

                MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con);

                executacmdMySql_insert.Parameters.AddWithValue("TB_LOCACAO_TIPO", tipo);
                executacmdMySql_insert.Parameters.AddWithValue("TB_LOCACAO_DT_INICIO", dt_inicio);
                executacmdMySql_insert.Parameters.AddWithValue("TB_LOCACAO_DT_FIM", dt_fim);
                executacmdMySql_insert.Parameters.AddWithValue("TB_LOCACAO_VALOR", valor);
                executacmdMySql_insert.Parameters.AddWithValue("TB_FUNCIONARIO_ID",id_funcionario );
                executacmdMySql_insert.Parameters.AddWithValue("TB_CLIENTE_ID", id_cliente);
                executacmdMySql_insert.Parameters.AddWithValue("TB_AUTOMOVEL_ID", id_automovel);
                con.Open();
                executacmdMySql_insert.ExecuteNonQuery();

                string sql_select_locacao = "select * from tb_locacao";

                MySqlCommand executacmdMySql_select_locacao = new MySqlCommand(sql_select_locacao, con);
                executacmdMySql_select_locacao.ExecuteNonQuery();

                DataTable tabela_locacao = new DataTable();

                MySqlDataAdapter da_locacao = new MySqlDataAdapter(executacmdMySql_select_locacao);
                da_locacao.Fill(tabela_locacao);

                con.Close();
                MessageBox.Show("Cadastrado com sucesso!");

                //txtId.Clear();
                //txtNome.Clear();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }

        }

        private void btnRegistrados_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmLocacao_Regs frmLocacao_Regs = new FrmLocacao_Regs();
            frmLocacao_Regs.ShowDialog();
            this.Visible = true;
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmCliente FrmCliente = new FrmCliente();
        }

        private void BtnHome_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmMenu FrmMenu = new FrmMenu();
            //FrmMenu.ShowDialog();

        }

        //private void NOVO_CLIENTE(object sender, EventArgs e)
        //{
        //    string novo_cliente;

        //    novo_cliente = cmbCliente.Text;

        //    if (novo_cliente == "NOVO")
        //    {
        //        this.Visible = false;
        //        FrmCliente FrmCliente = new FrmCliente();
        //        FrmCliente.ShowDialog();
        //        this.Visible = true;

        //        if (this.Visible == true)
        //        {
        //            /* populando a combobox cliente*/
        //            MySqlConnection con = new MySqlConnection(conexao);
        //            con.Open();
        //            string sqlselect_cliente = "select * from tb_cliente order by tb_cliente_nome";
        //            MySqlDataAdapter da_cliente = new MySqlDataAdapter(sqlselect_cliente, con);
        //            DataTable dtResultado_cliente = new DataTable();
        //            da_cliente.Fill(dtResultado_cliente);

        //            cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
        //            cmbCliente.DataSource = dtResultado_cliente;
        //            cmbCliente.ValueMember = "tb_cliente_id";
        //            cmbCliente.DisplayMember = "tb_cliente_nome";

        //            /*inicia a combobox sem nenhum valor selecionado*/
        //            cmbCliente.SelectedItem = null;

        //            con.Close();

        //        }
        //    }
        //}

        //private void NOVO_AUTOMOVEL(object sender, EventArgs e)
        //{
        //    string novo_automovel;

        //    novo_automovel = cmbAutomovel.Text;

        //    if (novo_automovel == "NOVO")
        //    {
        //        this.Visible = false;
        //        FrmAutomovel FrmAutomovel = new FrmAutomovel();
        //        FrmAutomovel.ShowDialog();
        //        this.Visible = true;

        //        if (this.Visible == true)
        //        {
        //            /* populando a combobox automovel*/
        //            MySqlConnection con = new MySqlConnection(conexao);
        //            con.Open();
        //            string sqlselect_automovel = "select * from tb_automovel order by tb_automovel_nome";
        //            MySqlDataAdapter da_automovel = new MySqlDataAdapter(sqlselect_automovel, con);
        //            DataTable dtResultado_automovel = new DataTable();
        //            da_automovel.Fill(dtResultado_automovel);

        //            cmbAutomovel.DropDownStyle = ComboBoxStyle.DropDownList;
        //            cmbAutomovel.DataSource = dtResultado_automovel;
        //            cmbAutomovel.ValueMember = "tb_automovel_id";
        //            cmbAutomovel.DisplayMember = "tb_automovel_nome";


        //            /*inicia a combobox sem nenhum valor selecionado*/
        //            cmbAutomovel.SelectedItem = null;

        //            con.Close();

        //        }
        //    }
        //}

        //private void NOVO_FUNCI(object sender, EventArgs e)
        //{
        //    string novo_funci;

        //    novo_funci = cmbFunci.Text;

        //    if (novo_funci == "NOVO")
        //    {
        //        this.Visible = false;
        //        FrmFuncionario FrmFuncionario = new FrmFuncionario();
        //        FrmFuncionario.ShowDialog();
        //        this.Visible = true;

        //        if (this.Visible == true)
        //        {
        //            /* populando a combobox funcionario*/
        //            MySqlConnection con = new MySqlConnection(conexao);
        //            con.Open();
        //            string sqlselect_funcionario = "select * from tb_funcionario order by tb_funcionario_nome";
        //            MySqlDataAdapter da_funcionario = new MySqlDataAdapter(sqlselect_funcionario, con);
        //            DataTable dtResultado_funcionario = new DataTable();
        //            da_funcionario.Fill(dtResultado_funcionario);

        //            cmbFunci.DropDownStyle = ComboBoxStyle.DropDownList;
        //            cmbFunci.DataSource = dtResultado_funcionario;
        //            cmbFunci.ValueMember = "tb_funcionario_id";
        //            cmbFunci.DisplayMember = "tb_funcionario_nome";

        //            /*inicia a combobox sem nenhum valor selecionado*/
        //            cmbFunci.SelectedItem = null;

        //            con.Close();

        //        }
        //    }
        //}
    }
}
