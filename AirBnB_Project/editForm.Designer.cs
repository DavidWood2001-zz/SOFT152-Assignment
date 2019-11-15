namespace AirBnB_Project
{
    partial class editForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.searchSelection = new System.Windows.Forms.ComboBox();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(300, 51);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(454, 28);
            this.txtSearch.TabIndex = 83;
            this.txtSearch.Text = "Enter a district name";
            this.txtSearch.Visible = false;
            this.txtSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseClick);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_EnterPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(15, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(413, 46);
            this.label11.TabIndex = 79;
            this.label11.Text = "Property Information:";
            // 
            // searchSelection
            // 
            this.searchSelection.BackColor = System.Drawing.Color.White;
            this.searchSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchSelection.FormattingEnabled = true;
            this.searchSelection.Items.AddRange(new object[] {
            "District",
            "Neighbourhood",
            "Property"});
            this.searchSelection.Location = new System.Drawing.Point(23, 51);
            this.searchSelection.Name = "searchSelection";
            this.searchSelection.Size = new System.Drawing.Size(270, 30);
            this.searchSelection.TabIndex = 89;
            this.searchSelection.Text = "District";
            this.searchSelection.Visible = false;
            this.searchSelection.SelectedIndexChanged += new System.EventHandler(this.SearchSelection_SelectedIndexChanged);
            // 
            // picSearch
            // 
            this.picSearch.BackgroundImage = global::AirBnB_Project.Properties.Resources.baseline_search_white_48dp;
            this.picSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picSearch.Location = new System.Drawing.Point(761, 39);
            this.picSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(55, 51);
            this.picSearch.TabIndex = 85;
            this.picSearch.TabStop = false;
            this.picSearch.Visible = false;
            this.picSearch.Click += new System.EventHandler(this.PicSearch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AirBnB_Project.Properties.Resources.baseline_add_white_48dp;
            this.pictureBox1.Location = new System.Drawing.Point(613, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.TabIndex = 90;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::AirBnB_Project.Properties.Resources.baseline_delete_forever_white_48dp;
            this.pictureBox2.Location = new System.Drawing.Point(715, 120);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 45);
            this.pictureBox2.TabIndex = 91;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::AirBnB_Project.Properties.Resources.baseline_edit_white_48dp;
            this.pictureBox3.Location = new System.Drawing.Point(664, 120);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 45);
            this.pictureBox3.TabIndex = 92;
            this.pictureBox3.TabStop = false;
            // 
            // editForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.searchSelection);
            this.Controls.Add(this.picSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label11);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "editForm";
            this.Size = new System.Drawing.Size(847, 767);
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox searchSelection;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
