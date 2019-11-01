﻿namespace AirBnB_Project
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
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(164, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 623);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 773);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // editButton
            // 
            this.editButton.AccessibleDescription = "Edit a record";
            this.editButton.AutoSize = true;
            this.editButton.BackColor = System.Drawing.Color.White;
            this.editButton.BackgroundImage = global::AirBnB_Project.Properties.Resources.edit2;
            this.editButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Arial", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.editButton.Location = new System.Drawing.Point(13, 18);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(134, 153);
            this.editButton.TabIndex = 4;
            this.editButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // addButton
            // 
            this.addButton.AccessibleDescription = "Add Records";
            this.addButton.BackColor = System.Drawing.Color.White;
            this.addButton.BackgroundImage = global::AirBnB_Project.Properties.Resources.add;
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Arial", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.addButton.Location = new System.Drawing.Point(13, 177);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(134, 153);
            this.addButton.TabIndex = 4;
            this.addButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.AccessibleDescription = "Search Records";
            this.searchButton.BackColor = System.Drawing.Color.White;
            this.searchButton.BackgroundImage = global::AirBnB_Project.Properties.Resources.search1;
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Arial", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.searchButton.Location = new System.Drawing.Point(13, 336);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(134, 153);
            this.searchButton.TabIndex = 3;
            this.searchButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.searchButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.AccessibleDescription = "Delete Records";
            this.deleteButton.BackColor = System.Drawing.Color.White;
            this.deleteButton.BackgroundImage = global::AirBnB_Project.Properties.Resources.remove;
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Arial", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.deleteButton.Location = new System.Drawing.Point(12, 495);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.deleteButton.Size = new System.Drawing.Size(134, 153);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(794, 657);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button deleteButton;
    }
}

