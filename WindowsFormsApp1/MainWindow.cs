using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPretForm
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GestionDesPrêts_Click(object sender, EventArgs e)
        {
            FormPret newMDIChild = new FormPret();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void GestionDesAdherentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdherent newMDIChild = new FormAdherent();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }
    }
}
