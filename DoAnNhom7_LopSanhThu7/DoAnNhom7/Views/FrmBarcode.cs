using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnNhom7.Models;
using System.Drawing.Printing;
namespace DoAnNhom7
{
    public partial class FrmBarcode : Form
    {
        private int itemPerPage = 0;
        private int totalItem = 0;
        SanPham San_Pham;
        public FrmBarcode(SanPham sanPham)
        {
            InitializeComponent();
            San_Pham = sanPham;
            this.txtTenSP.Text = San_Pham.TenSP;
            this.txtLoaiSP.Text = San_Pham.LoaiSP;
            this.txtPC.Text = San_Pham.NhaSX;
            this.nmrSLSP.Value = Convert.ToInt32(San_Pham.SoLuongSP);
            this.dtpSX.Value = DateTime.Parse(San_Pham.NgaySX.ToString());
            this.dtpHH.Value = DateTime.Parse(San_Pham.NgayHH.ToString());
            this.txtMaSP.Text = San_Pham.MaSP;
            string duLieu = txtMaSP.Text;
            Zen.Barcode.Code128BarcodeDraw bar = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pictureBoxBR.Image = bar.Draw(duLieu,45);
            pictureBoxBR.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void vtnPreview_Click(object sender, EventArgs e)
        {
            itemPerPage = totalItem = 0;
            this.printDocument.PrintPage += new PrintPageEventHandler(this.PrintBCCode);
            this.BCprtPreview.Document = this.printDocument;
            BCprtPreview.ShowDialog();
            this.Close();
        }

        private void PrintBCCode(object sender, PrintPageEventArgs e)
        {
            Graphics myGraphics = this.CreateGraphics();
            e.PageSettings.PaperSize = new PaperSize("A4", 850, 1100);
            float pageWidth = e.PageSettings.PrintableArea.Width;
            float pageHeight = e.PageSettings.PrintableArea.Height;
            Size BC_size = new Size(this.panel1.Width, this.panel1.Height);
            Bitmap BCImage = new Bitmap(BC_size.Width, BC_size.Height, myGraphics);
            this.pictureBoxBR.DrawToBitmap(BCImage, new Rectangle(0, 0, this.panel1.Width, this.panel1.Height));
            if (totalItem > 19 && itemPerPage == 1)
                e.Graphics.DrawImage(BCImage, 0, 0);

            int numberOfRowsOnAPage = (int)pageHeight / BC_size.Height;
            int numberOfColumnsOnAPage = (int)pageWidth / BC_size.Width;
            Point[] location = {    new Point(0,  0), new Point(0,  1), new Point(0,  2),
                                    new Point(1,  0), new Point(1,  1), new Point(1,  2),
                                    new Point(2,  0), new Point(2,  1), new Point(2,  2),
                                    new Point(3,  0), new Point(3,  1), new Point(3,  2),
                                    new Point(4,  0), new Point(4,  1), new Point(4,  2),
                                    new Point(5,  0), new Point(5,  1), new Point(5,  2),
                                    new Point(6,  0), new Point(6,  1), new Point(6,  2),
                                    new Point(7,  0), new Point(7,  1), new Point(7,  2),
                                    new Point(8,  0), new Point(8,  1), new Point(8,  2),
                                    new Point(9,  0), new Point(9,  1), new Point(9,  2),
                                    new Point(10, 0), new Point(10, 1), new Point(10, 2),
                                    new Point(11, 0), new Point(11, 1), new Point(11, 2),
                                    new Point(12, 0), new Point(12, 1), new Point(12, 2)   };

            while (this.totalItem < nmrNumberPrint.Value)
            {
                Point current_location = location[totalItem % (numberOfRowsOnAPage * numberOfColumnsOnAPage)];
                e.Graphics.DrawImage(BCImage, current_location.Y * BC_size.Width, current_location.X * BC_size.Height);
                totalItem += 1;
                if (itemPerPage < numberOfRowsOnAPage * numberOfColumnsOnAPage)
                {
                    itemPerPage += 1;
                    e.HasMorePages = false;
                }
                else
                {
                    itemPerPage = 1;
                    e.HasMorePages = true;
                    return;
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            itemPerPage = totalItem = 0;
            this.printDocument.PrintPage += new PrintPageEventHandler(this.PrintBCCode);

            this.BCprtDialog.Document = printDocument;
            if (this.BCprtDialog.ShowDialog() == DialogResult.OK)
                this.printDocument.Print();
        }
    }
}
