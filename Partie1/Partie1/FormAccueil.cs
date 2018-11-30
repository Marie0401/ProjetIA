using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Partie1bis
{
    public partial class FormAccueil : Form
    {
        public FormAccueil()
        {
            InitializeComponent();
        }
        

        private void btnCommencerTest_Click(object sender, EventArgs e)
        {
            Examen_IA Examen_IA= new Examen_IA();
            Examen_IA.Show();
            this.Hide();
        }
    }
}
