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
using System.Reflection;
using System.IO;

namespace musicBead
{
    public partial class frmMain : Form
    {
        SqlConnection conn;
        public frmMain()
        {
            InitializeComponent();

            AppDomain.CurrentDomain.SetData("DataDirectory",
                Path.GetDirectoryName(Assembly.GetExecutingAssembly()
                .Location)
                .Replace(@"bin\Debug", "Data"));


            conn = new SqlConnection(
                 @"Server=(localdb)\MSSQLLocalDB;" +
                 @"AttachDbFilename=|DataDirectory|\music.mdf;");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            conn.Open();
            var cmd = new SqlCommand(
                "SELECT artist FROM albums " +
                "GROUP BY artist;",conn);
            var r = cmd.ExecuteReader();
            while (r.Read())
            {
                cbArtist.Items.Add(r[0]);
            }
            r.Close();
            conn.Close();
        }

        private void cbArtist_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbAlbum.Enabled = true;
            cbAlbum.Items.Clear();
            conn.Open();
            var cmd = new SqlCommand(
                "SELECT title FROM albums " +
                $"WHERE artist like '{cbArtist.SelectedItem}'", conn);
            var r = cmd.ExecuteReader();
            while (r.Read())
            {
                cbAlbum.Items.Add(r[0]);
            }
            r.Close();
            conn.Close();


        }

        private void cbAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvTracks.Rows.Clear();
            conn.Open();
            var cmd = new SqlCommand(
                "SELECT tracks.title, length, tracks.url " +
                "FROM tracks INNER JOIN albums " +
                "on tracks.album=albums.id " +
                $"WHERE albums.title LIKE '{cbAlbum.SelectedItem}';", conn);

            var r = cmd.ExecuteReader();
            while (r.Read())
            {
                dgvTracks.Rows.Add(r[0], r[1],r[2]);
            }
            r.Close();

            var cmd1 = new SqlCommand(
                "SELECT relase, SUM(DATEDIFF(MINUTE, '0:00:00' ,length)) " +
                "FROM tracks INNER JOIN albums " +
                "on tracks.album=albums.id " +
                $"WHERE albums.title = '{cbAlbum.SelectedItem}' " +
                $"GROUP BY relase; " , conn);
            var r1 = cmd1.ExecuteReader();
            while (r1.Read())
            {
                rtbData.Text = "relase date: " + DateTime.Parse(r1[0].ToString()).ToString("yyyy.MM.dd") + "\nlength:" + int.Parse(r1[1].ToString())/60+" minutes";
            }
            r1.Close();
            conn.Close();

            tbSearch.Enabled = true;

            Picturechange();

           

        }

        private void Picturechange()
        {
            if (cbAlbum.SelectedItem.ToString() == "Hold Your Colour") pbCover.Image = Properties.Resources.Hold_Your_Colour;
            if (cbAlbum.SelectedItem.ToString() == "Immersion") pbCover.Image = Properties.Resources.Immersion;
            if (cbAlbum.SelectedItem.ToString() == "In Silico") pbCover.Image = Properties.Resources.In_Silico;
            if (cbAlbum.SelectedItem.ToString() == "Meteora") pbCover.Image = Properties.Resources.Meteora;
            if (cbAlbum.SelectedItem.ToString() == "Hybrid Theory") pbCover.Image = Properties.Resources.Hybrid_Theory;
            if (cbAlbum.SelectedItem.ToString() == "Minutes To Midnight") pbCover.Image = Properties.Resources.Minutes_To_Midnight;
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            dgvTracks.Rows.Clear();
            conn.Open();
            var cmd = new SqlCommand(
                "SELECT tracks.title, length, url FROM tracks INNER JOIN albums " +
                "on tracks.album=albums.id " +
                $"WHERE albums.title LIKE '{cbAlbum.SelectedItem}'" +
                $"AND tracks.title LIKE '%{tbSearch.Text}%';", conn);

            var r = cmd.ExecuteReader();
            while (r.Read())
            {
                dgvTracks.Rows.Add(r[0], r[1], r[2]);
            }
            r.Close();
            conn.Close();
        }

        private void dgvTracks_SelectionChanged(object sender, EventArgs e)
        {
            linklab.Text = "NOPE";
            if (dgvTracks.SelectedRows.Count != 0)
            {
                btnURL.Enabled = true;
                DataGridViewRow row = this.dgvTracks.SelectedRows[0];
                if (row.Cells["Column3"].Value.ToString()!="null")
                {
                    linklab.Text = "https://youtu.be/" + row.Cells["Column3"].Value;
                    btnURL.Enabled = false;
                }
                
            }

        }

        private void btnURL_Click(object sender, EventArgs e)
        {
            var frm = new frmURL(conn,dgvTracks.SelectedRows[0].Cells["Column1"].Value.ToString());
            frm.ShowDialog(); 
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var frm = new FrmEdit(conn, dgvTracks.SelectedRows[0].Cells["Column1"].Value.ToString());
            frm.ShowDialog();
        }
    }
}
