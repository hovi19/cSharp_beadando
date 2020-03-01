namespace musicBead
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linklab = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.cbArtist = new System.Windows.Forms.ComboBox();
            this.cbAlbum = new System.Windows.Forms.ComboBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.dgvTracks = new System.Windows.Forms.DataGridView();
            this.rtbData = new System.Windows.Forms.RichTextBox();
            this.btnDisco = new System.Windows.Forms.Button();
            this.btnURL = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbCover = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTracks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Artist";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Album";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Search in track\'s title";
            // 
            // linklab
            // 
            this.linklab.AutoSize = true;
            this.linklab.Location = new System.Drawing.Point(448, 268);
            this.linklab.Name = "linklab";
            this.linklab.Size = new System.Drawing.Size(37, 13);
            this.linklab.TabIndex = 2;
            this.linklab.TabStop = true;
            this.linklab.Text = "NOPE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "URL (if any):";
            // 
            // cbArtist
            // 
            this.cbArtist.FormattingEnabled = true;
            this.cbArtist.Location = new System.Drawing.Point(35, 37);
            this.cbArtist.Name = "cbArtist";
            this.cbArtist.Size = new System.Drawing.Size(141, 21);
            this.cbArtist.TabIndex = 4;
            this.cbArtist.SelectedIndexChanged += new System.EventHandler(this.cbArtist_SelectedIndexChanged);
            // 
            // cbAlbum
            // 
            this.cbAlbum.Enabled = false;
            this.cbAlbum.FormattingEnabled = true;
            this.cbAlbum.Location = new System.Drawing.Point(202, 36);
            this.cbAlbum.Name = "cbAlbum";
            this.cbAlbum.Size = new System.Drawing.Size(127, 21);
            this.cbAlbum.TabIndex = 5;
            this.cbAlbum.SelectedIndexChanged += new System.EventHandler(this.cbAlbum_SelectedIndexChanged);
            // 
            // tbSearch
            // 
            this.tbSearch.Enabled = false;
            this.tbSearch.Location = new System.Drawing.Point(33, 89);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(296, 20);
            this.tbSearch.TabIndex = 6;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // dgvTracks
            // 
            this.dgvTracks.AllowUserToAddRows = false;
            this.dgvTracks.AllowUserToDeleteRows = false;
            this.dgvTracks.AllowUserToResizeColumns = false;
            this.dgvTracks.AllowUserToResizeRows = false;
            this.dgvTracks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTracks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvTracks.Location = new System.Drawing.Point(33, 129);
            this.dgvTracks.Name = "dgvTracks";
            this.dgvTracks.RowHeadersVisible = false;
            this.dgvTracks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTracks.Size = new System.Drawing.Size(296, 230);
            this.dgvTracks.TabIndex = 8;
            this.dgvTracks.SelectionChanged += new System.EventHandler(this.dgvTracks_SelectionChanged);
            // 
            // rtbData
            // 
            this.rtbData.Location = new System.Drawing.Point(466, 129);
            this.rtbData.Name = "rtbData";
            this.rtbData.Size = new System.Drawing.Size(180, 120);
            this.rtbData.TabIndex = 9;
            this.rtbData.Text = "";
            // 
            // btnDisco
            // 
            this.btnDisco.Location = new System.Drawing.Point(339, 311);
            this.btnDisco.Name = "btnDisco";
            this.btnDisco.Size = new System.Drawing.Size(106, 48);
            this.btnDisco.TabIndex = 10;
            this.btnDisco.Text = "Add Discography";
            this.btnDisco.UseVisualStyleBackColor = true;
            // 
            // btnURL
            // 
            this.btnURL.Enabled = false;
            this.btnURL.Location = new System.Drawing.Point(451, 311);
            this.btnURL.Name = "btnURL";
            this.btnURL.Size = new System.Drawing.Size(73, 48);
            this.btnURL.TabIndex = 11;
            this.btnURL.Text = "AddURL";
            this.btnURL.UseVisualStyleBackColor = true;
            this.btnURL.Click += new System.EventHandler(this.btnURL_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(530, 311);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(91, 48);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit Selected";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Title";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Length";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "url";
            this.Column3.Name = "Column3";
            this.Column3.Visible = false;
            // 
            // pbCover
            // 
            this.pbCover.Location = new System.Drawing.Point(339, 129);
            this.pbCover.MaximumSize = new System.Drawing.Size(316, 316);
            this.pbCover.Name = "pbCover";
            this.pbCover.Size = new System.Drawing.Size(120, 120);
            this.pbCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCover.TabIndex = 7;
            this.pbCover.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 372);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnURL);
            this.Controls.Add(this.btnDisco);
            this.Controls.Add(this.rtbData);
            this.Controls.Add(this.dgvTracks);
            this.Controls.Add(this.pbCover);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.cbAlbum);
            this.Controls.Add(this.cbArtist);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linklab);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Discography Tracker";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTracks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linklab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbArtist;
        private System.Windows.Forms.ComboBox cbAlbum;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.PictureBox pbCover;
        private System.Windows.Forms.RichTextBox rtbData;
        private System.Windows.Forms.Button btnDisco;
        private System.Windows.Forms.Button btnURL;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView dgvTracks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

