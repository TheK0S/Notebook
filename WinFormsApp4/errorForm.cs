using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace WinFormsApp4
{
    public partial class ErrorForm : Form
    {
        public ErrorForm()
        {
            InitializeComponent();
        }

        private void closeButtonErrorForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void closeButtonErrorForm_MouseHover(object sender, EventArgs e)
        {
            closeButtonErrorForm.BackColor = Color.Red;
            closeButtonErrorForm.ForeColor = Color.Black;
        }

        private void closeButtonErrorForm_MouseLeave(object sender, EventArgs e)
        {
            closeButtonErrorForm.BackColor = DefaultBackColor;
            closeButtonErrorForm.ForeColor = Color.DarkGray;
        }
    }
}
