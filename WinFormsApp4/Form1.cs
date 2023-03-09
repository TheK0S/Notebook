using System.Security.Permissions;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        DataClass formsData;
        public Form1(ref DataClass formsData)
        {
            InitializeComponent();
            this.formsData = formsData;

            formsData.form2_search = new Form2(ref formsData);
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

        }

        private void ���������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(textBox1.Font.Size < DefaultFont.Size * 5)
                textBox1.Font = new Font(textBox1.Font.FontFamily, textBox1.Font.Size + 1);
        }

        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(textBox1.Font.Size > 1)
                textBox1.Font = new Font(textBox1.Font.FontFamily, textBox1.Font.Size - 1);
        }

        private void ������������������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Font = DefaultFont;
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
    }
}
/*
 using Microsoft.VisualBasic;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        string buffer;
        public Form1()
        {
            InitializeComponent();


            textBox1.Multiline= true;
            textBox1.Dock= DockStyle.Fill;


            ToolStripMenuItem copyMenuItem = new ToolStripMenuItem("Copy");
            ToolStripMenuItem pasteMenuItem = new ToolStripMenuItem("Paste");


            contextMenuStrip1.Items.AddRange(new[] { copyMenuItem, pasteMenuItem });

            textBox1.ContextMenuStrip = contextMenuStrip1;


            copyMenuItem.Click += copyMenuIteam_Click;
            pasteMenuItem.Click += pasteMenuIteam_Click;

        }
        //    ToolStripMenuItem fileItem = new ToolStripMenuItem("File");

        //    ToolStripMenuItem newItem = new ToolStripMenuItem("Add")
        //    {
        //        Checked = true,
        //        CheckOnClick = true

        //    };
        //    newItem.CheckedChanged += menuItem_ChakedChanged;
        //    fileItem.DropDownItems.Add(newItem);

        //    ToolStripMenuItem saveItem = new ToolStripMenuItem("Save")
        //    {
        //        Checked = true,
        //        CheckOnClick = true

        //    };
        //    saveItem.CheckedChanged += menuItem_ChakedChanged;
        //    saveItem.ShortcutKeys = Keys.Control | Keys.P;
        //    fileItem.DropDownItems.Add(saveItem);

        //    //fileItem.DropDownItems.Add(new ToolStripMenuItem("Save"));

        //    menuStrip1.Items.Add(fileItem);

        //    ToolStripMenuItem aboutItem = new ToolStripMenuItem("About");
        //    aboutItem.Click += aboutItem_Click;
        //    menuStrip1.Items.Add(aboutItem);
        //}

        //void aboutItem_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("About programm");
        //}
        //void menuItem_ChakedChanged(object sender, EventArgs e)
        //{
        //    ToolStripMenuItem menuItem= sender as ToolStripMenuItem;
        //    if (menuItem.CheckState == CheckState.Checked)
        //        MessageBox.Show("Checked");
        //    else if(menuItem.CheckState == CheckState.Unchecked)
        //        MessageBox.Show("Unchecked");

        //}



        


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        void copyMenuIteam_Click(object sender, EventArgs e)
        {
           buffer = textBox1.SelectedText;  
        }

        void pasteMenuIteam_Click(object sender, EventArgs e)
        {
            textBox1.Paste(buffer);
        }
    }
}
 */