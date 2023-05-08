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
    public partial class FrmFuncionario : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["locadora_2dsiem_2021"].ConnectionString;

        public FrmFuncionario()
        {
            InitializeComponent();
        }

        private void FrmFuncionario_Load(object sender, EventArgs e)
        {
            /* populando a combobox cargo*/
            MySqlConnection con = new MySqlConnection(conexao);
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

        private void Novo(object sender, EventArgs e)
        {
            //item selecionado '=novo'
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);

                string nome;
                int telefone, id_cargo;
                DateTime dt_contrato;

                nome = txtNome.Text;
                telefone = int.Parse(txtTel.Text);
                id_cargo = int.Parse(cmbCargo.SelectedValue.ToString());
                dt_contrato = Convert.ToDateTime(txtDtContrato.Text);

                string sql_insert = @"insert into tb_funcionario
                                 (
                                    TB_FUNCIONARIO_NOME,
                                    TB_FUNCIONARIO_TEL,
                                    TB_FUNCIONARIO_DT_CONTRATO,
                                    TB_CARGO_ID
                                 )
                                   values
                                 (
                                    @TB_FUNCIONARIO_NOME, 
                                    @TB_FUNCIONARIO_TEL, 
                                    @TB_FUNCIONARIO_DT_CONTRATO, 
                                    @TB_CARGO_ID

                                  )";

                MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con);

                executacmdMySql_insert.Parameters.AddWithValue("@TB_FUNCIONARIO_NOME", nome);
                executacmdMySql_insert.Parameters.AddWithValue("@TB_FUNCIONARIO_TEL", telefone);
                executacmdMySql_insert.Parameters.AddWithValue("@TB_FUNCIONARIO_DT_CONTRATO", dt_contrato);
                executacmdMySql_insert.Parameters.AddWithValue("@TB_CARGO_ID", id_cargo);
                con.Open();
                executacmdMySql_insert.ExecuteNonQuery();

                string sql_select_automovel = "select * from tb_automovel";

                MySqlCommand executacmdMySql_select_automovel = new MySqlCommand(sql_select_automovel, con);
                executacmdMySql_select_automovel.ExecuteNonQuery();

                DataTable tabela_automovel = new DataTable();

                MySqlDataAdapter da_automovel = new MySqlDataAdapter(executacmdMySql_select_automovel);
                da_automovel.Fill(tabela_automovel);


                con.Close();
                MessageBox.Show("Cadastrado com sucesso!");

                txtId.Clear();
                txtNome.Clear();
                //cmbSex.Clear();
                txtTel.Clear();
                txtId.Clear();
                txtDtContrato.Clear();

                cmbCargo.Text = string.Empty;
               

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }
        }

        private void btnRegistrados_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmFuncionario_Regs frmFuncionario_Regs = new FrmFuncionario_Regs();
            frmFuncionario_Regs.ShowDialog();
            this.Visible = true;
        }

        private void NOVO_CARGO(object sender, EventArgs e)
        {
            string novo_cargo;

            novo_cargo = cmbCargo.Text;

            if (novo_cargo == "NOVO")
            {
                this.Visible = false;
                FrmCargo FrmCargo = new FrmCargo();
                FrmCargo.ShowDialog();
                this.Visible = true;

                if (this.Visible == true)
                {
                    /* populando a combobox cargo*/
                    MySqlConnection con = new MySqlConnection(conexao);
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
            }

        }
    }
}
