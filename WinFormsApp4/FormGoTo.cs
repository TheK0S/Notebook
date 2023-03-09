using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp4
{
    public partial class FormGoTo : Form
    {
        DataClass formsData;
        public FormGoTo(ref DataClass formsData)
        {
            InitializeComponent();
            this.formsData = formsData;
        }

        private void CancelBatton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void closeButton_MouseHover(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.Red;
            closeButton.ForeColor = Color.Black;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.BackColor = DefaultBackColor;
            closeButton.ForeColor = Color.DarkGray;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Minimum = 1;
        }

        private void buttonGoTo_Click(object sender, EventArgs e)
        {
            int index = formsData.form1_main.textBox1.GetFirstCharIndexFromLine((int)numericUpDown1.Value);
            if (index == -1)
                formsData.form1_main.textBox1.SelectionStart = formsData.form1_main.textBox1.TextLength;
            else
                formsData.form1_main.textBox1.SelectionStart = index - 1;

            int curr = formsData.form1_main.textBox1.GetFirstCharIndexOfCurrentLine();
            formsData.form1_main.textBox1.SelectionStart = curr;
            formsData.form1_main.Focus();
            Close();
        }        
    }
}
