using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tela
{
    public partial class TelaUsuario : Form
    {
        int id = -1;
        public TelaUsuario()
        {
            InitializeComponent();
        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            txtCargo.Clear();
            gbNovoUsuario.Visible = !gbNovoUsuario.Visible;

            btnCadastrar.Text = "Cadastrar";
        }
        private void bntSalvar_Click(object sender, EventArgs e)
        {
            Button? botao = sender as Button;

            var nome = txtNome.Text;
            var telefone = txtTelefone.Text;
            var email = txtEmail.Text;
            var endereco = txtCep.Text;
            var novoUsuario = new EntidadeUsuario(nome, telefone, email, endereco);

            switch (botao.Text)
            {
                case "Cadastrar":
                    {

                        var usuarioRepositorio = new UsuarioRepository();
                        var resultado = usuarioRepositorio.Inserir(novoUsuario);

                        if (resultado)
                        {
                            MessageBox.Show("Cargo cadastrado com sucesso!!");
                        }
                        else
                        {
                            MessageBox.Show("Não foi possivel gravar o cargo!!");
                        }
                        //cadastar
                        break;
                    }
                case "Salvar":
                    {
                        var usuarioRepositorio = new UsuarioRepository();
                        var resultado = usuarioRepositorio.Atualizar(novoUsuario, id);
                        if (resultado)
                        {
                            MessageBox.Show("Cargo Atualizado com Sucesso.");
                        }
                        else
                        {
                            MessageBox.Show("Erro! Verifique e Tente Novamente.");
                        }
                        break;
                    }
                default:
                  break;

            }
        }

        private void TelaUsuario_Load(object sender, EventArgs e)
        {
            InformacoesTabelaCargo();
        }
        private void InformacoesTabelaCargo()
        {
            var usuarioRepositorio = new UsuarioRepository();

            var obterTodos = usuarioRepositorio.ObterTodos();

            gbNovoUsuario.DataSource = obterTodos;
        }

        private void gvUsuario_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = gvUsuario.Rows[e.RowIndex];
            var cargoRepository = new UsuarioRepository();

            if (gvUsuario.Columns[e.ColumnIndex].Name == "Deletar")
            {
                if (MessageBox.Show("Deseja realmente deletar o registro?",
                    "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var resulatdo = cargoRepository.Deletar(Convert.ToInt32(row.Cells[1].Value));
                    MessageBox.Show("Registro deletado com sucesso!");
                };
                return;
            }
        }
    }
}
