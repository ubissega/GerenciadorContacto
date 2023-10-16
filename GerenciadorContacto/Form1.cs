using GerenciadorContacto.DAO;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace GerenciadorContacto
{
    public partial class Form1 : Form
    {
        private ConexaoDB conexao;
        DataTable dt;
        public Form1()
        {
            dt = new DataTable();
            conexao = new ConexaoDB();
            InitializeComponent();

            carregarParaTabela();
        }

        public void InserirContacto(string numero, string nome, string apelido, string provincia, string cidade)
        {
            using (MySqlConnection minhaConexao = conexao.AbrirConexao())
            {
                string query = "INSERT INTO contacto (numero, nome, apelido,provincia,cidade) VALUES (@numero, @nome, @apelido,@provincia,@cidade)";

                using (MySqlCommand cmd = new MySqlCommand(query, minhaConexao))
                {
                    // Adicione parâmetros aos valores que você deseja inserir
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@apelido", apelido);
                    cmd.Parameters.AddWithValue("@provincia", provincia);
                    cmd.Parameters.AddWithValue("@cidade", cidade);

                    // Execute a consulta SQL de inserção
                    int linhasAfetadas = cmd.ExecuteNonQuery();

                    if (linhasAfetadas > 0)
                    {
                        lblConfirmAdd.Visible = true;
                        lblConfirmAdd.Text = "Dados inseridos com sucesso!";
                        campoNumero.Clear();
                        campoNome.Clear();
                        campoApelido.Clear();
                        campoProvincia.Clear();
                        campoCidade.Clear();
                    }
                    else
                    {
                        lblConfirmAdd.Visible = true;
                        lblConfirmAdd.Text = "Nenhum dado foi inserido.";
                    }
                }
            }
        }

        public DataTable ObterDados()
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection minhaConexao = conexao.AbrirConexao())
            {
                string query = $"SELECT * FROM contacto";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, minhaConexao))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }
        public DataTable ObterDadosPesquisados(string v)
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection minhaConexao = conexao.AbrirConexao())
            {
                string query = $"SELECT * FROM contacto where numero like'%{v}%' || nome like'%{v}%'";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, minhaConexao))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }
        public void carregarParaTabela()
        {
            // Substitua "sua_tabela" pelo nome da sua tabela real
            dt = ObterDados();
            listaContactos.DataSource = dt;
            listaContactos.Columns[0].HeaderText = "Numero";
            listaContactos.Columns[1].HeaderText = "Nome";
            listaContactos.Columns[2].Visible = false;
            listaContactos.Columns[3].Visible = false;
            listaContactos.Columns[4].Visible = false;
        }
        public void carregarParaTabelaSearch()
        {
            // Substitua "sua_tabela" pelo nome da sua tabela real
            dt = ObterDadosPesquisados(campoSearch.Text.ToString());
            listaContactos.DataSource = dt;
            listaContactos.Columns[0].HeaderText = "Numero";
            listaContactos.Columns[1].HeaderText = "Nome";
            listaContactos.Columns[2].Visible = false;
            listaContactos.Columns[3].Visible = false;
            listaContactos.Columns[4].Visible = false;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            InserirContacto(campoNumero.Text.ToString(), campoNome.Text.ToString(), campoApelido.Text.ToString(), campoProvincia.Text.ToString(), campoCidade.Text.ToString());
            carregarParaTabela();
        }

        private void listaContactos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listaContactos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            carregarParaTabelaSearch();
        }
    }
}