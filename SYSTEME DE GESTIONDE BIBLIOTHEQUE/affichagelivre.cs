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
    public partial class affichagelivre : Form
    {
        public affichagelivre()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LoadData()
        {
            using (SqlConnection con = new SqlConnection("data source=DESKTOP-QR500FV\\SQLEXPRESS;database=biblioteque;integrated security=True"))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM LIVREE", con))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                }
            }
        }

        private void affichagelivre_Load(object sender, EventArgs e)
        {
            panel3.Visible = false;
          
            LoadData();
        }
        Int32 idl;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
          
               
            }
           
            
                panel3.Visible = true;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=DESKTOP-QR500FV\\SQLEXPRESS;database=biblioteque;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from LIVREE";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                idl = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
                textauteur.Text = ds.Tables[0].Rows[0][1].ToString();
                textBox1.Text = ds.Tables[0].Rows[0][2].ToString();
                textpub.Text = ds.Tables[0].Rows[0][3].ToString();
                datelivre.Text = ds.Tables[0].Rows[0][4].ToString();
                textprix.Text = ds.Tables[0].Rows[0][5].ToString();
                textquan.Text = ds.Tables[0].Rows[0][6].ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textrech.Clear();
            panel3.Visible = false;
        }

        private void button1_TextChanged(object sender, EventArgs e)
        {
           


        }

        private void butupdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("data will be update.Confirmer ?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string L_Nom = textBox1.Text;
                string L_auteur = textauteur.Text;
                string L_Publ = textpub.Text;
                string L_Date = datelivre.Text;
                Int32 L_Price = Int32.Parse(textprix.Text);
                Int32 L_Quan = Int32.Parse(textquan.Text);
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=DESKTOP-QR500FV\\SQLEXPRESS;database=biblioteque;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "update LIVREE set  L_Nom =' " + L_Nom + "',L_auteur ='" + L_auteur + "',L_Publ ='" + L_Publ + "', L_Date ='" + L_Date + "',L_Price =" + L_Price + ",L_Quan =" + L_Quan + "where id =" + idl + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                string updateQuery = "UPDATE Livres SET Quantite = Quantite - @QuantiteAchete WHERE Id = @IdLivreAchete;";
                LoadData();
            }


        }

        private void butdelet_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("data will be update.Confirmer ?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=DESKTOP-QR500FV\\SQLEXPRESS;database=biblioteque;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from  LIVREE where id=" + idl + " ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                LoadData();
            }
               
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void datelivre_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textpub_TextChanged(object sender, EventArgs e)
        {

        }

        private void textquan_TextChanged(object sender, EventArgs e)
        {

        }

        private void textprix_TextChanged(object sender, EventArgs e)
        {

        }

        private void textauteur_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textrech_TextChanged(object sender, EventArgs e)
        {
            

            string query;
            if (!string.IsNullOrEmpty(textrech.Text))
            {
                query = "SELECT * FROM LIVREE WHERE L_Nom LIKE @SearchText";
            }
            else
            {
                query = "SELECT * FROM LIVREE";
            }

            LoadData(query, textrech.Text);
        }

        private void LoadData(string query, string searchText)
        {
            using (SqlConnection con = new SqlConnection("data source=DESKTOP-QR500FV\\SQLEXPRESS;database=biblioteque;integrated security=True"))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    if (query.Contains("@SearchText"))
                    {
                        cmd.Parameters.AddWithValue("@SearchText", searchText + "%");
                    }

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                }
            }
        }
    }
}
