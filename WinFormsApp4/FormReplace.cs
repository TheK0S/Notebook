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
        DataClass formsData;
        int startIndex;
        public FormReplace(ref DataClass formData)
        {
            InitializeComponent();
            this.formsData = formData;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (formsData.errorForm != null)
                formsData.errorForm.Close();

            StringComparison comparisonType = StringComparison.OrdinalIgnoreCase;

            if (checkBoxRegister.Checked)
                comparisonType = StringComparison.Ordinal;

            startIndex = formsData.form1_main.textBox1.Text.IndexOf(searchField.Text, startIndex, comparisonType);

            if (startIndex < 0)
            {
                formsData.errorForm = new ErrorForm(ref formsData);
                formsData.errorForm.label1.Text = $"Не удается найти: {searchField.Text}";
                formsData.errorForm.Show();
                startIndex = 0;
                return;
            }
            else
            {
                formsData.form1_main.textBox1.SelectionLength = 0;
                formsData.form1_main.textBox1.SelectionStart = startIndex;
                formsData.form1_main.textBox1.SelectionLength = searchField.TextLength;
                startIndex++;
            }
        }

        private void buttonReplace_Click(object sender, EventArgs e)
        {
            if(formsData.form1_main.textBox1.SelectedText == searchField.Text)
            {
                int selectionStartPos = formsData.form1_main.textBox1.SelectionStart;

                formsData.form1_main.textBox1.Text = formsData.form1_main.textBox1.Text.Remove(
                    formsData.form1_main.textBox1.SelectionStart, formsData.form1_main.textBox1.SelectionLength);

                formsData.form1_main.textBox1.Text = formsData.form1_main.textBox1.Text.Insert(selectionStartPos, ReplaceField.Text);

                formsData.form1_main.textBox1.SelectionLength = ReplaceField.TextLength;
            }            
        }

        private void buttonReplaceAll_Click(object sender, EventArgs e)
        {
            StringComparison comparisonType = StringComparison.OrdinalIgnoreCase;

            if (checkBoxRegister.Checked)
                comparisonType = StringComparison.Ordinal;

            string textBeforeReplace = formsData.form1_main.textBox1.Text;

            formsData.form1_main.textBox1.Text = formsData.form1_main.textBox1.Text.Replace(searchField.Text, ReplaceField.Text, comparisonType);

            if(textBeforeReplace == formsData.form1_main.textBox1.Text)
            {
                formsData.errorForm = new ErrorForm(ref formsData);
                formsData.errorForm.label1.Text = "Замена не произошла, не найден искомый текст";
                formsData.errorForm.Show();
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
