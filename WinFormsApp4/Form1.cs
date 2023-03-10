using System.Drawing.Printing;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        uint currentPercentScale = 100;
        DataClass formsData;

        public Form1(ref DataClass formsData)
        {
            InitializeComponent();
            this.formsData = formsData;

            formsData.form2_search = new Form2(ref formsData);

            ���������������ToolStripMenuItem.CheckOnClick = true;
            ���������������ToolStripMenuItem.CheckOnClick = true;
        }

        private void menuHeader_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(textBox1.SelectionLength > 0)
                textBox1.Cut();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            currentSelectedStart.Text = $"��� {textBox1.GetLineFromCharIndex(textBox1.SelectionStart) + 1}, " +
                $"���� {textBox1.SelectionStart - textBox1.GetFirstCharIndexOfCurrentLine()}";
        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0)
                textBox1.Copy();
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
            {
                if(textBox1.SelectionLength > 0)
                {
                    textBox1.SelectionStart += textBox1.SelectionLength;
                }
            }
            textBox1.Paste();
        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConfirmation form = new FormConfirmation();

            if (ShowDialog(form) == DialogResult.OK)
                textBox1.Clear();
            else
                form.Close();
        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength == 0)
                textBox1.SelectionLength = 1;

            textBox1.Cut();
        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formsData.form2_search = new Form2(ref formsData);
            formsData.form2_search.Show();
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formsData.formReplace = new FormReplace(ref formsData);
            formsData.formReplace.Show();
        }

        private void �����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectionStart = 0;
            textBox1.SelectionLength = textBox1.TextLength;
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(textBox1.CanUndo)
            {
                textBox1.Undo();
                textBox1.ClearUndo();
            }
        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formsData.formGoTo = new FormGoTo(ref formsData);
            formsData.formGoTo.Show();
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ��������ToolStripMenuItem.Enabled = textBox1.CanUndo ? true : false;

            ��������ToolStripMenuItem.Enabled = textBox1.SelectionLength > 0 ? true : false;

            ����������ToolStripMenuItem.Enabled = textBox1.SelectionLength > 0 ? true : false;

            ��������ToolStripMenuItem.Enabled = Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) ? true : false;

            �������ToolStripMenuItem.Enabled = textBox1.TextLength > 0 ? true : false;

            �����ToolStripMenuItem.Enabled = textBox1.TextLength > 0 ? true : false;

            ����������ToolStripMenuItem.Enabled = textBox1.TextLength > 0 && formsData.form2_search.Visible ? true : false;

            ����������ToolStripMenuItem.Enabled = textBox1.TextLength > 0 && formsData.form2_search.Visible ? true : false;

            ��������ToolStripMenuItem.Enabled = textBox1.TextLength > 0 ? true : false;

            //�������ToolStripMenuItem.Enabled = textBox1.Lines.Count() > 1 ? true : false;

            �����������ToolStripMenuItem.Enabled = textBox1.TextLength > 0 ? true : false;
        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(formsData.form2_search != null)
            {
                formsData.form2_search.ToDownRadioButton.Checked = true;
                formsData.form2_search.buttonSearch_Click(sender, e);
            }            
        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formsData.form2_search != null)
            {
                formsData.form2_search.ToUpRadioButton.Checked = true;
                formsData.form2_search.buttonSearch_Click(sender, e);
            }            
        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.WriteAllText(openFileDialog1.FileName, textBox1.Text);
        }

        private void ������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
        }

        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newFormData = new DataClass();
            newFormData.form1_main = new Form1(ref newFormData);
            newFormData.form1_main.Show();
        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Insert(textBox1.SelectionStart, DateTime.Now.ToString());
        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            fontDialog1.FontMustExist = true;
            fontDialog1.ShowEffects = true;
            
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
                textBox1.ForeColor = fontDialog1.Color;
            }
        }

        private void ���������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (���������������ToolStripMenuItem.Checked)
                textBox1.WordWrap = true;
            else
                textBox1.WordWrap = false;
        }

        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Font.Size < DefaultFont.Size * 5)
            {
                textBox1.Font = new Font(textBox1.Font.FontFamily, textBox1.Font.Size + 1);
                currentPercentScale += 10;
                currentSelectedStart.Text = $"{currentPercentScale}%";
            }                
        }

        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(textBox1.Font.Size > 1)
            {
                textBox1.Font = new Font(textBox1.Font.FontFamily, textBox1.Font.Size - 1);
                currentPercentScale -= 10;
                currentSelectedStart.Text = $"{currentPercentScale}%";
            }                
        }

        private void ������������������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Font = DefaultFont;
            currentPercentScale = 100;
        }

        private void ������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string referenceLink = "https://www.google.com";

            try
            {
                System.Diagnostics.Process.Start(referenceLink);
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }

        private void ���������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(���������������ToolStripMenuItem.Checked)
            {
                textBox1.Dock = DockStyle.Top;
                textBox1.Height = this.Height - 95;
                tableLayoutPanel1.Visible = true;
            }
            else
            {
                tableLayoutPanel1.Visible = false;
                textBox1.Dock = DockStyle.Fill;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Resize(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if(���������������ToolStripMenuItem.Checked)
                textBox1.Height = this.Height - 95;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            formsData.form2_search?.Close();
            formsData.errorForm?.Close();
            formsData.formReplace?.Close();
            formsData.formGoTo?.Close();            
        }

        System.Drawing.Printing.PrintDocument docToPrint = new System.Drawing.Printing.PrintDocument();

        private void ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.AllowSomePages = true;
            printDialog1.ShowHelp = true;
            //printDialog1.Document = docToPrint;

            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += printDocument1_PrintPage;
            printDialog1.Document = printDocument;

            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDialog1.Document.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(textBox1.Text, textBox1.Font, Brushes.Black, 10, 10);
        }
    }
}
