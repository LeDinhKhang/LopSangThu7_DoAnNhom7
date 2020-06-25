using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnNhom7.Views
{
    public partial class FrmCategory : Form
    {
        frmSP SP;
        public FrmCategory()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(this.txtNewCategory.Text.Length <=0)
            {
                MessageBox.Show("Write new Category Product", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SP = new frmSP(txtNewCategory.Text.Trim());
            SP.Show();
            this.Close();
            
        }
    }
}
