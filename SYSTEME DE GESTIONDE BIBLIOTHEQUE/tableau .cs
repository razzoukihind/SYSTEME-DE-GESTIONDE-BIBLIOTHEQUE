using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYSTEME_DE_GESTIONDE_BIBLIOTHEQUE
{
    public partial class tableau : Form
    {
        public tableau()
        {
            InitializeComponent();
        }

        private void ajouterUnNouveauLiverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ajouterlivre l=new ajouterlivre();
            l.Show();
          
            

            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Êtes-vous sûr de vouloir quitter ?","Confirmer",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            //Application.Exit();
            this.Close();
        }

        private void voirLesLivresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            affichagelivre affichagelivre = new affichagelivre();
            affichagelivre.Show();
        }

        private void ajouterUnEtudientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ajouteretudient ajouteretudient = new ajouteretudient();    
            ajouteretudient.Show();
        }

        private void voirLesInformationSurLesEtudiantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            affichageetidiant affichageetidiant = new affichageetidiant();
            affichageetidiant.Show();
        }

        private void liversDePublicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            liverdelivres liverdelivres = new liverdelivres();
            liverdelivres.Show();
        }

        private void retournerLesLiversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reutourlivre reutourlivre = new reutourlivre();
            reutourlivre.Show();
        }

        private void detailCompletDuLiverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            detaildelivre detaildelivre = new detaildelivre();
            detaildelivre.Show();
        }

        private void tableau_Load(object sender, EventArgs e)
        {
             
        }

        private void lIversToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
