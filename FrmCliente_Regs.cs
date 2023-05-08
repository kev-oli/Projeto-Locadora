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
    public partial class FrmCliente_Regs : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["locadora_2dsiem_2021"].ConnectionString;
        //private object executacmdMySql_update_cliente;

        public FrmCliente_Regs()
        {
            InitializeComponent();
        }

        
        private void FrmCliente_Regs_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            string sql_select_cliente = "select * from tb_cliente";

            MySqlCommand executacmdMySql_select_cliente = new MySqlCommand(sql_select_cliente, con);
            executacmdMySql_select_cliente.ExecuteNonQuery();

            DataTable tabela_cliente = new DataTable();

            MySqlDataAdapter da_cliente = new MySqlDataAdapter(executacmdMySql_select_cliente);
            da_cliente.Fill(tabela_cliente);

            DgvListarCliente.DataSource = tabela_cliente;
            con.Close();
        }

        //private void DgvListarCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    txtId.Text = DgvListarCliente.CurrentRow.Cells[0].Value.ToString();
        //    txtNome.Text = DgvListarCliente.CurrentRow.Cells[1].Value.ToString();
        //    txtTel.Text = DgvListarCliente.CurrentRow.Cells[2].Value.ToString();
        //    cmbSex.Text = DgvListarCliente.CurrentRow.Cells[3].Value.ToString();
        //    txtEmail.Text = DgvListarCliente.CurrentRow.Cells[4].Value.ToString();
        //    txtSenha.Text = DgvListarCliente.CurrentRow.Cells[5].Value.ToString();
        //    txtEnd.Text = DgvListarCliente.CurrentRow.Cells[6].Value.ToString();
        //    txtComp.Text = DgvListarCliente.CurrentRow.Cells[7].Value.ToString();
        //    txtBairro.Text = DgvListarCliente.CurrentRow.Cells[8].Value.ToString();
        //    txtCid.Text = DgvListarCliente.CurrentRow.Cells[9].Value.ToString();
        //    txtUF.Text = DgvListarCliente.CurrentRow.Cells[10].Value.ToString();
        //    txtDtNasc.Text = DgvListarCliente.CurrentRow.Cells[11].Value.ToString();
        //    txtDtCad.Text = DgvListarCliente.CurrentRow.Cells[12].Value.ToString();
        //}

        private void btnAtualizar(object sender, MouseEventArgs e)
        {
            try
            {
                //MySqlConnection con = new MySqlConnection(conexao);


            string nome, sexo, email, senha, endereco, complemento, bairro, cidade, uf, telefone, status;
            int id;
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
            id = int.Parse(txtId.Text);
            telefone = txtTel.Text;
            dt_nasc = Convert.ToDateTime(txtDtNasc.Text);
            dt_cad = Convert.ToDateTime(txtDtCad.Text);
            status = CmbStatus.Text;

                //txtDtNasc.Text = 
                    //dt_nasc.DateTime.ToString("dd/MM/yyyy");
                //dt_nasc = DateTime.Now.ToString("dd-mm-yyyy");
                //dt_cad = DateTime.Now.ToString("dd-mm-yyyy");

                //    DateTime dt = DateTime.Now.Date;
                //    string dt_cad = dt.ToShortDateString().ToString(CultureInfo.CreateSpecificCulture("en-US"));
                //    "SELECT * FROM tb_cliente WHERE FORMAT(dt,'mm/dd/yyyy') > dt"

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_update_cliente = @"update tb_cliente
                                set TB_CLIENTE_NOME = @CLIENTE_NOME,
                                    TB_CLIENTE_TEL = @CLIENTE_TEL, 
                                    TB_CLIENTE_SEXO = @CLIENTE_SEXO, 
                                    TB_CLIENTE_EMAIL = @CLIENTE_EMAIL, 
                                    TB_CLIENTE_SENHA = @CLIENTE_SENHA, 
                                    TB_CLIENTE_ENDERECO = @CLIENTE_ENDERECO, 
                                    TB_CLIENTE_COMPLEMENTO = @CLIENTE_COMPLEMENTO, 
                                    TB_CLIENTE_BAIRRO = @CLIENTE_BAIRRO, 
                                    TB_CLIENTE_CIDADE = @CLIENTE_CIDADE, 
                                    TB_CLIENTE_UF = @CLIENTE_UF, 
                                    TB_CLIENTE_DT_NASC = @CLIENTE_DT_NASC,
                                    TB_CLIENTE_DT_CAD = @CLIENTE_DT_CAD,
                                    TB_CLIENTE_STATUS = @CLIENTE_STATUS
                                where TB_CLIENTE_ID = @CLIENTE_ID";


                MySqlCommand executacmdMySql_update_cliente = new MySqlCommand(sql_update_cliente, con);

                executacmdMySql_update_cliente.Parameters.AddWithValue("@CLIENTE_ID", id);
                executacmdMySql_update_cliente.Parameters.AddWithValue("@CLIENTE_NOME", nome);
                executacmdMySql_update_cliente.Parameters.AddWithValue("@CLIENTE_TEL", telefone);
                executacmdMySql_update_cliente.Parameters.AddWithValue("@CLIENTE_SEXO", sexo);
                executacmdMySql_update_cliente.Parameters.AddWithValue("@CLIENTE_EMAIL", email);
                executacmdMySql_update_cliente.Parameters.AddWithValue("@CLIENTE_SENHA", senha);
                executacmdMySql_update_cliente.Parameters.AddWithValue("@CLIENTE_ENDERECO", endereco);
                executacmdMySql_update_cliente.Parameters.AddWithValue("@CLIENTE_COMPLEMENTO", complemento);
                executacmdMySql_update_cliente.Parameters.AddWithValue("@CLIENTE_BAIRRO", bairro);
                executacmdMySql_update_cliente.Parameters.AddWithValue("@CLIENTE_CIDADE", cidade);
                executacmdMySql_update_cliente.Parameters.AddWithValue("@CLIENTE_UF", uf);
                executacmdMySql_update_cliente.Parameters.AddWithValue("@CLIENTE_DT_NASC", dt_nasc);
                executacmdMySql_update_cliente.Parameters.AddWithValue("@CLIENTE_DT_CAD", dt_cad);
                executacmdMySql_update_cliente.Parameters.AddWithValue("@CLIENTE_STATUS", status);


                //con.Open();
                executacmdMySql_update_cliente.ExecuteNonQuery();

                //con.Close();

                string sql_select_cliente = "select * from tb_cliente where TB_CLIENTE_STATUS='ATIVO'";


                //Codigo para assim que deletar um registro, ja deletar na data grid view
                MySqlCommand executacmdMySql_select_cliente = new MySqlCommand(sql_select_cliente, con);
                executacmdMySql_select_cliente.ExecuteNonQuery();

                DataTable tabela_cliente = new DataTable();

                MySqlDataAdapter da_cliente = new MySqlDataAdapter(executacmdMySql_select_cliente);
                da_cliente.Fill(tabela_cliente);

                DgvListarCliente.DataSource = tabela_cliente;


                MessageBox.Show("Registro Atualizado!");    
                con.Close();

                txtId.Clear();
                txtNome.Clear();
                //cmbSex.Items.Clear();
                //cmbSex.ResetText();
                txtEmail.Clear();
                txtSenha.Clear();
                txtEnd.Clear();
                txtComp.Clear();
                txtBairro.Clear();
                txtCid.Clear();
                txtTel.Clear();
                txtDtNasc.Clear();
                txtDtCad.Clear();

                CmbStatus.Text = string.Empty;
                cmbSex.Text = string.Empty;
                cmbUf.Text = string.Empty;
              // CmbStatus.Items.Clear();
              // CmbStatus.ResetText();

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
            FrmCliente frmCliente = new FrmCliente();
            frmCliente.Close();
            FrmMenu.ShowDialog();
        }

        private void DgvListarCliente_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = DgvListarCliente.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = DgvListarCliente.CurrentRow.Cells[1].Value.ToString();
            txtTel.Text = DgvListarCliente.CurrentRow.Cells[2].Value.ToString();
            cmbSex.Text = DgvListarCliente.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = DgvListarCliente.CurrentRow.Cells[4].Value.ToString();
            txtSenha.Text = DgvListarCliente.CurrentRow.Cells[5].Value.ToString();
            txtEnd.Text = DgvListarCliente.CurrentRow.Cells[6].Value.ToString();
            txtComp.Text = DgvListarCliente.CurrentRow.Cells[7].Value.ToString();
            txtBairro.Text = DgvListarCliente.CurrentRow.Cells[8].Value.ToString();
            txtCid.Text = DgvListarCliente.CurrentRow.Cells[9].Value.ToString();
            cmbUf.Text = DgvListarCliente.CurrentRow.Cells[10].Value.ToString();
            txtDtNasc.Text = DgvListarCliente.CurrentRow.Cells[11].Value.ToString();
            txtDtCad.Text = DgvListarCliente.CurrentRow.Cells[12].Value.ToString();
            CmbStatus.Text = DgvListarCliente.CurrentRow.Cells[13].Value.ToString();
        }

        private void BtnDesativados_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

           
            string sql_select_cliente = "select * from tb_cliente where tb_cliente_status = 'INATIVO' ";

            MySqlCommand executacmdMySql_select_cliente = new MySqlCommand(sql_select_cliente, con);
            executacmdMySql_select_cliente.ExecuteNonQuery();

            DataTable tabela_cliente_status = new DataTable();

            //MySqlDataAdapter da_cliente = new MySqlDataAdapter(executacmdMySql_select_cliente);
            //da_cliente.Fill(tabela_cliente);

            DgvListarCliente.DataSource = tabela_cliente_status;


           

            MySqlDataAdapter da_cliente = new MySqlDataAdapter(executacmdMySql_select_cliente);
            da_cliente.Fill(tabela_cliente_status);


            con.Close();
        }

       
    }
}
