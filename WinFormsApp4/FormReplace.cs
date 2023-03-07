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
    public partial class FormReplace : Form
    {
        int id;
        int startIndex;
        public FormReplace(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (DataClass.errorForm[id] != null)
                DataClass.errorForm[id].Close();

            StringComparison comparisonType = StringComparison.OrdinalIgnoreCase;

            if (checkBoxRegister.Checked)
                comparisonType = StringComparison.Ordinal;

            startIndex = DataClass.form1_main[id].textBox1.Text.IndexOf(searchField.Text, startIndex, comparisonType);

            if (startIndex < 0)
            {
                DataClass.errorForm[id] = new ErrorForm();
                DataClass.errorForm[id].label1.Text = $"Не удается найти: {searchField.Text}";
                DataClass.errorForm[id].Show();
                startIndex = 0;
                return;
            }
            else
            {
                DataClass.form1_main[id].textBox1.Focus();
                DataClass.form1_main[id].textBox1.SelectionLength = 0;
                DataClass.form1_main[id].textBox1.SelectionStart = startIndex;
                DataClass.form1_main[id].textBox1.SelectionLength = searchField.TextLength;
                startIndex++;
            }
        }

        private void buttonReplace_Click(object sender, EventArgs e)
        {
            if(DataClass.form1_main[id].textBox1.SelectedText == searchField.Text)
            {
                int selectionStartPos = DataClass.form1_main[id].textBox1.SelectionStart;

                DataClass.form1_main[id].textBox1.Text = DataClass.form1_main[id].textBox1.Text.Remove(
                    DataClass.form1_main[id].textBox1.SelectionStart, DataClass.form1_main[id].textBox1.SelectionLength);

                DataClass.form1_main[id].textBox1.Text = DataClass.form1_main[id].textBox1.Text.Insert(selectionStartPos, ReplaceField.Text);

                DataClass.form1_main[id].textBox1.SelectionLength = ReplaceField.TextLength;
            }            
        }

        private void buttonReplaceAll_Click(object sender, EventArgs e)
        {
            StringComparison comparisonType = StringComparison.OrdinalIgnoreCase;

            if (checkBoxRegister.Checked)
                comparisonType = StringComparison.Ordinal;

            string textBeforeReplace = DataClass.form1_main[id].textBox1.Text;

            DataClass.form1_main[id].textBox1.Text = DataClass.form1_main[id].textBox1.Text.Replace(searchField.Text, ReplaceField.Text, comparisonType);

            if(textBeforeReplace == DataClass.form1_main[id].textBox1.Text)
            {
                DataClass.errorForm[id] = new ErrorForm();
                DataClass.errorForm[id].label1.Text = "Замена не произошла, не найден искомый текст";
                DataClass.errorForm[id].Show();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBoxRegister_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void searchField_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReplaceField_TextChanged(object sender, EventArgs e)
        {

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
    }
}
