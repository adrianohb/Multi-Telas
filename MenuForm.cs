using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_Telas
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnBoasvindas_Click(object sender, EventArgs e)
        {
            // Abre a tela de boas vindas;
            BoasVindasForm boasVindasForm = new BoasVindasForm();

            // Esconde o formulário atual;
            this.Hide();

            //Mostra a tela de boas vindas;
            boasVindasForm.Show();

            //Adiciona um evento no formulário de boas vindas
            //que mostra o formulário atdual quandoa fechado

            boasVindasForm.Closed += (object s, EventArgs ev) => this.Show();
        }
    }
}
