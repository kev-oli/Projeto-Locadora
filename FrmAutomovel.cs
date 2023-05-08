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
    public partial class FrmAutomovel : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["locadora_2dsiem_2021"].ConnectionString;

        public FrmAutomovel()
        {
            InitializeComponent();
        }

        private void FrmAutomovel_Load(object sender, EventArgs e)
        {

            /* populando a combobox marca*/
            MySqlConnection con = new MySqlConnection(conexao);
            string sqlselect_marca = "select * from tb_marca order by tb_marca_nome";
            MySqlDataAdapter da_marca = new MySqlDataAdapter(sqlselect_marca, con);
            DataTable dtResultado_marca = new DataTable();
            da_marca.Fill(dtResultado_marca);

            cmbMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMarca.DataSource = dtResultado_marca;
            cmbMarca.ValueMember = "tb_marca_id";
            cmbMarca.DisplayMember = "tb_marca_nome";


            /* populando a combobox modelo*/
            string sqlselect_modelo = "select * from tb_modelo order by tb_modelo_desc";
            MySqlDataAdapter da_modelo = new MySqlDataAdapter(sqlselect_modelo, con);
            DataTable dtResultado_modelo = new DataTable();
            da_modelo.Fill(dtResultado_modelo);

            cmbModelo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbModelo.DataSource = dtResultado_modelo;
            cmbModelo.ValueMember = "tb_modelo_id";
            cmbModelo.DisplayMember = "tb_modelo_desc";


            /*inicia a combobox sem nenhum valor selecionado*/
            cmbMarca.SelectedItem = null;
            cmbModelo.SelectedItem = null;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);

                string nome, status, cor;

                int id_marca, id_modelo;
                //DateTime dt_fab;
                double valor, km;
                int anoFab;

                cor = txtCor.Text;
                nome = txtNome.Text;
                status = cmbStatus.Text;
                id_marca = int.Parse(cmbMarca.SelectedValue.ToString());
                id_modelo = int.Parse(cmbModelo.SelectedValue.ToString());
                // marca = cmbMarca.Text;
                anoFab = int.Parse(txtAnoF.Text);
                valor = Double.Parse(txtValorD.Text);
                km = Double.Parse(txtKm.Text);
                // dt_fab = Convert.ToDateTime(txtAnoF.Text);
                //status = "HABILITADO";

                string sql_insert = @"insert into tb_automovel
                                 (
                                    TB_AUTOMOVEL_NOME,
                                    TB_AUTOMOVEL_VALOR_D,
                                    TB_AUTOMOVEL_ANO_FAB,
                                    TB_AUTOMOVEL_KM,
                                    TB_AUTOMOVEL_STATUS,
                                    TB_AUTOMOVEL_COR,
                                    TB_MARCA_ID, 
                                    TB_MODELO_ID
                                 )
                                   values
                                 (
                                     @TB_AUTOMOVEL_NOME,
                                     @TB_AUTOMOVEL_VALOR_D,
                                     @TB_AUTOMOVEL_ANO_FAB,
                                     @TB_AUTOMOVEL_KM,
                                     @TB_AUTOMOVEL_STATUS,
                                     @TB_AUTOMOVEL_COR,                
                                     @TB_MARCA_ID,
                                     @TB_MODELO_ID

                                  )";

                MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con);

                executacmdMySql_insert.Parameters.AddWithValue("@TB_AUTOMOVEL_NOME", nome);
                executacmdMySql_insert.Parameters.AddWithValue("@TB_AUTOMOVEL_COR", cor);
                executacmdMySql_insert.Parameters.AddWithValue("@TB_AUTOMOVEL_VALOR_D", valor);
                executacmdMySql_insert.Parameters.AddWithValue("@TB_AUTOMOVEL_ANO_FAB", anoFab);
                executacmdMySql_insert.Parameters.AddWithValue("@TB_AUTOMOVEL_KM", km);
                executacmdMySql_insert.Parameters.AddWithValue("@TB_AUTOMOVEL_STATUS", status);
                executacmdMySql_insert.Parameters.AddWithValue("@TB_MARCA_ID", id_marca);
                executacmdMySql_insert.Parameters.AddWithValue("@TB_MODELO_ID", id_modelo);
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
                txtCor.Clear();
                txtId.Clear();
                txtKm.Clear();
                txtNome.Clear();
                txtValorD.Clear();
                txtAnoF.Clear();

                cmbMarca.Text = string.Empty;
                cmbStatus.Text = string.Empty;
                cmbModelo.Text = string.Empty;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
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
            //FrmMenu.ShowDialog();
        }

        private void btnRegistrados_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmAutomovel_Regs frmAutomovel_Regs = new FrmAutomovel_Regs();
            frmAutomovel_Regs.ShowDialog();
            this.Visible = true;
        }

        private void NOVO_MARCA(object sender, EventArgs e)
        {
            string novo_marca;

            novo_marca = cmbMarca.Text;

            if (novo_marca == "NOVO")
            {
                this.Visible = false;
                FrmMarca FrmMarca = new FrmMarca();
                FrmMarca.ShowDialog();
                this.Visible = true;

                if (this.Visible == true)
                {
                    /* populando a combobox marca*/
                    MySqlConnection con = new MySqlConnection(conexao);
                    con.Open();
                    string sqlselect_marca = "select * from tb_marca order by tb_marca_nome";
                    MySqlDataAdapter da_marca = new MySqlDataAdapter(sqlselect_marca, con);
                    DataTable dtResultado_marca = new DataTable();
                    da_marca.Fill(dtResultado_marca);

                    cmbMarca.DropDownStyle = ComboBoxStyle.DropDownList;
                    cmbMarca.DataSource = dtResultado_marca;
                    cmbMarca.ValueMember = "tb_marca_id";
                    cmbMarca.DisplayMember = "tb_marca_nome";

                    cmbMarca.SelectedItem = null;

                }
            }
        }

        private void NOVO_MODELO(object sender, EventArgs e)
        {
            string novo_modelo;

            novo_modelo = cmbModelo.Text;

            if (novo_modelo == "NOVO")
            {
                this.Visible = false;
                FrmModelo FrmModelo = new FrmModelo();
                FrmModelo.ShowDialog();
                this.Visible = true;

                if (this.Visible == true)
                {
                    /* populando a combobox modelo*/
                    MySqlConnection con = new MySqlConnection(conexao);
                    con.Open();
                    string sqlselect_modelo = "select * from tb_modelo order by tb_modelo_desc";
                    MySqlDataAdapter da_modelo = new MySqlDataAdapter(sqlselect_modelo, con);
                    DataTable dtResultado_modelo = new DataTable();
                    da_modelo.Fill(dtResultado_modelo);

                    cmbModelo.DropDownStyle = ComboBoxStyle.DropDownList;
                    cmbModelo.DataSource = dtResultado_modelo;
                    cmbModelo.ValueMember = "tb_modelo_id";
                    cmbModelo.DisplayMember = "tb_modelo_desc";


                    /*inicia a combobox sem nenhum valor selecionado*/
                    cmbModelo.SelectedItem = null;

                }
            }
        }
    }
}
