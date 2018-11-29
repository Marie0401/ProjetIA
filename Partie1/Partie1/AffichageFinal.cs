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
    public partial class AffichageFinal : Form
    {
        public AffichageFinal()
        {
            InitializeComponent();
            lblAffichageScoreFinal.Text = "Score final : " + score + "/20 "; 
        }

        private void btnFinTest_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
