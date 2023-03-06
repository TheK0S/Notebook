namespace WinFormsApp4
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchField = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.checkBoxRegister = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ToDownRadioButton = new System.Windows.Forms.RadioButton();
            this.ToUpRadioButton = new System.Windows.Forms.RadioButton();
            this.CancelBatton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchField
            // 
            this.searchField.Location = new System.Drawing.Point(51, 46);
            this.searchField.MaximumSize = new System.Drawing.Size(350, 23);
            this.searchField.MinimumSize = new System.Drawing.Size(350, 23);
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(350, 23);
            this.searchField.TabIndex = 1;
            this.searchField.UseWaitCursor = true;
            this.searchField.TextChanged += new System.EventHandler(this.searchField_TextChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSearch.Location = new System.Drawing.Point(417, 45);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonSearch.Size = new System.Drawing.Size(116, 26);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Найти далее";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.UseWaitCursor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            this.buttonSearch.MouseLeave += new System.EventHandler(this.buttonSearch_MouseLeave);
            this.buttonSearch.MouseHover += new System.EventHandler(this.buttonSearch_MouseHover);
            // 
            // checkBoxRegister
            // 
            this.checkBoxRegister.AutoSize = true;
            this.checkBoxRegister.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxRegister.Location = new System.Drawing.Point(12, 121);
            this.checkBoxRegister.Name = "checkBoxRegister";
            this.checkBoxRegister.Size = new System.Drawing.Size(146, 23);
            this.checkBoxRegister.TabIndex = 3;
            this.checkBoxRegister.Text = "С учетом регистра";
            this.checkBoxRegister.UseVisualStyleBackColor = true;
            this.checkBoxRegister.UseWaitCursor = true;
            this.checkBoxRegister.CheckedChanged += new System.EventHandler(this.checkBoxRegister_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Что:";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(9, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Найти";
            this.label2.UseWaitCursor = true;
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeButton.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.closeButton.Location = new System.Drawing.Point(511, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(25, 25);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "╳";
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.closeButton.UseWaitCursor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            this.closeButton.MouseHover += new System.EventHandler(this.closeButton_MouseHover);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ToDownRadioButton);
            this.groupBox1.Controls.Add(this.ToUpRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(210, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 62);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Направление";
            this.groupBox1.UseWaitCursor = true;
            // 
            // ToDownRadioButton
            // 
            this.ToDownRadioButton.AutoSize = true;
            this.ToDownRadioButton.Checked = true;
            this.ToDownRadioButton.Location = new System.Drawing.Point(91, 33);
            this.ToDownRadioButton.Name = "ToDownRadioButton";
            this.ToDownRadioButton.Size = new System.Drawing.Size(61, 24);
            this.ToDownRadioButton.TabIndex = 1;
            this.ToDownRadioButton.TabStop = true;
            this.ToDownRadioButton.Text = "Вниз";
            this.ToDownRadioButton.UseVisualStyleBackColor = true;
            this.ToDownRadioButton.UseWaitCursor = true;
            this.ToDownRadioButton.CheckedChanged += new System.EventHandler(this.ToDownRadioButton_CheckedChanged);
            // 
            // ToUpRadioButton
            // 
            this.ToUpRadioButton.AutoSize = true;
            this.ToUpRadioButton.Location = new System.Drawing.Point(13, 33);
            this.ToUpRadioButton.Name = "ToUpRadioButton";
            this.ToUpRadioButton.Size = new System.Drawing.Size(68, 24);
            this.ToUpRadioButton.TabIndex = 0;
            this.ToUpRadioButton.Text = "Вверх";
            this.ToUpRadioButton.UseVisualStyleBackColor = true;
            this.ToUpRadioButton.UseWaitCursor = true;
            this.ToUpRadioButton.CheckedChanged += new System.EventHandler(this.ToUpRadioButton_CheckedChanged);
            // 
            // CancelBatton
            // 
            this.CancelBatton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBatton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancelBatton.Location = new System.Drawing.Point(417, 83);
            this.CancelBatton.Name = "CancelBatton";
            this.CancelBatton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CancelBatton.Size = new System.Drawing.Size(116, 26);
            this.CancelBatton.TabIndex = 9;
            this.CancelBatton.Text = "Отмена";
            this.CancelBatton.UseVisualStyleBackColor = true;
            this.CancelBatton.UseWaitCursor = true;
            this.CancelBatton.Click += new System.EventHandler(this.CancelBatton_Click);
            // 
            // Form2
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(540, 164);
            this.ControlBox = false;
            this.Controls.Add(this.CancelBatton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxRegister);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.searchField);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(540, 164);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(540, 164);
            this.Name = "Form2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Найти";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox searchField;
        private Button buttonSearch;
        private CheckBox checkBoxRegister;
        private Label label1;
        private Label label2;
        private Label closeButton;
        private FileSystemWatcher fileSystemWatcher1;
        private Button CancelBatton;
        private GroupBox groupBox1;
        public RadioButton ToDownRadioButton;
        public RadioButton ToUpRadioButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}