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
        public FormGoTo()
        {
            InitializeComponent();
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
            int index = DataClass.form1_main.textBox1.GetFirstCharIndexFromLine((int)numericUpDown1.Value);
            if (index == -1)
                DataClass.form1_main.textBox1.SelectionStart = DataClass.form1_main.textBox1.TextLength;
            else
                DataClass.form1_main.textBox1.SelectionStart = index - 1;

            int curr = DataClass.form1_main.textBox1.GetFirstCharIndexOfCurrentLine();
            DataClass.form1_main.textBox1.SelectionStart = curr;
            DataClass.form1_main.Focus();
            Close();
        }        
    }
}
