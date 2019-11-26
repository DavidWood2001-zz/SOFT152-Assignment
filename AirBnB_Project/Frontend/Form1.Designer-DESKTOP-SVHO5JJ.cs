namespace AirBnB_Project
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.lblDistricts = new System.Windows.Forms.Label();
            this.lblNeighbourhoods = new System.Windows.Forms.Label();
            this.lblProperties = new System.Windows.Forms.Label();
            this.picBoxLoadFile2 = new System.Windows.Forms.PictureBox();
            this.picBoxLoadFile = new System.Windows.Forms.PictureBox();
            this.lblLoadFile = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLoadFile2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLoadFile)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Select a File";
            this.openFileDialog1.Filter = "Excel Files|*.csv,*.xlsx,*.xlsm|Text Files|*.txt";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(240, 180);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 266);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(240, 180);
            this.dataGridView2.TabIndex = 3;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(12, 467);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.Size = new System.Drawing.Size(240, 180);
            this.dataGridView3.TabIndex = 4;
            // 
            // lblDistricts
            // 
            this.lblDistricts.AutoSize = true;
            this.lblDistricts.BackColor = System.Drawing.Color.Transparent;
            this.lblDistricts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistricts.ForeColor = System.Drawing.Color.White;
            this.lblDistricts.Location = new System.Drawing.Point(13, 44);
            this.lblDistricts.Name = "lblDistricts";
            this.lblDistricts.Size = new System.Drawing.Size(82, 24);
            this.lblDistricts.TabIndex = 6;
            this.lblDistricts.Text = "Districts";
            // 
            // lblNeighbourhoods
            // 
            this.lblNeighbourhoods.AutoSize = true;
            this.lblNeighbourhoods.BackColor = System.Drawing.Color.Transparent;
            this.lblNeighbourhoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNeighbourhoods.ForeColor = System.Drawing.Color.White;
            this.lblNeighbourhoods.Location = new System.Drawing.Point(13, 245);
            this.lblNeighbourhoods.Name = "lblNeighbourhoods";
            this.lblNeighbourhoods.Size = new System.Drawing.Size(167, 24);
            this.lblNeighbourhoods.TabIndex = 7;
            this.lblNeighbourhoods.Text = "Neighbourhoods";
            // 
            // lblProperties
            // 
            this.lblProperties.AutoSize = true;
            this.lblProperties.BackColor = System.Drawing.Color.Transparent;
            this.lblProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProperties.ForeColor = System.Drawing.Color.White;
            this.lblProperties.Location = new System.Drawing.Point(13, 446);
            this.lblProperties.Name = "lblProperties";
            this.lblProperties.Size = new System.Drawing.Size(105, 24);
            this.lblProperties.TabIndex = 8;
            this.lblProperties.Text = "Properties";
            // 
            // picBoxLoadFile2
            // 
            this.picBoxLoadFile2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxLoadFile2.Location = new System.Drawing.Point(12, 0);
            this.picBoxLoadFile2.Name = "picBoxLoadFile2";
            this.picBoxLoadFile2.Size = new System.Drawing.Size(176, 41);
            this.picBoxLoadFile2.TabIndex = 9;
            this.picBoxLoadFile2.TabStop = false;
            this.picBoxLoadFile2.Click += new System.EventHandler(this.PicBoxLoadFile2_Click);
            // 
            // picBoxLoadFile
            // 
            this.picBoxLoadFile.BackgroundImage = global::AirBnB_Project.Properties.Resources.baseline_note_add_black_48dp;
            this.picBoxLoadFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxLoadFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxLoadFile.Location = new System.Drawing.Point(16, 5);
            this.picBoxLoadFile.Name = "picBoxLoadFile";
            this.picBoxLoadFile.Size = new System.Drawing.Size(37, 36);
            this.picBoxLoadFile.TabIndex = 10;
            this.picBoxLoadFile.TabStop = false;
            this.picBoxLoadFile.Click += new System.EventHandler(this.PicBoxLoadFile_Click);
            // 
            // lblLoadFile
            // 
            this.lblLoadFile.AutoSize = true;
            this.lblLoadFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLoadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadFile.ForeColor = System.Drawing.Color.White;
            this.lblLoadFile.Location = new System.Drawing.Point(60, 13);
            this.lblLoadFile.Name = "lblLoadFile";
            this.lblLoadFile.Size = new System.Drawing.Size(162, 31);
            this.lblLoadFile.TabIndex = 11;
            this.lblLoadFile.Text = "LOAD FILE";
            this.lblLoadFile.Click += new System.EventHandler(this.lblLoadFile_Click);
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1426, 657);
            this.Controls.Add(this.lblLoadFile);
            this.Controls.Add(this.picBoxLoadFile);
            this.Controls.Add(this.picBoxLoadFile2);
            this.Controls.Add(this.lblProperties);
            this.Controls.Add(this.lblNeighbourhoods);
            this.Controls.Add(this.lblDistricts);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Main_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Main_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLoadFile2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLoadFile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label lblDistricts;
        private System.Windows.Forms.Label lblNeighbourhoods;
        private System.Windows.Forms.Label lblProperties;
        private System.Windows.Forms.PictureBox picBoxLoadFile2;
        private System.Windows.Forms.PictureBox picBoxLoadFile;
        private System.Windows.Forms.Label lblLoadFile;
    }
}

