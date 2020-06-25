namespace DoAnNhom7
{
    partial class frmSP
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNewCategory = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.nmrSP = new System.Windows.Forms.NumericUpDown();
            this.btnMaBarecode = new System.Windows.Forms.Button();
            this.btnMaQR = new System.Windows.Forms.Button();
            this.btnDeleteSP = new System.Windows.Forms.Button();
            this.btnAddSP = new System.Windows.Forms.Button();
            this.dtpNgayHH = new System.Windows.Forms.DateTimePicker();
            this.dtpNgaySX = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbLoaiSP = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNhaSX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameSP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tùyChọnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataSP = new System.Windows.Forms.DataGridView();
            this.cTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLoaiSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNhaSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNgaySX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNgayHetHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNumSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.timerSP = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSP)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.LightGreen;
            this.splitContainer1.Panel1.Controls.Add(this.txtMaSP);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.btnNewCategory);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.nmrSP);
            this.splitContainer1.Panel1.Controls.Add(this.btnMaBarecode);
            this.splitContainer1.Panel1.Controls.Add(this.btnMaQR);
            this.splitContainer1.Panel1.Controls.Add(this.btnDeleteSP);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddSP);
            this.splitContainer1.Panel1.Controls.Add(this.dtpNgayHH);
            this.splitContainer1.Panel1.Controls.Add(this.dtpNgaySX);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.cmbLoaiSP);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txtNhaSX);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtNameSP);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataSP);
            this.splitContainer1.Size = new System.Drawing.Size(1109, 603);
            this.splitContainer1.SplitterDistance = 344;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(807, 103);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaSP.Multiline = true;
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(255, 38);
            this.txtMaSP.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(583, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 24);
            this.label7.TabIndex = 21;
            this.label7.Text = "Product code:";
            // 
            // btnNewCategory
            // 
            this.btnNewCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCategory.Location = new System.Drawing.Point(521, 124);
            this.btnNewCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNewCategory.Name = "btnNewCategory";
            this.btnNewCategory.Size = new System.Drawing.Size(29, 26);
            this.btnNewCategory.TabIndex = 20;
            this.btnNewCategory.Text = "+";
            this.btnNewCategory.UseVisualStyleBackColor = true;
            this.btnNewCategory.Click += new System.EventHandler(this.btnNewCategory_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(583, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "Number of products:";
            // 
            // nmrSP
            // 
            this.nmrSP.Location = new System.Drawing.Point(807, 62);
            this.nmrSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nmrSP.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmrSP.Name = "nmrSP";
            this.nmrSP.Size = new System.Drawing.Size(255, 22);
            this.nmrSP.TabIndex = 18;
            this.nmrSP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnMaBarecode
            // 
            this.btnMaBarecode.Enabled = false;
            this.btnMaBarecode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaBarecode.Location = new System.Drawing.Point(940, 185);
            this.btnMaBarecode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMaBarecode.Name = "btnMaBarecode";
            this.btnMaBarecode.Size = new System.Drawing.Size(132, 97);
            this.btnMaBarecode.TabIndex = 17;
            this.btnMaBarecode.Text = "Barcode";
            this.btnMaBarecode.UseVisualStyleBackColor = true;
            this.btnMaBarecode.Click += new System.EventHandler(this.btnMaBar_Click);
            // 
            // btnMaQR
            // 
            this.btnMaQR.Enabled = false;
            this.btnMaQR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaQR.Location = new System.Drawing.Point(781, 183);
            this.btnMaQR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMaQR.Name = "btnMaQR";
            this.btnMaQR.Size = new System.Drawing.Size(143, 98);
            this.btnMaQR.TabIndex = 16;
            this.btnMaQR.Text = "QR Code";
            this.btnMaQR.UseVisualStyleBackColor = true;
            this.btnMaQR.Click += new System.EventHandler(this.btnMaQR_Click);
            // 
            // btnDeleteSP
            // 
            this.btnDeleteSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSP.Location = new System.Drawing.Point(587, 251);
            this.btnDeleteSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteSP.Name = "btnDeleteSP";
            this.btnDeleteSP.Size = new System.Drawing.Size(167, 57);
            this.btnDeleteSP.TabIndex = 15;
            this.btnDeleteSP.Text = "Delete Product";
            this.btnDeleteSP.UseVisualStyleBackColor = true;
            this.btnDeleteSP.Click += new System.EventHandler(this.btnDeleteSP_Click);
            // 
            // btnAddSP
            // 
            this.btnAddSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSP.Location = new System.Drawing.Point(587, 171);
            this.btnAddSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddSP.Name = "btnAddSP";
            this.btnAddSP.Size = new System.Drawing.Size(167, 57);
            this.btnAddSP.TabIndex = 13;
            this.btnAddSP.Text = "Add Product";
            this.btnAddSP.UseVisualStyleBackColor = true;
            this.btnAddSP.Click += new System.EventHandler(this.btnAddSP_Click);
            // 
            // dtpNgayHH
            // 
            this.dtpNgayHH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayHH.Location = new System.Drawing.Point(239, 267);
            this.dtpNgayHH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayHH.Name = "dtpNgayHH";
            this.dtpNgayHH.Size = new System.Drawing.Size(276, 22);
            this.dtpNgayHH.TabIndex = 9;
            this.dtpNgayHH.Value = new System.DateTime(2020, 5, 12, 0, 0, 0, 0);
            // 
            // dtpNgaySX
            // 
            this.dtpNgaySX.CustomFormat = "";
            this.dtpNgaySX.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySX.Location = new System.Drawing.Point(239, 220);
            this.dtpNgaySX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgaySX.Name = "dtpNgaySX";
            this.dtpNgaySX.Size = new System.Drawing.Size(276, 22);
            this.dtpNgaySX.TabIndex = 9;
            this.dtpNgaySX.Value = new System.DateTime(2020, 5, 12, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Expiry Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Manufacturing Date:";
            // 
            // cmbLoaiSP
            // 
            this.cmbLoaiSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiSP.FormattingEnabled = true;
            this.cmbLoaiSP.Items.AddRange(new object[] {
            "Văn Phòng Phẩm, Sách",
            "Đồ Gia Dụng",
            "Thiết Bị Điện Tử",
            "Nước Uống",
            "Thực Phẩm Tươi Sống",
            "Thực Phẩm Khô"});
            this.cmbLoaiSP.Location = new System.Drawing.Point(239, 124);
            this.cmbLoaiSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbLoaiSP.Name = "cmbLoaiSP";
            this.cmbLoaiSP.Size = new System.Drawing.Size(276, 24);
            this.cmbLoaiSP.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Product category:";
            // 
            // txtNhaSX
            // 
            this.txtNhaSX.Location = new System.Drawing.Point(239, 158);
            this.txtNhaSX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNhaSX.Multiline = true;
            this.txtNhaSX.Name = "txtNhaSX";
            this.txtNhaSX.Size = new System.Drawing.Size(276, 37);
            this.txtNhaSX.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Production company:";
            // 
            // txtNameSP
            // 
            this.txtNameSP.Location = new System.Drawing.Point(239, 62);
            this.txtNameSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNameSP.Multiline = true;
            this.txtNameSP.Name = "txtNameSP";
            this.txtNameSP.Size = new System.Drawing.Size(276, 37);
            this.txtNameSP.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name of product:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tùyChọnToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1109, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tùyChọnToolStripMenuItem
            // 
            this.tùyChọnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoátToolStripMenuItem});
            this.tùyChọnToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.tùyChọnToolStripMenuItem.Name = "tùyChọnToolStripMenuItem";
            this.tùyChọnToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.tùyChọnToolStripMenuItem.Text = "Menu";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            this.thoátToolStripMenuItem.Text = "Exit";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(82, 29);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // dataSP
            // 
            this.dataSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cTenSP,
            this.cLoaiSP,
            this.cNhaSX,
            this.cNgaySX,
            this.cNgayHetHan,
            this.cNumSP,
            this.cMaSP});
            this.dataSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataSP.Location = new System.Drawing.Point(0, 0);
            this.dataSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataSP.Name = "dataSP";
            this.dataSP.RowHeadersWidth = 51;
            this.dataSP.RowTemplate.Height = 24;
            this.dataSP.Size = new System.Drawing.Size(1109, 255);
            this.dataSP.TabIndex = 0;
            this.dataSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSP_CellClick);
            this.dataSP.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSP_CellEndEdit);
            // 
            // cTenSP
            // 
            this.cTenSP.HeaderText = "Name of product";
            this.cTenSP.MinimumWidth = 6;
            this.cTenSP.Name = "cTenSP";
            // 
            // cLoaiSP
            // 
            this.cLoaiSP.HeaderText = "Product Category";
            this.cLoaiSP.MinimumWidth = 6;
            this.cLoaiSP.Name = "cLoaiSP";
            this.cLoaiSP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cLoaiSP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cNhaSX
            // 
            this.cNhaSX.HeaderText = "Production company";
            this.cNhaSX.MinimumWidth = 6;
            this.cNhaSX.Name = "cNhaSX";
            // 
            // cNgaySX
            // 
            this.cNgaySX.HeaderText = "Manufacturing Date";
            this.cNgaySX.MinimumWidth = 6;
            this.cNgaySX.Name = "cNgaySX";
            // 
            // cNgayHetHan
            // 
            this.cNgayHetHan.HeaderText = "Expiry Date";
            this.cNgayHetHan.MinimumWidth = 6;
            this.cNgayHetHan.Name = "cNgayHetHan";
            // 
            // cNumSP
            // 
            this.cNumSP.HeaderText = "Number of Products";
            this.cNumSP.MinimumWidth = 6;
            this.cNumSP.Name = "cNumSP";
            // 
            // cMaSP
            // 
            this.cMaSP.HeaderText = "Product Code";
            this.cMaSP.MinimumWidth = 6;
            this.cMaSP.Name = "cMaSP";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // timerSP
            // 
            this.timerSP.Tick += new System.EventHandler(this.timerSP_Tick);
            // 
            // frmSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 603);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Management App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSP_FormClosing);
            this.Load += new System.EventHandler(this.frmSP_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmrSP)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tùyChọnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Button btnMaQR;
        private System.Windows.Forms.Button btnDeleteSP;
        private System.Windows.Forms.Button btnAddSP;
        private System.Windows.Forms.DateTimePicker dtpNgayHH;
        private System.Windows.Forms.DateTimePicker dtpNgaySX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbLoaiSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNhaSX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataSP;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.NumericUpDown nmrSP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnMaBarecode;
        private System.Windows.Forms.Timer timerSP;
        private System.Windows.Forms.Button btnNewCategory;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLoaiSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNhaSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNgaySX;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNgayHetHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNumSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaSP;
    }
}

