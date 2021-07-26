
namespace eAgenda.WindowsApp.Features.Contatos
{
    partial class FiltroDeContatos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rdbContatosEmpresa = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.radioButtonDesagrupar = new System.Windows.Forms.RadioButton();
            this.radioButtonContatosCargos = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rdbContatosEmpresa
            // 
            this.rdbContatosEmpresa.AutoSize = true;
            this.rdbContatosEmpresa.Location = new System.Drawing.Point(152, 100);
            this.rdbContatosEmpresa.Name = "rdbContatosEmpresa";
            this.rdbContatosEmpresa.Size = new System.Drawing.Size(228, 17);
            this.rdbContatosEmpresa.TabIndex = 10;
            this.rdbContatosEmpresa.TabStop = true;
            this.rdbContatosEmpresa.Text = "Visualizar contatos agrupados por Empresa";
            this.rdbContatosEmpresa.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(233, 179);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(152, 179);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 7;
            this.btnGravar.Text = "Filtrar";
            this.btnGravar.UseVisualStyleBackColor = true;
            // 
            // radioButtonDesagrupar
            // 
            this.radioButtonDesagrupar.AutoSize = true;
            this.radioButtonDesagrupar.Location = new System.Drawing.Point(152, 67);
            this.radioButtonDesagrupar.Name = "radioButtonDesagrupar";
            this.radioButtonDesagrupar.Size = new System.Drawing.Size(125, 17);
            this.radioButtonDesagrupar.TabIndex = 11;
            this.radioButtonDesagrupar.TabStop = true;
            this.radioButtonDesagrupar.Text = "Desagrupar Contatos";
            this.radioButtonDesagrupar.UseVisualStyleBackColor = true;
            // 
            // radioButtonContatosCargos
            // 
            this.radioButtonContatosCargos.AutoSize = true;
            this.radioButtonContatosCargos.Location = new System.Drawing.Point(152, 132);
            this.radioButtonContatosCargos.Name = "radioButtonContatosCargos";
            this.radioButtonContatosCargos.Size = new System.Drawing.Size(167, 17);
            this.radioButtonContatosCargos.TabIndex = 12;
            this.radioButtonContatosCargos.TabStop = true;
            this.radioButtonContatosCargos.Text = "Visualizar contatos por Cargos";
            this.radioButtonContatosCargos.UseVisualStyleBackColor = true;
            // 
            // FiltroDeContatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 333);
            this.Controls.Add(this.radioButtonContatosCargos);
            this.Controls.Add(this.radioButtonDesagrupar);
            this.Controls.Add(this.rdbContatosEmpresa);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Name = "FiltroDeContatos";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rdbContatosEmpresa;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.RadioButton radioButtonDesagrupar;
        private System.Windows.Forms.RadioButton radioButtonContatosCargos;
    }
}