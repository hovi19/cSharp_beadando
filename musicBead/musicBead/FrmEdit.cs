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

    public partial class FrmEdit : Form
    {
        SqlConnection conn;
        string track;
        public FrmEdit(SqlConnection conn, string track)
        {
            this.conn = conn;
            this.track = track;
            InitializeComponent();

        }

        private void FrmEdit_Load(object sender, EventArgs e)
        {
            conn.Open();
            var cmd = new SqlCommand(
                "SELECT tracks.title, length, album, url FROM tracks " +
                $"WHERE tracks.title = '{track}' ;", conn);

            var r = cmd.ExecuteReader();
            while (r.Read())
            {
                tbTitle.Text = r[0].ToString();
                tbLenght.Text = r[1].ToString();
                tbAlbum.Text = r[2].ToString();
                tbUrl.Text = r[3].ToString();
            }
            r.Close();
            conn.Close();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure to edit this item?",
                                          "Confirm Edit!",
                                          MessageBoxButtons.OKCancel);
            if (confirm == DialogResult.OK)
            {
                conn.Open();
                var cmd = new SqlCommand(
                    "UPDATE tracks " +
                    $"SET title ='{tbTitle.Text}', " +
                    $"length ='{TimeSpan.Parse(tbLenght.Text)}', " +
                    $"album ='{tbAlbum.Text}', " +
                    $"url ='{tbUrl.Text}' " +
                    $"WHERE title = '{track}'" , conn);
                var r = cmd.ExecuteReader();
                r.Close();
                conn.Close();

                MessageBox.Show("item edited!");
                this.Close();
            }
            

        }
    }
}
