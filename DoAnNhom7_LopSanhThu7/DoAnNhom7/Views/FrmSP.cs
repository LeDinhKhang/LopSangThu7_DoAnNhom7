using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnNhom7.Controllers;
using DoAnNhom7.Models;
using DoAnNhom7.Views;

namespace DoAnNhom7
{
    public partial class frmSP : Form
    {
        #region Bien
        DateTimePicker dtp;
        DateTimePicker dtp1;
        NumericUpDown nmr;
        QRCode QRcode;
        FrmBarcode BRcode;
        FrmCategory Category;
        System.Windows.Forms.ComboBox cmbCategory;
        #endregion
        public frmSP()
        {
            InitializeComponent();
            this.dtpNgaySX.Value = DateTime.Now;
            this.dtpNgayHH.Value = DateTime.Now;
            this.cTenSP.DataPropertyName = nameof(SanPham.TenSP);
            this.cLoaiSP.DataPropertyName = nameof(SanPham.LoaiSP);
            this.cNhaSX.DataPropertyName = nameof(SanPham.NhaSX);
            this.cNgaySX.DataPropertyName = nameof(SanPham.NgaySX);
            this.cNgayHetHan.DataPropertyName = nameof(SanPham.NgayHH);
            this.cNumSP.DataPropertyName = nameof(SanPham.SoLuongSP);
            this.cMaSP.DataPropertyName = nameof(SanPham.MaSP);
            BindingSource source = new BindingSource();
            source.DataSource = SanPhamController.getListSanPham();
            this.dataSP.DataSource = source;
            timerSP.Start();
        }
        public frmSP(string category) :this()
        {
            cmbLoaiSP.Items.Add(category);
        }
         
            
        


        private void frmSP_Load(object sender, EventArgs e)
        {
            // xử lí help
            this.helpProvider1.SetShowHelp(this.txtNameSP, true);
            this.helpProvider1.SetHelpString(this.txtNameSP, "write name of product!");
            this.helpProvider1.SetShowHelp(this.cmbLoaiSP, true);
            this.helpProvider1.SetHelpString(this.cmbLoaiSP, "choose a product category!");
            this.helpProvider1.SetShowHelp(this.txtNhaSX, true);
            this.helpProvider1.SetHelpString(this.txtNhaSX, "write name of production company");
            this.helpProvider1.SetShowHelp(this.dtpNgaySX, true);
            this.helpProvider1.SetHelpString(this.dtpNgaySX, "choose manufacturing date!");
            this.helpProvider1.SetShowHelp(this.dtpNgayHH, true);
            this.helpProvider1.SetHelpString(this.dtpNgayHH, "choose expiry date!");
            this.helpProvider1.SetShowHelp(this.nmrSP, true);
            this.helpProvider1.SetHelpString(this.nmrSP, "number of product!");
            this.helpProvider1.SetShowHelp(this.txtMaSP, true);
            this.helpProvider1.SetHelpString(this.txtMaSP, "code of product!");

        }

