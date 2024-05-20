using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYSTEME_DE_GESTIONDE_BIBLIOTHEQUE
{
    public partial class reutourlivre : Form
    {
        public reutourlivre()
        {
            InitializeComponent();
        }

        private void butrech_Click(object sender, EventArgs e)
        {
           

            using (SqlConnection con = new SqlConnection("data source=DESKTOP-QR500FV\\SQLEXPRESS;database=biblioteque;integrated security=True"))
            {
                con.Open();
                string query = "SELECT * FROM Publications WHERE nump = @nump AND datereutourl IS NULL";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nump", textrecherch.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    dataGridView1.DataSource = ds.Tables[0]; 
                }
                else
                {
                    dataGridView1.DataSource = null; 
                    MessageBox.Show("pas de num d'iscription", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void butRefrech_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            textrecherch.Clear();
        }
        string lnom;
        string ldate;
        int lid;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            panel2.Visible = true;

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                if (int.TryParse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out int parsedValue))
                {
                    lid = parsedValue;
                }
                else
                {
                    
                    MessageBox.Show("La valeur de la cellule sélectionnée n'est pas un nombre valide.", "Erreur de conversion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }

                
                lnom = dataGridView1.Rows[e.RowIndex].Cells[7].Value?.ToString();
                ldate = dataGridView1.Rows[e.RowIndex].Cells[8].Value?.ToString();

                textnom.Text = lnom;
                textpub.Text = ldate;
            }
        }

        private void buttraturn_Click(object sender, EventArgs e)
        {


            
                
                
                using (SqlConnection con = new SqlConnection("data source=DESKTOP-QR500FV\\SQLEXPRESS;database=biblioteque;integrated security=True"))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("update Publications set datereutourl = @datereutourl where nump = @nump and idp = @lid", con))
                    {
                        cmd.Parameters.AddWithValue("@datereutourl", dateTimePicker1.Value); // Utilisez Value au lieu de Text pour les DateTimePicker
                        cmd.Parameters.AddWithValue("@nump", textrecherch.Text);
                        cmd.Parameters.AddWithValue("@lid", lid);
                        cmd.ExecuteNonQuery();
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Publications", con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }

                butRefrech_Click(this, null);
              

            
        }

        private void butcancel_Click(object sender, EventArgs e)
        {
           panel2.Visible=false;
        }

        private void butexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
    

