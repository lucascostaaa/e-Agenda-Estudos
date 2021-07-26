using eAgenda.Controladores.ContatoModule;
using eAgenda.Dominio.ContatoModule;
using eAgenda.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WindowsApp.Features.Contatos
{
    public class OperacoesContato : ICadastravel
    {
        private readonly ControladorContato controlador = new ControladorContato();
        private readonly TabelaContatoControl tabelaContatos = new TabelaContatoControl();

        public OperacoesContato(ControladorContato ctrlContato)
        {
            controlador = ctrlContato;
            tabelaContatos = new TabelaContatoControl();
        }
        public void InserirNovoRegistro()
        {
            TelaContatoForm tela = new TelaContatoForm();

            if(tela.ShowDialog() == DialogResult.OK)
            {
                controlador.InserirNovo(tela.Contato);

                List<Contato> contatos = controlador.SelecionarTodos();

                tabelaContatos.AtualizarRegistros();

                TelaPrincipalForm.Instancia.AtualizarRodape($"Contato: [{tela.Contato.Nome}] inserido com sucesso");
            }
        }
        public void EditarRegistro()
        {
            int id = tabelaContatos.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um contato para poder editar!", "Edição de Contatos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Contato contatoSelecionado = controlador.SelecionarPorId(id);

            TelaContatoForm tela = new TelaContatoForm();

            tela.Contato = contatoSelecionado;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.Editar(id, tela.Contato);

                List<Contato> contatos = controlador.SelecionarTodos();

                tabelaContatos.AtualizarRegistros();

                TelaPrincipalForm.Instancia.AtualizarRodape($"Contato: [{tela.Contato.Nome}] editada com sucesso");
            }
        }
        public void ExcluirRegistro()
        {
            int id = tabelaContatos.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um contato para poder excluir!", "Exclusão de Contatos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Contato contatoSelecionado = controlador.SelecionarPorId(id);

            if (MessageBox.Show($"Tem ceerteza que deseja remover um contato: [{contatoSelecionado.Nome}] ?",
                "Exclusão de Contato", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                controlador.Excluir(id);

                List<Contato> contatos = controlador.SelecionarTodos();

                tabelaContatos.AtualizarRegistros();

                TelaPrincipalForm.Instancia.AtualizarRodape($"Contato: [{contatoSelecionado.Nome}] removida com sucesso");
            }
        }        
        public UserControl ObterTabela()
        {
            List<Contato> contatos = controlador.SelecionarTodos();

            tabelaContatos.AtualizarRegistros();

            return tabelaContatos;
        }
        public void FiltrarRegistros()
        {
            AgruparRegistros();
        }
        public void AgruparRegistros()
        {
            FiltroDeContatos telaAgrupamento = new FiltroDeContatos();

            if (telaAgrupamento.ShowDialog() == DialogResult.OK)
            {
                List<Contato> contatos = new List<Contato>();

                switch (telaAgrupamento.TipoFiltro)
                {
                    case FiltroContatoEnum.ContatosAgrupadosEmpresa:
                        tabelaContatos.AgruparContatosPor("Empresa");
                        break;

                    case FiltroContatoEnum.ContatosAgrupadosCargo:
                        tabelaContatos.AgruparContatosPor("Cargo");
                        break;

                    case FiltroContatoEnum.DesagruparContatos:
                        tabelaContatos.DesagruparContatos();
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
