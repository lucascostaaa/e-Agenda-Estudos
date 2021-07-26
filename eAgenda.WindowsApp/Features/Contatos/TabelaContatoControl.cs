using eAgenda.Controladores.ContatoModule;
using eAgenda.Dominio.ContatoModule;
using eAgenda.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WindowsApp.Features.Contatos
{
    public partial class TabelaContatoControl : UserControl
    {
        ControladorContato controladoresContato = new ControladorContato();
        Subro.Controls.DataGridViewGrouper gridContatoAgrupados = new Subro.Controls.DataGridViewGrouper();

        public TabelaContatoControl()
        {
            InitializeComponent();
            gridContato.ConfigurarGridZebrado();
            gridContato.ConfigurarGridSomenteLeitura();
            gridContato.Columns.AddRange(ObterColunas());
        }
        public DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Email", HeaderText = "E-mail"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Telefone", HeaderText = "Telefone"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Empresa", HeaderText = "Empresa"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Cargo", HeaderText = "Cargo"}

            };

            return colunas;
        }
        public int ObtemIdSelecionado()
        {
            return gridContato.SelecionarId<int>();
        }
        public void AgruparContatosPor(string contatos)
        {
            gridContatoAgrupados.RemoveGrouping();
            gridContatoAgrupados.SetGroupOn(contatos);
            gridContatoAgrupados.Options.ShowGroupName = false;
            gridContatoAgrupados.Options.GroupSortOrder = SortOrder.None;


            foreach(DataGridViewColumn item in gridContato.Columns)
            {
                if(item.DataPropertyName == contatos)
                {
                    item.Visible = false;
                }
            }
            gridContato.RowHeadersVisible = false;
            gridContato.ClearSelection();

        }
        public void DesagruparContatos()
        {
            var contatos = new string[] { "Empresa", "Cargo" };


            gridContatoAgrupados.RemoveGrouping();
            gridContato.RowHeadersVisible = true;

            foreach (var contato in contatos)
                foreach (DataGridViewColumn item in gridContato.Columns)
                    if (item.DataPropertyName == contato)
                        item.Visible = false;

        }
        public void AtualizarRegistros()
        {
            var contatos = controladoresContato.SelecionarTodos();

            CarregarTabela(contatos);
        }
        public void CarregarTabela(List<Contato> contatos)
        {
            gridContato.DataSource = contatos;

            gridContatoAgrupados = new Subro.Controls.DataGridViewGrouper(gridContato);
        }
    }
}
