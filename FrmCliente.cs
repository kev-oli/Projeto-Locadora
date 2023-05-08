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
    public partial class FrmCliente : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["locadora_2dsiem_2021"].ConnectionString;
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {

            try
            {
                MySqlConnection con = new MySqlConnection(conexao);

                string nome, sexo, email, senha, endereco, complemento, bairro, cidade, uf, telefone, status;
                // int id;
                DateTime dt_nasc, dt_cad;


                nome = txtNome.Text;
                sexo = cmbSex.Text;
                email = txtEmail.Text;
                senha = txtSenha.Text;
                endereco = txtEnd.Text;
                complemento = txtComp.Text;
                bairro = txtBairro.Text;
                cidade = txtCid.Text;
                uf = cmbUf.Text;
              //  id = int.Parse(txtId.Text);
                telefone = txtTel.Text;
                dt_nasc = Convert.ToDateTime(txtDtNascimento.Text);
                dt_cad = Convert.ToDateTime(txtDtCad.Text);
                //status = "HABILITADO";

                string sql_insert = @"insert into tb_cliente
                                 (
                                    TB_CLIENTE_NOME,TB_CLIENTE_TEL, TB_CLIENTE_SEXO, TB_CLIENTE_EMAIL,
                                    TB_CLIENTE_SENHA, TB_CLIENTE_ENDERECO, TB_CLIENTE_COMPLEMENTO, 
                                    TB_CLIENTE_BAIRRO, TB_CLIENTE_CIDADE, TB_CLIENTE_UF, 
                                    TB_CLIENTE_DT_NASC, TB_CLIENTE_DT_CAD
                                 )
                                   values
                                 (
                                    @CLIENTE_NOME, @CLIENTE_TEL, @CLIENTE_SEXO, @CLIENTE_EMAIL, @CLIENTE_SENHA, 
                                    @CLIENTE_ENDERECO, @CLIENTE_COMPLEMENTO, @CLIENTE_BAIRRO, @CLIENTE_CIDADE, 
                                    @CLIENTE_UF, @CLIENTE_DT_NASC, @CLIENTE_DT_CAD
                                  )";

                MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con);

                executacmdMySql_insert.Parameters.AddWithValue("@cliente_nome", nome);
                executacmdMySql_insert.Parameters.AddWithValue("@cliente_tel", telefone);
                executacmdMySql_insert.Parameters.AddWithValue("@cliente_sexo", sexo);
                executacmdMySql_insert.Parameters.AddWithValue("@cliente_email", email);
                executacmdMySql_insert.Parameters.AddWithValue("@cliente_senha", senha);
                executacmdMySql_insert.Parameters.AddWithValue("@cliente_endereco", endereco);
                executacmdMySql_insert.Parameters.AddWithValue("@cliente_complemento", complemento);
                executacmdMySql_insert.Parameters.AddWithValue("@cliente_bairro", bairro);
                executacmdMySql_insert.Parameters.AddWithValue("@cliente_cidade", cidade);
                executacmdMySql_insert.Parameters.AddWithValue("@cliente_uf", uf);
                executacmdMySql_insert.Parameters.AddWithValue("@cliente_dt_nasc", dt_nasc);
                executacmdMySql_insert.Parameters.AddWithValue("@cliente_dt_cad", dt_cad);
               // executacmdMySql_insert.Parameters.AddWithValue("@cliente_status", status);
                con.Open();
                executacmdMySql_insert.ExecuteNonQuery();

                string sql_select_cliente = "select * from tb_cliente";

                MySqlCommand executacmdMySql_select_cliente = new MySqlCommand(sql_select_cliente, con);
                executacmdMySql_select_cliente.ExecuteNonQuery();

                DataTable tabela_cliente = new DataTable();

                MySqlDataAdapter da_cliente = new MySqlDataAdapter(executacmdMySql_select_cliente);
                da_cliente.Fill(tabela_cliente);


                con.Close();
                MessageBox.Show("Cadastrado com sucesso!");

                txtId.Clear();
                txtNome.Clear();
                //cmbSex.Clear();
                txtEmail.Clear();
                txtSenha.Clear();
                txtEnd.Clear();
                txtComp.Clear();
                txtBairro.Clear();
                txtCid.Clear();                                    
                txtTel.Clear();
                //txtDtNascimento.Clear();
                txtDtCad.Clear();

                cmbSex.Text = string.Empty;
                cmbUf.Text = string.Empty;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }

        }

        private void BtnRegistrados_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmCliente_Regs frmCliente_Regs = new FrmCliente_Regs();
            frmCliente_Regs.ShowDialog();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtDtNascimento_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
