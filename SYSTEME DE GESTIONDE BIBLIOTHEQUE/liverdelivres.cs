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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace SYSTEME_DE_GESTIONDE_BIBLIOTHEQUE
{
    public partial class liverdelivres : Form
    {
        private int count;
        public liverdelivres()
        {
            InitializeComponent();
        }

        private void liverdelivres_Load(object sender, EventArgs e)
        {
           


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=DESKTOP-QR500FV\\SQLEXPRESS;database=biblioteque;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "SELECT L_Nom FROM LIVREE"; // Corrected SQL query
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["L_Nom"].ToString()); // Use column name in SqlDataReader
            }
            dr.Close();
            con.Close();

        }
       
        private void butrech_Click(object sender, EventArgs e)
        {
          
            string eid = textBox1.Text;
            using (SqlConnection con = new SqlConnection("data source=DESKTOP-QR500FV\\SQLEXPRESS;database=biblioteque;integrated security=True"))
            {
                con.Open();
                string query1 = "SELECT * FROM etudiant WHERE numE = @eid";
                SqlCommand cmd1 = new SqlCommand(query1, con);
                cmd1.Parameters.AddWithValue("@eid", eid);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                string query2 = "SELECT count(nump) FROM Publications WHERE nump = @eid AND datereutourl IS NULL";
                SqlCommand cmd2 = new SqlCommand(query2, con);
                cmd2.Parameters.AddWithValue("@eid", eid);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                DataSet ds2 = new DataSet();
                da2.Fill(ds2);

                count = Convert.ToInt32(ds2.Tables[0].Rows[0][0]);

                if (ds1.Tables[0].Rows.Count != 0)
                {
                    textnom.Text = ds1.Tables[0].Rows[0][1].ToString();
                    textDEP.Text = ds1.Tables[0].Rows[0][3].ToString();
                    textsem.Text = ds1.Tables[0].Rows[0][4].ToString();
                    textcant.Text = ds1.Tables[0].Rows[0][5].ToString();
                    textEmail.Text = ds1.Tables[0].Rows[0][6].ToString();
                }
                else
                {
                    textnom.Text = textDEP.Text = textsem.Text = textcant.Text = textEmail.Text = string.Empty;
                    MessageBox.Show("Invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }






        }

        private void butdeliver_Click(object sender, EventArgs e)
        {
            
            if (textnom.Text != "")
            {
                if (comboBox1.SelectedIndex != -1 && count <= 2) 
                {
                    string nump = textBox1.Text;
                    string nomp = textnom.Text;
                    string depp = textDEP.Text;
                    string semp = textsem.Text;
                    long Concp = Int64.Parse(textcant.Text);
                    string emailp = textEmail.Text;
                    string noml = comboBox1.Text;
                    string datel = dateTimePicker1.Text;
                    string datereutourl = null; 

                    using (SqlConnection con = new SqlConnection("data source=DESKTOP-QR500FV\\SQLEXPRESS;database=biblioteque;integrated security=True"))
                    {
                        con.Open();

                        
                        string updateQuery = "UPDATE LIVREE SET L_Quan = L_Quan - 1 WHERE L_Nom = @noml;";

                        
                        SqlCommand updateCmd = new SqlCommand(updateQuery, con);

                        
                        updateCmd.Parameters.AddWithValue("@noml", noml); // Nom du livre acheté

                        
                        updateCmd.ExecuteNonQuery();
                        string eid=textBox1.Text;
                        
                        string insertQuery = "INSERT INTO Publications (nump, nomp, depp, semp, Concp, emailp, noml, datel, datereutourl) " +
                                             "VALUES (@nump, @nomp, @depp, @semp, @Concp, @emailp, @noml, @datel, @datereutourl)";

                        
                        SqlCommand insertCmd = new SqlCommand(insertQuery, con);

                   
                        insertCmd.Parameters.AddWithValue("@nump", nump); // Numéro de publication
                        insertCmd.Parameters.AddWithValue("@nomp", nomp); // Nom de l'emprunteur
                        insertCmd.Parameters.AddWithValue("@depp", depp); // Département de l'emprunteur
                        insertCmd.Parameters.AddWithValue("@semp", semp); // Semestre de l'emprunteur
                        insertCmd.Parameters.AddWithValue("@Concp", Concp); // Numéro de téléphone
                        insertCmd.Parameters.AddWithValue("@emailp", emailp); // Email de l'emprunteur
                        insertCmd.Parameters.AddWithValue("@noml", noml); // Nom du livre
                        insertCmd.Parameters.AddWithValue("@datel", datel); // Date de sortie
                      

                        if (string.IsNullOrEmpty(datereutourl))
                        {
                            insertCmd.Parameters.AddWithValue("@datereutourl", DBNull.Value); 
                        }
                        else
                        {
                            insertCmd.Parameters.AddWithValue("@datereutourl", datereutourl); 
                        }

                        insertCmd.ExecuteNonQuery();
                        MessageBox.Show("pub livre", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    
                    MessageBox.Show("Nombre maximum de livres atteint pour cet étudiant.", "No livre ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }




        }

        private void butRefrech_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

        }

        private void butexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
