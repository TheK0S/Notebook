using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form2 : Form
    {
        Point lastPoint;
        int searchStartIndex;
        int searchLength;
        public Form2()
        {
            InitializeComponent();
        }

        private void searchField_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void buttonSearch_Click(object sender, EventArgs e)
        {
            if(DataClass.errorForm != null)
                DataClass.errorForm.Close();

            string stringText = DataClass.form1_main.textBox1.Text;
            string searchValue = searchField.Text;

            StringComparison comparisonType = StringComparison.OrdinalIgnoreCase;

            if (checkBoxRegister.Checked)
                comparisonType = StringComparison.Ordinal;

            if (ToDownRadioButton.Checked)
            {
                searchStartIndex = DataClass.form1_main.textBox1.Text.IndexOf(searchField.Text, searchStartIndex, comparisonType);
                
                if (searchStartIndex < 0)
                {
                    DataClass.errorForm = new ErrorForm();
                    DataClass.errorForm.label1.Text = $"Не удается найти: {searchField.Text}";
                    DataClass.errorForm.Show();
                    searchStartIndex = 0;
                    return;
                }
                else
                {
                    DataClass.form1_main.textBox1.Focus();
                    DataClass.form1_main.textBox1.SelectionLength = 0;
                    DataClass.form1_main.textBox1.SelectionStart = searchStartIndex;
                    DataClass.form1_main.textBox1.SelectionLength = searchField.TextLength;                    
                    searchStartIndex += searchField.TextLength;                  
                }
            }
            else if (ToUpRadioButton.Checked)
            {
                if (searchStartIndex == 0)
                    searchStartIndex = DataClass.form1_main.textBox1.Text.Length - 1;

                searchStartIndex = DataClass.form1_main.textBox1.Text.LastIndexOf(searchField.Text, searchStartIndex, comparisonType);

                if (searchStartIndex < 0)
                {
                    DataClass.errorForm = new ErrorForm();
                    DataClass.errorForm.label1.Text = $"Не удается найти: {searchField.Text}";
                    DataClass.errorForm.Show();
                    searchStartIndex = 0;
                    return;
                }
                else
                {
                    DataClass.form1_main.textBox1.Focus();
                    DataClass.form1_main.textBox1.SelectionLength = 0;
                    DataClass.form1_main.textBox1.SelectionStart = searchStartIndex;
                    DataClass.form1_main.textBox1.SelectionLength = searchField.TextLength;
                    searchStartIndex -= searchField.TextLength;
                }
            }
        }

        private void closeButton_MouseHover(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.Red;
            closeButton.ForeColor = Color.Black;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.BackColor = DefaultBackColor;
            closeButton.ForeColor = Color.DarkGray;
        }

        private void buttonSearch_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void buttonSearch_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxRegister_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ToUpRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ToDownRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CancelBatton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
