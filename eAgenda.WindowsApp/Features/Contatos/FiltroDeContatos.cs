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
    public partial class FiltroDeContatos : Form
    {
        public FiltroDeContatos()
        {
            InitializeComponent();
        }

        public FiltroContatoEnum TipoFiltro
        {
            get
            {
                if (radioButtonDesagrupar.Checked)
                    return FiltroContatoEnum.DesagruparContatos;
                else if (rdbContatosEmpresa.Checked)
                    return FiltroContatoEnum.ContatosAgrupadosEmpresa;
                else
                    return FiltroContatoEnum.ContatosAgrupadosCargo;
            }
        }
    }
}
