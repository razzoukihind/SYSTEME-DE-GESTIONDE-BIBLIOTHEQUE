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
    public partial class detaildelivre : Form
    {
        public detaildelivre()
        {
            InitializeComponent();
        }

        private void detaildelivre_Load(object sender, EventArgs e)
        {
           
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=DESKTOP-QR500FV\\SQLEXPRESS;database=biblioteque;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "select nump, nomp, depp, semp, Concp, emailp, noml, datel, datereutourl from Publications where datereutourl is null ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            
            cmd.CommandText = "select nump, nomp, depp, semp, Concp, emailp, noml, datel, datereutourl from Publications where datereutourl is not null ";
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            dataGridView2.DataSource = ds1.Tables[0];

            con.Close();





        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
