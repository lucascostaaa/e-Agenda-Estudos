using eAgenda.Controladores.CompromissoModule;
using eAgenda.Controladores.ContatoModule;
using eAgenda.Dominio.CompromissoModule;
using eAgenda.Dominio.ContatoModule;
using eAgenda.WindowsApp.Features.Contatos;
using eAgenda.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WindowsApp.Features.Compromissos
{
    public class OperacoesCompromisso : ICadastravel
    {
        private readonly ControladorContato controladorContato = new ControladorContato();
        private readonly ControladorCompromisso controladorCompromisso = new ControladorCompromisso();
        private readonly TabelaCompromissoControl tabelaCompromisso = new TabelaCompromissoControl();
        private readonly TabelaContatoControl tabelaContato = new TabelaContatoControl();

        public OperacoesCompromisso(ControladorCompromisso ctrlCompromisso)
        {
            controladorCompromisso = ctrlCompromisso;
            tabelaCompromisso = new TabelaCompromissoControl();
        }

        public void InserirNovoRegistro()
        {
            TelaCompromissoForm tela = new TelaCompromissoForm();

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controladorCompromisso.InserirNovo(tela.Compromisso);

                List<Contato> contatos = controladorContato.SelecionarTodos();

                tabelaContato.AtualizarRegistros();

                TelaPrincipalForm.Instancia.AtualizarRodape($"Compromisso: [{tela.Compromisso}] inserido com sucesso");
            }
        }
        public void EditarRegistro()
        {
            
        }
        public void ExcluirRegistro()
        {
            int id = tabelaCompromisso.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um compromisso para poder excluir!", "Exclusão de Compromisso",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Compromisso compromissoSelecionado = controladorCompromisso.SelecionarPorId(id);

            if (MessageBox.Show($"Tem ceerteza que deseja remover um compromisso: [{compromissoSelecionado.Assunto}] ?",
                "Exclusão de Compromisso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                controladorCompromisso.Excluir(id);

                List<Compromisso> compromissos = controladorCompromisso.SelecionarTodos();

                tabelaCompromisso.AtualizarRegistros(compromissos);

                TelaPrincipalForm.Instancia.AtualizarRodape($"Compromisso: [{compromissoSelecionado.Assunto}] removida com sucesso");
            }
        }
        public UserControl ObterTabela()
        {
            List<Compromisso> compromissos = controladorCompromisso.SelecionarTodos();

            tabelaCompromisso.AtualizarRegistros(compromissos);

            return tabelaCompromisso;
        }
        public void FiltrarRegistros()
        {

        }
    }
}
