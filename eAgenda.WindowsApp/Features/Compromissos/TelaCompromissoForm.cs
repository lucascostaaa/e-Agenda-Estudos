using eAgenda.Dominio.CompromissoModule;
using eAgenda.Dominio.ContatoModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WindowsApp.Features.Compromissos
{
    public partial class TelaCompromissoForm : Form
    {
        private Compromisso compromisso;
        public TelaCompromissoForm()
        {
            InitializeComponent();
        }
        public Compromisso Compromisso
        {
            get { return compromisso; }

            set
            {
                compromisso = value;

                textId.Text = compromisso.Id.ToString();
                textBoxAssunto.Text = compromisso.Assunto;
                TextLink.Text = compromisso.Link;
                textLocal.Text = compromisso.Local;
                dateTimePickerData.Text = compromisso.Data.ToShortDateString();
                maskedTextBoxHoraInicio.Text = compromisso.HoraInicio.ToString();
                maskedTextBoxHoraTermino.Text = compromisso.HoraTermino.ToString();

            }
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            string assunto = textBoxAssunto.Text;
            string link = TextLink.Text;
            string local = textLocal.Text;
            DateTime data = Convert.ToDateTime(dateTimePickerData.Text);
            TimeSpan horaInicio = Convert.ToDateTime(maskedTextBoxHoraInicio.Text).TimeOfDay;
            TimeSpan horaTermino = Convert.ToDateTime(maskedTextBoxHoraTermino.Text).TimeOfDay;
        }
    }
}
