using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYSTEME_DE_GESTIONDE_BIBLIOTHEQUE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textnom_MouseClick(object sender, MouseEventArgs e)
        {
            if (textnom.Text == "Nom")
            {
                textnom.Clear();
            }
        }

        private void textpass_MouseClick(object sender, MouseEventArgs e)
        {

            if (textpass.Text == "mot de passe")
            {
                textpass.Clear();
                textpass.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           


            //{
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=DESKTOP-QR500FV\\SQLEXPRESS;database=biblioteque;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM login WHERE Nom=@Nom AND [mot de passe]=@MotDePasse"; // Utilisation de [mot de passe] pour éviter les erreurs de syntaxe
            cmd.Parameters.AddWithValue("@Nom", textnom.Text);
            cmd.Parameters.AddWithValue("@MotDePasse", textpass.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count != 0)
            {
                this.Hide();
                tableau t = new tableau();
                t.Show();
            }
            else
            {
                MessageBox.Show("Erreur nom ou mot de passe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

