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
            this.lblDistrict = new System.Windows.Forms.Label();
            this.lblNeighbourhood = new System.Windows.Forms.Label();
            this.lblProperty = new System.Windows.Forms.Label();
            this.lblLoadFile = new System.Windows.Forms.Label();
            this.lstBoxDistrict = new System.Windows.Forms.ListBox();
            this.lstBoxNeighbourhood = new System.Windows.Forms.ListBox();
            this.lstBoxProperty = new System.Windows.Forms.ListBox();
            this.mapBox = new System.Windows.Forms.PictureBox();
            this.picBoxLoadFile = new System.Windows.Forms.PictureBox();
            this.picBoxLoadFile2 = new System.Windows.Forms.PictureBox();
            this.grpBoxPropInfo = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPropName = new System.Windows.Forms.TextBox();
            this.txtHostID = new System.Windows.Forms.TextBox();
            this.txtHostName = new System.Windows.Forms.TextBox();
            this.txtNumProps = new System.Windows.Forms.TextBox();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.txtMinStays = new System.Windows.Forms.TextBox();
            this.txtAvailability = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.txtPropID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBoxDelete = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.comboDelete = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grpBoxEdit = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.mapBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLoadFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLoadFile2)).BeginInit();
            this.grpBoxPropInfo.SuspendLayout();
            this.grpBoxDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Select a File";
            this.openFileDialog1.Filter = "Text Files|*.txt|Excel Files|*.csv,*.xlsx,*.xlsm";
            // 
            // lblDistrict
            // 
            this.lblDistrict.AutoSize = true;
            this.lblDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistrict.ForeColor = System.Drawing.Color.White;
            this.lblDistrict.Location = new System.Drawing.Point(13, 44);
            this.lblDistrict.Margin = new System.Windows.Forms.Padding(3, 50, 3, 0);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(82, 24);
            this.lblDistrict.TabIndex = 6;
            this.lblDistrict.Text = "Districts";
            // 
            // lblNeighbourhood
            // 
            this.lblNeighbourhood.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNeighbourhood.AutoSize = true;
            this.lblNeighbourhood.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNeighbourhood.ForeColor = System.Drawing.Color.White;
            this.lblNeighbourhood.Location = new System.Drawing.Point(13, 232);
            this.lblNeighbourhood.Name = "lblNeighbourhood";
            this.lblNeighbourhood.Size = new System.Drawing.Size(167, 24);
            this.lblNeighbourhood.TabIndex = 7;
            this.lblNeighbourhood.Text = "Neighbourhoods";
            // 
            // lblProperty
            // 
            this.lblProperty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblProperty.AutoSize = true;
            this.lblProperty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProperty.ForeColor = System.Drawing.Color.White;
            this.lblProperty.Location = new System.Drawing.Point(13, 419);
            this.lblProperty.Name = "lblProperty";
            this.lblProperty.Size = new System.Drawing.Size(105, 24);
            this.lblProperty.TabIndex = 8;
            this.lblProperty.Text = "Properties";
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
            // lstBoxDistrict
            // 
            this.lstBoxDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxDistrict.FormattingEnabled = true;
            this.lstBoxDistrict.ItemHeight = 25;
            this.lstBoxDistrict.Location = new System.Drawing.Point(12, 65);
            this.lstBoxDistrict.Name = "lstBoxDistrict";
            this.lstBoxDistrict.Size = new System.Drawing.Size(494, 129);
            this.lstBoxDistrict.TabIndex = 12;
            this.lstBoxDistrict.SelectedIndexChanged += new System.EventHandler(this.LstBoxDistrict_SelectedIndexChanged);
            // 
            // lstBoxNeighbourhood
            // 
            this.lstBoxNeighbourhood.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lstBoxNeighbourhood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxNeighbourhood.ItemHeight = 25;
            this.lstBoxNeighbourhood.Location = new System.Drawing.Point(12, 253);
            this.lstBoxNeighbourhood.Name = "lstBoxNeighbourhood";
            this.lstBoxNeighbourhood.Size = new System.Drawing.Size(494, 129);
            this.lstBoxNeighbourhood.TabIndex = 13;
            this.lstBoxNeighbourhood.SelectedIndexChanged += new System.EventHandler(this.LstBoxNeighbourhood_SelectedIndexChanged);
            // 
            // lstBoxProperty
            // 
            this.lstBoxProperty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lstBoxProperty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxProperty.FormattingEnabled = true;
            this.lstBoxProperty.ItemHeight = 25;
            this.lstBoxProperty.Location = new System.Drawing.Point(12, 440);
            this.lstBoxProperty.Margin = new System.Windows.Forms.Padding(3, 3, 3, 50);
            this.lstBoxProperty.Name = "lstBoxProperty";
            this.lstBoxProperty.Size = new System.Drawing.Size(494, 129);
            this.lstBoxProperty.TabIndex = 14;
            this.lstBoxProperty.SelectedIndexChanged += new System.EventHandler(this.LstBoxProperty_SelectedIndexChanged);
            // 
            // mapBox
            // 
            this.mapBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mapBox.BackgroundImage = global::AirBnB_Project.Properties.Resources.NYC_map;
            this.mapBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mapBox.Location = new System.Drawing.Point(881, 44);
            this.mapBox.Name = "mapBox";
            this.mapBox.Size = new System.Drawing.Size(560, 524);
            this.mapBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.mapBox.TabIndex = 37;
            this.mapBox.TabStop = false;
            this.mapBox.Paint += new System.Windows.Forms.PaintEventHandler(this.MapBox_Paint);
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
            // grpBoxPropInfo
            // 
            this.grpBoxPropInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpBoxPropInfo.Controls.Add(this.btnEdit);
            this.grpBoxPropInfo.Controls.Add(this.btnAdd);
            this.grpBoxPropInfo.Controls.Add(this.txtPropName);
            this.grpBoxPropInfo.Controls.Add(this.txtHostID);
            this.grpBoxPropInfo.Controls.Add(this.txtHostName);
            this.grpBoxPropInfo.Controls.Add(this.txtNumProps);
            this.grpBoxPropInfo.Controls.Add(this.txtLatitude);
            this.grpBoxPropInfo.Controls.Add(this.txtLongitude);
            this.grpBoxPropInfo.Controls.Add(this.txtMinStays);
            this.grpBoxPropInfo.Controls.Add(this.txtAvailability);
            this.grpBoxPropInfo.Controls.Add(this.txtPrice);
            this.grpBoxPropInfo.Controls.Add(this.txtRoomType);
            this.grpBoxPropInfo.Controls.Add(this.txtPropID);
            this.grpBoxPropInfo.Controls.Add(this.label11);
            this.grpBoxPropInfo.Controls.Add(this.label10);
            this.grpBoxPropInfo.Controls.Add(this.label9);
            this.grpBoxPropInfo.Controls.Add(this.label8);
            this.grpBoxPropInfo.Controls.Add(this.label7);
            this.grpBoxPropInfo.Controls.Add(this.label6);
            this.grpBoxPropInfo.Controls.Add(this.label5);
            this.grpBoxPropInfo.Controls.Add(this.label4);
            this.grpBoxPropInfo.Controls.Add(this.label3);
            this.grpBoxPropInfo.Controls.Add(this.label2);
            this.grpBoxPropInfo.Controls.Add(this.label1);
            this.grpBoxPropInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxPropInfo.ForeColor = System.Drawing.Color.White;
            this.grpBoxPropInfo.Location = new System.Drawing.Point(12, 599);
            this.grpBoxPropInfo.Name = "grpBoxPropInfo";
            this.grpBoxPropInfo.Size = new System.Drawing.Size(942, 262);
            this.grpBoxPropInfo.TabIndex = 41;
            this.grpBoxPropInfo.TabStop = false;
            this.grpBoxPropInfo.Text = "Property Information";
            // 
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(851, 217);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 37);
            this.btnEdit.TabIndex = 60;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(760, 217);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 37);
            this.btnAdd.TabIndex = 59;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtPropName
            // 
            this.txtPropName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPropName.Location = new System.Drawing.Point(272, 50);
            this.txtPropName.Name = "txtPropName";
            this.txtPropName.ReadOnly = true;
            this.txtPropName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtPropName.Size = new System.Drawing.Size(188, 29);
            this.txtPropName.TabIndex = 58;
            // 
            // txtHostID
            // 
            this.txtHostID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtHostID.Location = new System.Drawing.Point(272, 77);
            this.txtHostID.Name = "txtHostID";
            this.txtHostID.ReadOnly = true;
            this.txtHostID.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtHostID.Size = new System.Drawing.Size(188, 29);
            this.txtHostID.TabIndex = 57;
            // 
            // txtHostName
            // 
            this.txtHostName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtHostName.Location = new System.Drawing.Point(272, 108);
            this.txtHostName.Name = "txtHostName";
            this.txtHostName.ReadOnly = true;
            this.txtHostName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtHostName.Size = new System.Drawing.Size(188, 29);
            this.txtHostName.TabIndex = 56;
            // 
            // txtNumProps
            // 
            this.txtNumProps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNumProps.Location = new System.Drawing.Point(272, 137);
            this.txtNumProps.Name = "txtNumProps";
            this.txtNumProps.ReadOnly = true;
            this.txtNumProps.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtNumProps.Size = new System.Drawing.Size(188, 29);
            this.txtNumProps.TabIndex = 55;
            // 
            // txtLatitude
            // 
            this.txtLatitude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLatitude.Location = new System.Drawing.Point(272, 199);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.ReadOnly = true;
            this.txtLatitude.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtLatitude.Size = new System.Drawing.Size(188, 29);
            this.txtLatitude.TabIndex = 54;
            // 
            // txtLongitude
            // 
            this.txtLongitude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLongitude.Location = new System.Drawing.Point(272, 229);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.ReadOnly = true;
            this.txtLongitude.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtLongitude.Size = new System.Drawing.Size(188, 29);
            this.txtLongitude.TabIndex = 53;
            // 
            // txtMinStays
            // 
            this.txtMinStays.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMinStays.Location = new System.Drawing.Point(725, 16);
            this.txtMinStays.Name = "txtMinStays";
            this.txtMinStays.ReadOnly = true;
            this.txtMinStays.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtMinStays.Size = new System.Drawing.Size(188, 29);
            this.txtMinStays.TabIndex = 52;
            // 
            // txtAvailability
            // 
            this.txtAvailability.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAvailability.Location = new System.Drawing.Point(725, 43);
            this.txtAvailability.Name = "txtAvailability";
            this.txtAvailability.ReadOnly = true;
            this.txtAvailability.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtAvailability.Size = new System.Drawing.Size(188, 29);
            this.txtAvailability.TabIndex = 51;
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrice.Location = new System.Drawing.Point(725, 71);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtPrice.Size = new System.Drawing.Size(188, 29);
            this.txtPrice.TabIndex = 50;
            // 
            // txtRoomType
            // 
            this.txtRoomType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtRoomType.Location = new System.Drawing.Point(272, 166);
            this.txtRoomType.Margin = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.ReadOnly = true;
            this.txtRoomType.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtRoomType.Size = new System.Drawing.Size(188, 29);
            this.txtRoomType.TabIndex = 49;
            // 
            // txtPropID
            // 
            this.txtPropID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPropID.Location = new System.Drawing.Point(272, 21);
            this.txtPropID.Name = "txtPropID";
            this.txtPropID.ReadOnly = true;
            this.txtPropID.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtPropID.Size = new System.Drawing.Size(188, 29);
            this.txtPropID.TabIndex = 48;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(30, 76);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 24);
            this.label11.TabIndex = 47;
            this.label11.Text = "Host ID";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(30, 105);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 24);
            this.label10.TabIndex = 46;
            this.label10.Text = "Host Name";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(30, 134);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(282, 24);
            this.label9.TabIndex = 45;
            this.label9.Text = "Number of Properties Owned";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(32, 198);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 24);
            this.label8.TabIndex = 44;
            this.label8.Text = "Latitude";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(30, 226);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 24);
            this.label7.TabIndex = 43;
            this.label7.Text = "Longitude";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(497, 13);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 24);
            this.label6.TabIndex = 42;
            this.label6.Text = "Minimum Stay (days)";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(497, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 24);
            this.label5.TabIndex = 41;
            this.label5.Text = "Availability (days per year)";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(496, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 24);
            this.label4.TabIndex = 40;
            this.label4.Text = "Price (£)";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(30, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 5, 0, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 39;
            this.label3.Text = "Room Type";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 24);
            this.label2.TabIndex = 38;
            this.label2.Text = "Property Name";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 50, 3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 37;
            this.label1.Text = "Property ID ";
            // 
            // grpBoxDelete
            // 
            this.grpBoxDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.grpBoxDelete.Controls.Add(this.label12);
            this.grpBoxDelete.Controls.Add(this.txtDelete);
            this.grpBoxDelete.Controls.Add(this.comboDelete);
            this.grpBoxDelete.Controls.Add(this.btnDelete);
            this.grpBoxDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxDelete.ForeColor = System.Drawing.Color.White;
            this.grpBoxDelete.Location = new System.Drawing.Point(960, 599);
            this.grpBoxDelete.Name = "grpBoxDelete";
            this.grpBoxDelete.Size = new System.Drawing.Size(185, 262);
            this.grpBoxDelete.TabIndex = 42;
            this.grpBoxDelete.TabStop = false;
            this.grpBoxDelete.Text = "Delete";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 24);
            this.label12.TabIndex = 44;
            this.label12.Text = "Delete this?";
            // 
            // txtDelete
            // 
            this.txtDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelete.Location = new System.Drawing.Point(16, 108);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(142, 24);
            this.txtDelete.TabIndex = 43;
            // 
            // comboDelete
            // 
            this.comboDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDelete.FormattingEnabled = true;
            this.comboDelete.Location = new System.Drawing.Point(16, 36);
            this.comboDelete.Name = "comboDelete";
            this.comboDelete.Size = new System.Drawing.Size(142, 26);
            this.comboDelete.TabIndex = 42;
            this.comboDelete.Text = "Select what to delete";
            this.comboDelete.SelectedIndexChanged += new System.EventHandler(this.ComboDelete_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(16, 207);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 37);
            this.btnDelete.TabIndex = 41;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // grpBoxEdit
            // 
            this.grpBoxEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxEdit.ForeColor = System.Drawing.Color.White;
            this.grpBoxEdit.Location = new System.Drawing.Point(1156, 599);
            this.grpBoxEdit.Name = "grpBoxEdit";
            this.grpBoxEdit.Size = new System.Drawing.Size(686, 262);
            this.grpBoxEdit.TabIndex = 43;
            this.grpBoxEdit.TabStop = false;
            this.grpBoxEdit.Text = "Edit";
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(500, 400);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(1854, 873);
            this.Controls.Add(this.grpBoxEdit);
            this.Controls.Add(this.grpBoxDelete);
            this.Controls.Add(this.grpBoxPropInfo);
            this.Controls.Add(this.mapBox);
            this.Controls.Add(this.lstBoxProperty);
            this.Controls.Add(this.lstBoxNeighbourhood);
            this.Controls.Add(this.lstBoxDistrict);
            this.Controls.Add(this.lblLoadFile);
            this.Controls.Add(this.picBoxLoadFile);
            this.Controls.Add(this.picBoxLoadFile2);
            this.Controls.Add(this.lblProperty);
            this.Controls.Add(this.lblNeighbourhood);
            this.Controls.Add(this.lblDistrict);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Main_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Main_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.mapBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLoadFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLoadFile2)).EndInit();
            this.grpBoxPropInfo.ResumeLayout(false);
            this.grpBoxPropInfo.PerformLayout();
            this.grpBoxDelete.ResumeLayout(false);
            this.grpBoxDelete.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.Label lblNeighbourhood;
        private System.Windows.Forms.Label lblProperty;
        private System.Windows.Forms.PictureBox picBoxLoadFile2;
        private System.Windows.Forms.PictureBox picBoxLoadFile;
        private System.Windows.Forms.Label lblLoadFile;
        private System.Windows.Forms.ListBox lstBoxDistrict;
        private System.Windows.Forms.ListBox lstBoxProperty;
        private System.Windows.Forms.ListBox lstBoxNeighbourhood;
        private System.Windows.Forms.PictureBox mapBox;
        private System.Windows.Forms.GroupBox grpBoxPropInfo;
        private System.Windows.Forms.TextBox txtPropName;
        private System.Windows.Forms.TextBox txtHostID;
        private System.Windows.Forms.TextBox txtHostName;
        private System.Windows.Forms.TextBox txtNumProps;
        private System.Windows.Forms.TextBox txtLatitude;
        private System.Windows.Forms.TextBox txtLongitude;
        private System.Windows.Forms.TextBox txtMinStays;
        private System.Windows.Forms.TextBox txtAvailability;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtRoomType;
        private System.Windows.Forms.TextBox txtPropID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBoxDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox comboDelete;
        private System.Windows.Forms.GroupBox grpBoxEdit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDelete;
    }
}

