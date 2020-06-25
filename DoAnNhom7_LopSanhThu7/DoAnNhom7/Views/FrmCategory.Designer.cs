namespace DoAnNhom7.Views
{
    partial class FrmCategory
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
            this.txtNewCategory = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Category Product:";
            // 
            // txtNewCategory
            // 
            this.txtNewCategory.Location = new System.Drawing.Point(90, 92);
            this.txtNewCategory.Multiline = true;
            this.txtNewCategory.Name = "txtNewCategory";
            this.txtNewCategory.Size = new System.Drawing.Size(323, 47);
            this.txtNewCategory.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Red;
            this.btnAdd.Location = new System.Drawing.Point(214, 166);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 48);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "ADD ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FrmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(516, 269);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNewCategory);
            this.Controls.Add(this.label1);
            this.Name = "FrmCategory";
            this.Text = "FrmCategory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewCategory;
        private System.Windows.Forms.Button btnAdd;
    }
}