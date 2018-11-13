using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Partie2
{
    public partial class Examen_IA_partie2 : Form
    {
        List<string> L_Ouverts_Calcules;
        List<string> L_Fermes_Calcules;
        string L_Ouverts_Donnes_Uti;
        string L_Fermes_Donnes_Uti;

        public Examen_IA_partie2()
        {
            InitializeComponent();
        }

        private void btn_Valider_Click(object sender, EventArgs e)
        {
            L_Ouverts_Donnes_Uti = txtBox_ListeOuverts.Text;
            L_Fermes_Donnes_Uti = txtBox_ListeFermes.Text;
        }
    }
}