        private void btnMaQR_Click(object sender, EventArgs e)
        {
            if (this.QRcode is null || this.QRcode.IsDisposed)
            {
                try
                {
                    SanPham SP = SanPhamController.getSanPham(this.dataSP.CurrentRow.Cells[0].Value.ToString());
                    if (SP.NgaySX >= SP.NgayHH)
                    {
                        MessageBox.Show("Manufacturing date, Expiry date is invalid", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    // hiện form QR
                    this.QRcode = new QRCode(SP);
                    QRcode.Show();
                }
                catch
                {
                    MessageBox.Show("Re-enter the product", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            
        }
        private void btnMaBar_Click(object sender, EventArgs e)
        {
            if (this.BRcode is null || this.BRcode.IsDisposed)
            {
                SanPham SP = SanPhamController.getSanPham(this.dataSP.CurrentRow.Cells[0].Value.ToString());
                // hiện form QR
                if (SP.NgaySX >= SP.NgayHH)
                {
                    MessageBox.Show("Manufacturing date, Expiry date is invalid", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                this.BRcode = new FrmBarcode(SP);
                BRcode.Show();
            }
        }
        private void btnAddSP_Click(object sender, EventArgs e)
        {
            

            // xử lí thông báo lỗi 
            if (txtNameSP.Text.Trim().Length <=0)
            {
                this.errorProvider1.SetError(txtNameSP, "Write name of product, please!");
                return;
            }
            else if(SanPhamController.getSanPham(txtNameSP.Text.Trim()) != null)
            {
                this.errorProvider1.SetError(txtNameSP, "As name of product, please!");
                return;
            }
            if(cmbLoaiSP.Text.Trim().Length <=0)
            {
                this.errorProvider1.SetError(cmbLoaiSP, "choose a product category, please!");
                return;
            }
            if(txtNhaSX.Text.Trim().Length <=0)
            {
                this.errorProvider1.SetError(txtNhaSX, "Write name of production company, please!");
                return;
            }
            DateTime SX = this.dtpNgaySX.Value;
            DateTime HH = this.dtpNgayHH.Value;
            if(SX >= HH)
            {
                this.errorProvider1.SetError(dtpNgayHH, "expiry date is ");
                return;
            }
            if(nmrSP.Value <=0)
            {
                this.errorProvider1.SetError(nmrSP, "the number of products must be greater than one!");
                return;
            }
            if(txtMaSP.Text.Length <= 0)
            {
                this.errorProvider1.SetError(txtMaSP, "Write code of product, please!");
                return;
            }
            // xử lí thêm sản phẩm vào datagridview
            SanPham Sp = new SanPham();
            Sp.TenSP = this.txtNameSP.Text.Trim();
            Sp.LoaiSP = this.cmbLoaiSP.Text.Trim();
            Sp.NhaSX = this.txtNhaSX.Text.Trim();
            Sp.NgaySX = this.dtpNgaySX.Value;
            Sp.NgayHH = this.dtpNgayHH.Value;
            Sp.SoLuongSP = Convert.ToInt32(this.nmrSP.Value);
            Sp.MaSP = this.txtMaSP.Text.Trim();
            // thêm sản phẩm vào database
            if ((SanPhamController.AddSanPham(Sp)) == false)
            {
                MessageBox.Show("error add user");
                return;
            }


            // sau khi them san pham sẽ reset lại các ô để người dùng nhập dữ liệu tiếp theo
            this.errorProvider1.Clear();
            this.txtNameSP.Clear();
            this.txtNhaSX.Clear();
            this.txtMaSP.Clear();
            this.dtpNgaySX.Value = DateTime.Now;
            this.dtpNgayHH.Value = DateTime.Now;
            // hiện sản phẩm lên datagridview
            BindingSource source = new BindingSource();
            source.DataSource = SanPhamController.getListSanPham();
            this.dataSP.DataSource = source;


        }

        private void frmSP_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure want to quit ?", "Announcement", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                e.Cancel = true;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 0 && this.dataSP.CurrentCell.Value != null)
            {
                MessageBox.Show("Not rename of product!");
                return;
            }
            if(e.ColumnIndex == 1)
            {
                cmbCategory = new System.Windows.Forms.ComboBox();
                cmbCategory.Items.Add("Văn Phòng Phẩm, Sách");
                cmbCategory.Items.Add("Đồ Gia Dụng");
                cmbCategory.Items.Add("Thiết Bị Điện Tử");
                cmbCategory.Items.Add("Nước Uống");
                cmbCategory.Items.Add("Thực Phẩm Tươi Sống");
                cmbCategory.Items.Add("Thực Phẩm Khô");
                cmbCategory.Visible = true;
                Rectangle rect = this.dataSP.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                cmbCategory.Location = new Point(rect.X, rect.Y);
                cmbCategory.Size = new Size(rect.Width, rect.Height);
                if (this.dataSP.CurrentCell.Value is null)
                {
                    dataSP.CurrentCell.Value = "Nước Uống";
                }
                else
                {
                    cmbCategory.Text = this.dataSP.CurrentCell.Value.ToString();
                }
                cmbCategory.TextChanged += CmbCategory_TextChanged;
                cmbCategory.DropDownClosed += CmbCategory_DropDownClosed;
                this.dataSP.Controls.Add(cmbCategory);
            }
            if (e.ColumnIndex == 3)
            {
                dtp = new DateTimePicker();
                dtp.Format = DateTimePickerFormat.Short;
                dtp.Visible = true;
                Rectangle rect = this.dataSP.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                dtp.Location = new Point(rect.X, rect.Y);
                dtp.Size = new Size(rect.Width, rect.Height);
                if (this.dataSP.CurrentCell.Value is null)
                {
                    dataSP.CurrentCell.Value = "01/01/1999";
                }
                else
                {
                    dtp.Value = DateTime.Parse(this.dataSP.CurrentCell.Value.ToString());
                }
                dtp.CloseUp += Dtp_CloseUp;
                dtp.TextChanged += Dtp_TextChanged;
                this.dataSP.Controls.Add(dtp);
            }
            if (e.ColumnIndex == 4)
            {
                dtp1 = new DateTimePicker();
                dtp1.Format = DateTimePickerFormat.Short;
                dtp1.Visible = true;
                Rectangle rect = this.dataSP.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                dtp1.Location = new Point(rect.X, rect.Y);
                dtp1.Size = new Size(rect.Width, rect.Height);
                if (this.dataSP.CurrentCell.Value is null)
                {
                    dataSP.CurrentCell.Value = "01/01/1999";
                }
                else
                {
                    dtp1.Value = DateTime.Parse(this.dataSP.CurrentCell.Value.ToString());
                }
                dtp1.CloseUp += Dtp1_CloseUp;
                dtp1.TextChanged += Dtp1_TextChanged;
                this.dataSP.Controls.Add(dtp1);
            }
            if (e.ColumnIndex == 5)
            {
                nmr = new NumericUpDown();
                nmr.Maximum = 9999;
                nmr.Visible = true;
                Rectangle rec = this.dataSP.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                nmr.Location = new Point(rec.X, rec.Y);
                nmr.Size = new Size(rec.Width, rec.Height);
                if(dataSP.CurrentCell.Value is null)
                {
                    dataSP.CurrentCell.Value = "1";
                }
                else
                {
                    nmr.Value = Convert.ToInt32(dataSP.CurrentCell.Value.ToString());
                }
                nmr.ValueChanged += Nmr_ValueChanged;
                nmr.Leave += Nmr_Leave;
                this.dataSP.Controls.Add(nmr);
            }
        }

        private void CmbCategory_DropDownClosed(object sender, EventArgs e)
        {
            cmbCategory.Visible = false;
            //cmbCategory.Dispose();
        }

        private void CmbCategory_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.dataSP.CurrentCell.Value = this.cmbCategory.SelectedItem.ToString();
            }
            catch { return; }
            SanPham SP = SanPhamController.getSanPham(this.dataSP.CurrentRow.Cells[0].Value.ToString());
            SP.LoaiSP = this.cmbCategory.SelectedItem.ToString();
            SanPhamController.UpdateSanPham(SP);
        }

        private void Dtp1_TextChanged(object sender, EventArgs e)
        {
            this.dataSP.CurrentCell.Value = this.dtp1.Value.ToString();
            SanPham SP = SanPhamController.getSanPham(this.dataSP.CurrentRow.Cells[0].Value.ToString());
            SP.NgayHH = Convert.ToDateTime(this.dtp1.Value.ToString());
            SanPhamController.UpdateSanPham(SP);
        }

        private void Dtp1_CloseUp(object sender, EventArgs e)
        {
            dtp1.Visible = false;
            dtp1.Dispose();
        }

        private void Nmr_Leave(object sender, EventArgs e)
        {
            nmr.Visible = false;
            //nmr.Dispose();
        }

        private void Nmr_ValueChanged(object sender, EventArgs e)
        {
            this.dataSP.CurrentCell.Value = nmr.Value.ToString();
            SanPham SP = SanPhamController.getSanPham(this.dataSP.CurrentRow.Cells[0].Value.ToString());
            SP.SoLuongSP = Convert.ToInt32( nmr.Value);
            SanPhamController.UpdateSanPham(SP);
        }

        private void Dtp_TextChanged(object sender, EventArgs e)
        {
            this.dataSP.CurrentCell.Value = this.dtp.Value.ToString();
            SanPham SP = SanPhamController.getSanPham(this.dataSP.CurrentRow.Cells[0].Value.ToString());
            SP.NgaySX = Convert.ToDateTime(this.dtp.Value.ToString());
            SanPhamController.UpdateSanPham(SP);
        }

        private void Dtp_CloseUp(object sender, EventArgs e)
        {
            dtp.Visible = false;
            dtp.Dispose();

        }

        private void btnDeleteSP_Click(object sender, EventArgs e)
        {
            if(SanPhamController.SoLuongSP() ==0)
            {
                MessageBox.Show("Không có dữ liệu để xóa", "Thông Báo");
                return;
            }
            SanPham SP = SanPhamController.getSanPham(this.dataSP.CurrentRow.Cells[0].Value.ToString());
            SanPhamController.DeleteSanPham(SP);
            BindingSource source = new BindingSource();
            source.DataSource = SanPhamController.getListSanPham();
            this.dataSP.DataSource = source;

        }

        private void dataSP_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            SanPham SP = new SanPham();
            SP.NgaySX = DateTime.Now;
            SP.NgayHH = DateTime.Now;
            if(dataSP.CurrentRow.Cells[0].Value is null)
            {
                MessageBox.Show("write name of product!");
                return;
            }
            else if (SanPhamController.getSanPham(this.dataSP.CurrentRow.Cells[0].Value.ToString()) != null && this.dataSP.CurrentRow.Cells[3].Value is null)
            {
                MessageBox.Show("As name of product", "Warning");
                this.dataSP.Rows.RemoveAt(this.dataSP.CurrentRow.Index);
                return;
            }
            SP.TenSP = this.dataSP.CurrentRow.Cells[0].Value.ToString();
            if (dataSP.CurrentRow.Cells[1].Value is null)
            {
                dataSP.CurrentRow.Cells[1].Value = "Văn Phòng Phẩm, Sách";
            }
            SP.LoaiSP = dataSP.CurrentRow.Cells[1].Value.ToString();
            if (dataSP.CurrentRow.Cells[2].Value is null)
            {
                dataSP.CurrentRow.Cells[2].Value = "";
            }
            SP.NhaSX = dataSP.CurrentRow.Cells[2].Value.ToString();
            if (this.dataSP.CurrentRow.Cells[3].Value is null)
            {
                this.dataSP.CurrentRow.Cells[3].Value = DateTime.Now;
            }
            if(DateTime.Parse(this.dataSP.CurrentRow.Cells[3].Value.ToString()) == DateTime.MinValue)
            {
                this.dataSP.CurrentRow.Cells[3].Value = DateTime.Now;
            }
            SP.NgaySX = DateTime.Parse(dataSP.CurrentRow.Cells[3].Value.ToString());
            if (this.dataSP.CurrentRow.Cells[4].Value is null)
            {
                this.dataSP.CurrentRow.Cells[4].Value = DateTime.Now;
            }
            if (DateTime.Parse(this.dataSP.CurrentRow.Cells[4].Value.ToString()) == DateTime.MinValue)
            {
                this.dataSP.CurrentRow.Cells[4].Value = DateTime.Now;
            }
            SP.NgayHH = DateTime.Parse(dataSP.CurrentRow.Cells[4].Value.ToString());
            if (dataSP.CurrentRow.Cells[5].Value is null)
            {
                dataSP.CurrentRow.Cells[5].Value = "1";
            }
            SP.SoLuongSP = Convert.ToInt32(dataSP.CurrentRow.Cells[5].Value);
            if (dataSP.CurrentRow.Cells[6].Value is null)
            {
                dataSP.CurrentRow.Cells[6].Value = "111111";
            }
            SP.MaSP = dataSP.CurrentRow.Cells[6].Value.ToString();
            SanPhamController.UpdateSanPham(SP);
            CurrencyManager currencyManager = (CurrencyManager)BindingContext[dataSP.DataSource];
            currencyManager.SuspendBinding();
            // Manipulate datasource
            currencyManager.ResumeBinding();


        }

        private void timerSP_Tick(object sender, EventArgs e)
        {
            if(SanPhamController.SoLuongSP() >0)
            {
                this.btnMaQR.Enabled = true;
                this.btnMaBarecode.Enabled = true;
            }
            else
            {
                this.btnMaQR.Enabled = false;
                this.btnMaBarecode.Enabled = false;
            }

        }

        private void btnNewCategory_Click(object sender, EventArgs e)
        {
            if (this.Category is null || this.Category.IsDisposed)
            {
                this.Category = new FrmCategory();
                this.Hide();
                Category.Show();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nhóm 7:" +
                "\n" + "Lê Đình Khang" + "\t" + "18133021" + "\n" + "Trần Gia Nguyên" + "\t" + "18133036" + "\n" + "Nguyễn Ngọc Hòa" + "\t" + "18133014", "Information",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
