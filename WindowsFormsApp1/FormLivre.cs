using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bibliotheque.BOL;
using Bibliotheque.DAL;

namespace GestionPretForm
{
    public partial class FormLivre : Form
    {
        HashSet<Livre> livres;

        public FormLivre()
        {
            InitializeComponent();
            DB.DbConnectionString = Properties.Settings.Default.BibliothequeConnectString;
        }

        private void FormLivre_Load(object sender, EventArgs e)
        {
            livres = LivreDAO.Instance.GetAll();
            livreBindingSource.DataSource = livres;
        }
    }
}
