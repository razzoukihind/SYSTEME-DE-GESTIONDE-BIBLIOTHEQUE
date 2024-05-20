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
using static System.Net.Mime.MediaTypeNames;

namespace SYSTEME_DE_GESTIONDE_BIBLIOTHEQUE
{
    public partial class affichageetidiant : Form
    {
        private int ide;
        public affichageetidiant()
        {
            InitializeComponent();
        }
        public void conx()
        {
             SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=DESKTOP-QR500FV\\SQLEXPRESS;database=biblioteque;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
        }
        private void LoadData()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=DESKTOP-QR500FV\\SQLEXPRESS;database=biblioteque;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from etudiant ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void affichageetidiant_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            LoadData();
           
        }

        private void butexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butdelt_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("data will be delete.Confirmer ?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=DESKTOP-QR500FV\\SQLEXPRESS;database=biblioteque;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from etudiant where idE=" + ide + " ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                LoadData();
            }
        }

        private void butupdate_Click(object sender, EventArgs e)
        {
           
            if (textnom.Text != "" && texNO.Text != "" && textDEP.Text != "" && textsem.Text != "" && textEmail.Text != "")
            {
                string nomE = textnom.Text;
                string numE = texNO.Text;
                string depE = textDEP.Text;
                string semE = textsem.Text;
                long ConcE = Int64.Parse(textcant.Text);
                string emailE = textEmail.Text;
                

                using (SqlConnection con = new SqlConnection("data source=DESKTOP-QR500FV\\SQLEXPRESS;database=biblioteque;integrated security=True"))
                {
                    string query = "UPDATE etudiant SET nomE = @nomE, numE = @numE, depE = @depE, semE = @semE, ConcE = @ConcE, emailE = @emailE WHERE idE = @idE";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@nomE", nomE);
                        cmd.Parameters.AddWithValue("@numE", numE);
                        cmd.Parameters.AddWithValue("@depE", depE);
                        cmd.Parameters.AddWithValue("@semE", semE);
                        cmd.Parameters.AddWithValue("@ConcE", ConcE);
                        cmd.Parameters.AddWithValue("@emailE", emailE);
                        cmd.Parameters.AddWithValue("@idE", ide);

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadData();
            }
        }
        private void buttrafrich_Click(object sender, EventArgs e)
        {

            textnom.Clear();
            panel2.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=DESKTOP-QR500FV\\SQLEXPRESS;database=biblioteque;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from etudiant where numE LIKE'" + textBox1.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=DESKTOP-QR500FV\\SQLEXPRESS;database=biblioteque;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from etudiant";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                int idE = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                
            }
            panel2.Visible = true;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=DESKTOP-QR500FV\\SQLEXPRESS;database=biblioteque;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from etudiant";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            ide = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
            textnom.Text = ds.Tables[0].Rows[0][1].ToString();
            texNO.Text = ds.Tables[0].Rows[0][2].ToString();
            textDEP.Text = ds.Tables[0].Rows[0][3].ToString();
            textsem.Text = ds.Tables[0].Rows[0][4].ToString();
            textcant.Text = ds.Tables[0].Rows[0][5].ToString();
            textEmail.Text = ds.Tables[0].Rows[0][6].ToString();
            LoadData();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
