using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using DoAnNhom7.Models;
namespace DoAnNhom7
{
    public partial class QRCode : Form
    {
        private int totalItem = 0;
        private int itemPerPage = 0;
        SanPham San_Pham ;
        public QRCode(SanPham sanPham)
        {
            InitializeComponent();
            San_Pham = sanPham;
            this.txtTenSP.Text = San_Pham.TenSP;
            this.txtLoaiSP.Text = San_Pham.LoaiSP;
            this.txtPC.Text = San_Pham.NhaSX;
            this.nmrSLSP.Value = Convert.ToInt32( San_Pham.SoLuongSP);
            this.dtpSX.Value = DateTime.Parse(San_Pham.NgaySX.ToString());
            this.dtpHH.Value = DateTime.Parse(San_Pham.NgayHH.ToString());
            this.txtMaSP.Text = San_Pham.MaSP;
            string duLieu = "Name of product:" + txtTenSP.Text + "\t" + "Product category:" + txtLoaiSP.Text +"\t" 
                +"Production company:" +txtPC.Text +"\t" +"Number of products:"
                + Convert.ToString(nmrSLSP.Value) +"\t"+ "Manufacturing date:" + Convert.ToString(dtpSX.Value) + "\t" 
                +"Expiry date:" + Convert.ToString(dtpHH.Value) + "\t" +"Product Code:" + txtMaSP.Text;
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(duLieu, QRCodeGenerator.ECCLevel.H);
            QRCoder.QRCode code = new QRCoder.QRCode(data);
            pictureBoxQRcode.Image = code.GetGraphic(5);
            pictureBoxQRcode.SizeMode = PictureBoxSizeMode.StretchImage;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            itemPerPage = totalItem = 0;
            this.printDocument.PrintPage+= new PrintPageEventHandler(this.PrintQRCode);
          
            this.QRprtDialog.Document = printDocument;
            if (this.QRprtDialog.ShowDialog() == DialogResult.OK)
                    this.printDocument.Print();
        }
        private void PrintQRCode(Object sender, PrintPageEventArgs e)
        {
           
            Graphics myGraphics = this.CreateGraphics();
            e.PageSettings.PaperSize = new PaperSize("A4", 850, 1100);
            float pageWidth = e.PageSettings.PrintableArea.Width;
            float pageHeight = e.PageSettings.PrintableArea.Height;
            Size QR_size = new Size(this.pictureBoxQRcode.Width, this.pictureBoxQRcode.Height);
            Bitmap QRImage = new Bitmap(QR_size.Width, QR_size.Height,myGraphics);
            this.pictureBoxQRcode.DrawToBitmap(QRImage, new Rectangle(0, 0, this.pictureBoxQRcode.Width, this.pictureBoxQRcode.Height));
            if (totalItem>19 && itemPerPage == 1)
                e.Graphics.DrawImage(QRImage, 0, 0);

            int numberOfRowsOnAPage = (int)pageHeight / QR_size.Height;
            int numberOfColumnsOnAPage = (int)pageWidth / QR_size.Width;
            Point[] location = { new Point(0, 0), new Point(0, 1), new Point(0, 2), new Point(0, 3), 
                                 new Point(1, 0), new Point(1, 1), new Point(1, 2), new Point(1, 3), 
                                 new Point(2, 0), new Point(2, 1), new Point(2, 2), new Point(2, 3),
                                 new Point(3, 0), new Point(3, 1), new Point(3, 2), new Point(3, 3),
                                 new Point(4, 0), new Point(4, 1), new Point(4, 2), new Point(4, 3)};
            
            while(this.totalItem<nmrNumberPrint.Value)
            {
                Point current_location = location[totalItem % (numberOfRowsOnAPage * numberOfColumnsOnAPage)];
                e.Graphics.DrawImage(QRImage, current_location.Y * QR_size.Width, current_location.X * QR_size.Height);
                totalItem += 1;
                if(itemPerPage< numberOfRowsOnAPage * numberOfColumnsOnAPage)
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

        private void btnPreview_Click(object sender, EventArgs e)
        {
            itemPerPage = totalItem = 0;
            this.printDocument.PrintPage += new PrintPageEventHandler(this.PrintQRCode);
            this.QRprtPreview.Document = this.printDocument;
            QRprtPreview.ShowDialog();
            this.Close();
        }
    }
}
    