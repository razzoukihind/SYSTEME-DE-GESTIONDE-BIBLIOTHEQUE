using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYSTEME_DE_GESTIONDE_BIBLIOTHEQUE
{
    public partial class ajouterlivre : Form
    {
        public ajouterlivre()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void butajouter_Click(object sender, EventArgs e)
        {
            if (textnom.Text != "" && textauteur.Text != "" && textpub.Text != "" && textprix.Text != "" && textquan.Text != "") 
            {
                string L_Nom = textnom.Text;
                string L_auteur = textauteur.Text;
                string L_Publ = textpub.Text;
                string L_Date = datelivre.Text;
                Int32 L_Price = Int32.Parse(textprix.Text);
                Int32 L_Quan = Int32.Parse(textquan.Text);
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=DESKTOP-QR500FV\\SQLEXPRESS;database=biblioteque;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "insert into LIVREE values('" + L_Nom + "','" + L_auteur + "','" + L_Publ + "','" + L_Date + "'," + L_Price + "," + L_Quan + ")";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Données ajoutées avec succès", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textnom.Text = textauteur.Text = textpub.Text = textprix.Text = textquan.Text = string.Empty;

            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void butexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Êtes-vous sûr de vouloir quitter ?", "Confirmer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void ajouterlivre_Load(object sender, EventArgs e)
        {

        }
    }
}
