using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace musicBead
{
    public partial class frmURL : Form
    {
        SqlConnection conn;
        public frmURL(SqlConnection conn,string track)
        {
            this.conn = conn;
            InitializeComponent();
            lblCheck.Text = track;

     
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var u = tbURL.Text.Split('/');
            var r = u[3];


            conn.Open();

            var cmd = new SqlCommand(
                    "UPDATE tracks " +
                    $"SET url ='{r}' " +
                    $"WHERE title = '{lblCheck.Text}'; ", conn);
            var a = cmd.ExecuteReader();
            
            a.Close();
            conn.Close();

            MessageBox.Show("URL added!");
            this.Close();

        }

        private void tbURL_TextChanged(object sender, EventArgs e)
        {
            if (tbURL.Text.Contains("https://youtu.be/"))
            {
                btnAdd.Enabled = true;
            }
            else btnAdd.Enabled = false;
        }
    }
}
