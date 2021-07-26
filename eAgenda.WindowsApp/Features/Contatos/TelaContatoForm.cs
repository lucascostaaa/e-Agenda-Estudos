using eAgenda.Dominio.ContatoModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WindowsApp.Features.Contatos
{
    public partial class TelaContatoForm : Form
    {
        private Contato contato;

        public TelaContatoForm()
        {
            InitializeComponent();
        }
        public Contato Contato
        {
            get { return contato; }

            set
            {
                contato = value;

                textId.Text = contato.Id.ToString();
                textBoxNome.Text = contato.Nome;
                TextEmail.Text = contato.Email;
                textBoxTelefone.Text = contato.Telefone;
                textBoxEmpresa.Text = contato.Empresa;
                textBoxCargo.Text = contato.Cargo;
            }
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            string email = TextEmail.Text;
            string telefone = textBoxTelefone.Text;
            string empresa = textBoxEmpresa.Text;
            string cargo = textBoxCargo.Text;

            contato = new Contato(nome, email, telefone, empresa, cargo);

            string resultadoValidacao = contato.Validar();

            if (resultadoValidacao != "ESTA_VALIDO")
            {
                string primeiroErro = new StringReader(resultadoValidacao).ReadLine();

                TelaPrincipalForm.Instancia.AtualizarRodape(primeiroErro);

                DialogResult = DialogResult.None;
            }
        }
    }
}
