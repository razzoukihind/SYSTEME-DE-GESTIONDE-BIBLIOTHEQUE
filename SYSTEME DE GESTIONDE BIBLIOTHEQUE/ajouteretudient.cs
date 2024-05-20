using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYSTEME_DE_GESTIONDE_BIBLIOTHEQUE
{
    public partial class ajouteretudient : Form
    {
        public ajouteretudient()
        {
            InitializeComponent();
        }
        
           
        private void butdelet_Click(object sender, EventArgs e)
        {

            if (textnom.Text != "" && texNO.Text != "" && textDEP.Text != "" && textsem.Text != "" && textEmail.Text != "")
            {
                string nomE = textnom.Text;
                string numE = texNO.Text;
                string depE = textDEP.Text;
                string semE = textsem.Text;
                long ConcE;
                if (!long.TryParse(textcant.Text, out ConcE))
                {
                    MessageBox.Show("Veuillez saisir une valeur numérique valide pour le champ 'ConcE'.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string emailE = textEmail.Text;

                using (SqlConnection con = new SqlConnection("data source=DESKTOP-QR500FV\\SQLEXPRESS;database=biblioteque;integrated security=True")) 
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO etudiant (nomE, numE, depE, semE, ConcE, emailE) VALUES (@Nom, @Num, @Dep, @Sem, @Conc, @Email)", con);
                        cmd.Parameters.AddWithValue("@Nom", nomE);
                        cmd.Parameters.AddWithValue("@Num", numE);
                        cmd.Parameters.AddWithValue("@Dep", depE);
                        cmd.Parameters.AddWithValue("@Sem", semE);
                        cmd.Parameters.AddWithValue("@Conc", ConcE);
                        cmd.Parameters.AddWithValue("@Email", emailE);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Données ajoutées avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        textnom.Text = texNO.Text = textDEP.Text = textsem.Text = textcant.Text = textEmail.Text = string.Empty;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors de l'insertion des données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Êtes-vous sûr de vouloir quitter ?", "Confirmer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void butrafr_Click(object sender, EventArgs e)
        {
            textnom.Text = texNO.Text = textDEP.Text = textsem.Text = textcant.Text = textEmail.Text = string.Empty;

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
