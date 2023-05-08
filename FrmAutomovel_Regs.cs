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
    public partial class FrmAutomovel_Regs : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["locadora_2dsiem_2021"].ConnectionString;

        public FrmAutomovel_Regs()
        {
            InitializeComponent();
        }


        private void FrmAutomovel_Regs_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

            string sql_select_automovel = @"select tb_automovel.TB_AUTOMOVEL_ID as 'ID DO AUTOMÓVEL',
                                            tb_automovel.TB_AUTOMOVEL_NOME as 'NOME',
                                            tb_automovel.TB_AUTOMOVEL_ANO_FAB as 'ANO DE FABRICAÇÃO',
                                            tb_automovel.TB_AUTOMOVEL_COR as 'COR',
                                            tb_automovel.TB_AUTOMOVEL_KM as 'KM',
                                            tb_automovel.TB_AUTOMOVEL_VALOR_D as 'VALOR DA DIÁRIA',
                                            tb_marca.TB_MARCA_NOME as 'MARCA',
                                            tb_modelo.TB_MODELO_DESC as 'MODELO',
                                            tb_automovel.TB_AUTOMOVEL_STATUS as 'STATUS'
                                            from tb_automovel 
                                            inner join tb_marca on tb_automovel.TB_MARCA_ID = tb_marca.TB_MARCA_ID
                                            inner join tb_modelo on tb_automovel.TB_MODELO_ID = tb_modelo.TB_MODELO_ID where TB_AUTOMOVEL_STATUS = 'DISPONÍVEL';";

            MySqlCommand executacmdMySql_select_automovel = new MySqlCommand(sql_select_automovel, con);
            executacmdMySql_select_automovel.ExecuteNonQuery();

            DataTable tabela_automovel = new DataTable();

            MySqlDataAdapter da_automovel = new MySqlDataAdapter(executacmdMySql_select_automovel);
            da_automovel.Fill(tabela_automovel);

            DgvListarAutomoveis.DataSource = tabela_automovel;
            con.Close();


            /* populando a combobox MARCA*/
            //MySqlConnection con = new MySqlConnection(conexao);
            string sqlselect_marca = "select * from tb_marca order by tb_marca_nome";
            MySqlDataAdapter da_marca = new MySqlDataAdapter(sqlselect_marca, con);
            DataTable dtResultado_marca = new DataTable();
            da_marca.Fill(dtResultado_marca);

            cmbMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMarca.DataSource = dtResultado_marca;
            cmbMarca.ValueMember = "tb_marca_id";
            cmbMarca.DisplayMember = "tb_marca_nome";

            /* populando a combobox MODELO*/
            //MySqlConnection con = new MySqlConnection(conexao);
            string sqlselect_modelo = "select * from tb_modelo order by tb_modelo_desc";
            MySqlDataAdapter da_modelo = new MySqlDataAdapter(sqlselect_modelo, con);
            DataTable dtResultado_modelo = new DataTable();
            da_modelo.Fill(dtResultado_modelo);

            cmbModelo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbModelo.DataSource = dtResultado_modelo;
            cmbModelo.ValueMember = "tb_modelo_id";
            cmbModelo.DisplayMember = "tb_modelo_desc";

            /*inicia a combobox sem nenhum valor selecionado*/
            //cmbMarca.SelectedItem = null;
           //cmbModelo.SelectedItem = null;
        }

        private void btnAtualizar(object sender, MouseEventArgs e)
        {
            try
            {
                string nome, cor, status, modelo, marca;
                int id_automovel, ano_fab, km, val_diaria;

                id_automovel = int.Parse(txtId.Text);
                ano_fab = int.Parse(txtAnoF.Text);
                km = int.Parse(txtKm.Text);
                val_diaria = int.Parse(txtValorD.Text);
                nome = txtNome.Text;
                cor = txtCor.Text;
                modelo = (cmbModelo.SelectedValue.ToString());
                marca = (cmbMarca.SelectedValue.ToString());
                status = cmbStatus.Text;

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();


                string sql_update_automovel = @"update tb_automovel
                                set TB_AUTOMOVEL_NOME = @AUTOMOVEL_NOME,
                                    TB_AUTOMOVEL_ANO_FAB = @AUTOMOVEL_ANO_FAB,
                                    TB_AUTOMOVEL_COR = @AUTOMOVEL_COR,
                                    TB_AUTOMOVEL_KM = @AUTOMOVEL_KM,
                                    TB_AUTOMOVEL_VALOR_D = @AUTOMOVEL_VALOR_D,
                                    TB_MARCA_ID = @MARCA_ID,
                                    TB_MODELO_ID = @MODELO_ID,
                                    TB_AUTOMOVEL_STATUS = @AUTOMOVEL_STATUS
                                where TB_AUTOMOVEL_ID = @AUTOMOVEL_ID";

                MySqlCommand executacmdMySql_update_automovel = new MySqlCommand(sql_update_automovel, con);

                executacmdMySql_update_automovel.Parameters.AddWithValue("@AUTOMOVEL_ID", id_automovel);
                executacmdMySql_update_automovel.Parameters.AddWithValue("@FUNCIONARIO_NOME", nome);
                executacmdMySql_update_automovel.Parameters.AddWithValue("@AUTOMOVEL_ANO_FAB", ano_fab);
                executacmdMySql_update_automovel.Parameters.AddWithValue("@AUTOMOVEL_COR", cor); 
                executacmdMySql_update_automovel.Parameters.AddWithValue("@AUTOMOVEL_KM", km);
                executacmdMySql_update_automovel.Parameters.AddWithValue("@AUTOMOVEL_VALOR_D", val_diaria);
                executacmdMySql_update_automovel.Parameters.AddWithValue("@MARCA_ID", marca);
                executacmdMySql_update_automovel.Parameters.AddWithValue("@MODELO_ID", modelo);
                executacmdMySql_update_automovel.Parameters.AddWithValue("@AUTOMOVEL_STATUS", status);


                executacmdMySql_update_automovel.ExecuteNonQuery();

                string sql_select_automovel = @"select tb_automovel.TB_AUTOMOVEL_ID as 'ID DO AUTOMÓVEL',
                                                tb_automovel.TB_AUTOMOVEL_NOME as 'NOME',
                                                tb_automovel.TB_AUTOMOVEL_ANO_FAB as 'ANO DE FABRICAÇÃO',
                                                tb_automovel.TB_AUTOMOVEL_COR as 'COR',
                                                tb_automovel.TB_AUTOMOVEL_KM as 'KM',
                                                tb_automovel.TB_AUTOMOVEL_VALOR_D as 'VALOR DA DIÁRIA',
                                                tb_marca.TB_MARCA_NOME as 'MARCA',
                                                tb_modelo.TB_MODELO_DESC as 'MODELO',
                                                tb_automovel.TB_AUTOMOVEL_STATUS as 'STATUS'
                                                from tb_automovel 
                                                inner join tb_marca on tb_automovel.TB_MARCA_ID = tb_marca.TB_MARCA_ID
                                                inner join tb_modelo on tb_automovel.TB_MODELO_ID = tb_modelo.TB_MODELO_ID where TB_AUTOMOVEL_STATUS = 'DISPONÍVEL';";

                MySqlCommand executacmdMySql_select_automovel = new MySqlCommand(sql_select_automovel, con);
                executacmdMySql_select_automovel.ExecuteNonQuery();

                DataTable tabela_automovel = new DataTable();

                MySqlDataAdapter da_automovel = new MySqlDataAdapter(executacmdMySql_select_automovel);
                da_automovel.Fill(tabela_automovel);

                DgvListarAutomoveis.DataSource = tabela_automovel;
                //con.Close();
                //con.Close()


                MessageBox.Show("Registro Atualizado!");

                con.Close();

                txtId.Clear();
                txtNome.Clear();
                txtAnoF.Clear();
                txtCor.Clear();
                txtKm.Clear();
                txtValorD.Clear();
                cmbMarca.SelectedItem = null;
                //cmbMarca.Text = string.Empty;
                //cmbModelo.Text = string.Empty;
                //cmbStatus.Text = string.Empty;
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

                string sql_select_automovel = "select * from tb_automovel where tb_automovel_status = 'INDISPONÍVEL' ";

                MySqlCommand executacmdMySql_select_automovel = new MySqlCommand(sql_select_automovel, con);
                executacmdMySql_select_automovel.ExecuteNonQuery();

                DataTable tabela_automovel_status = new DataTable();

                DgvListarAutomoveis.DataSource = tabela_automovel_status;

                MySqlDataAdapter da_automovel = new MySqlDataAdapter(executacmdMySql_select_automovel);
                da_automovel.Fill(tabela_automovel_status);

                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void dgvListarAutomoveis(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = DgvListarAutomoveis.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = DgvListarAutomoveis.CurrentRow.Cells[1].Value.ToString();
            txtAnoF.Text = DgvListarAutomoveis.CurrentRow.Cells[2].Value.ToString();
            txtCor.Text = DgvListarAutomoveis.CurrentRow.Cells[3].Value.ToString();
            txtKm.Text = DgvListarAutomoveis.CurrentRow.Cells[4].Value.ToString();
            txtValorD.Text = DgvListarAutomoveis.CurrentRow.Cells[5].Value.ToString();
            cmbMarca.Text = DgvListarAutomoveis.CurrentRow.Cells[6].Value.ToString();
            cmbModelo.Text = DgvListarAutomoveis.CurrentRow.Cells[7].Value.ToString();
            cmbStatus.Text = DgvListarAutomoveis.CurrentRow.Cells[8].Value.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmAutomovel FrmAutomovel = new FrmAutomovel();
        }

        private void DgvListarAutomoveis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
