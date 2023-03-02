namespace WinFormsApp4
{
    partial class FormReplace
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
            this.closeButton = new System.Windows.Forms.Label();
            this.labelHeade = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxRegister = new System.Windows.Forms.CheckBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.searchField = new System.Windows.Forms.TextBox();
            this.buttonReplace = new System.Windows.Forms.Button();
            this.buttonReplaceAll = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ReplaceField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeButton.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.closeButton.Location = new System.Drawing.Point(516, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(25, 25);
            this.closeButton.TabIndex = 13;
            this.closeButton.Text = "╳";
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.closeButton.UseWaitCursor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // labelHeade
            // 
            this.labelHeade.AutoSize = true;
            this.labelHeade.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHeade.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelHeade.Location = new System.Drawing.Point(8, 4);
            this.labelHeade.Name = "labelHeade";
            this.labelHeade.Size = new System.Drawing.Size(76, 20);
            this.labelHeade.TabIndex = 12;
            this.labelHeade.Text = "Заменить";
            this.labelHeade.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Что:";
            this.label1.UseWaitCursor = true;
            // 
            // checkBoxRegister
            // 
            this.checkBoxRegister.AutoSize = true;
            this.checkBoxRegister.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxRegister.Location = new System.Drawing.Point(12, 140);
            this.checkBoxRegister.Name = "checkBoxRegister";
            this.checkBoxRegister.Size = new System.Drawing.Size(146, 23);
            this.checkBoxRegister.TabIndex = 10;
            this.checkBoxRegister.Text = "С учетом регистра";
            this.checkBoxRegister.UseVisualStyleBackColor = true;
            this.checkBoxRegister.UseWaitCursor = true;
            this.checkBoxRegister.CheckedChanged += new System.EventHandler(this.checkBoxRegister_CheckedChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSearch.Location = new System.Drawing.Point(416, 36);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonSearch.Size = new System.Drawing.Size(116, 26);
            this.buttonSearch.TabIndex = 9;
            this.buttonSearch.Text = "Найти далее";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.UseWaitCursor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // searchField
            // 
            this.searchField.Location = new System.Drawing.Point(50, 37);
            this.searchField.MaximumSize = new System.Drawing.Size(350, 23);
            this.searchField.MinimumSize = new System.Drawing.Size(350, 23);
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(350, 23);
            this.searchField.TabIndex = 8;
            this.searchField.UseWaitCursor = true;
            this.searchField.TextChanged += new System.EventHandler(this.searchField_TextChanged);
            // 
            // buttonReplace
            // 
            this.buttonReplace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReplace.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonReplace.Location = new System.Drawing.Point(416, 70);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonReplace.Size = new System.Drawing.Size(116, 26);
            this.buttonReplace.TabIndex = 14;
            this.buttonReplace.Text = "Заменить";
            this.buttonReplace.UseVisualStyleBackColor = true;
            this.buttonReplace.UseWaitCursor = true;
            this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click);
            // 
            // buttonReplaceAll
            // 
            this.buttonReplaceAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReplaceAll.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonReplaceAll.Location = new System.Drawing.Point(415, 105);
            this.buttonReplaceAll.Name = "buttonReplaceAll";
            this.buttonReplaceAll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonReplaceAll.Size = new System.Drawing.Size(116, 26);
            this.buttonReplaceAll.TabIndex = 15;
            this.buttonReplaceAll.Text = "Заменить все";
            this.buttonReplaceAll.UseVisualStyleBackColor = true;
            this.buttonReplaceAll.UseWaitCursor = true;
            this.buttonReplaceAll.Click += new System.EventHandler(this.buttonReplaceAll_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.Location = new System.Drawing.Point(415, 140);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonCancel.Size = new System.Drawing.Size(116, 26);
            this.buttonCancel.TabIndex = 16;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.UseWaitCursor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(7, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Чем:";
            this.label3.UseWaitCursor = true;
            // 
            // ReplaceField
            // 
            this.ReplaceField.Location = new System.Drawing.Point(50, 71);
            this.ReplaceField.MaximumSize = new System.Drawing.Size(350, 23);
            this.ReplaceField.MinimumSize = new System.Drawing.Size(350, 23);
            this.ReplaceField.Name = "ReplaceField";
            this.ReplaceField.Size = new System.Drawing.Size(350, 23);
            this.ReplaceField.TabIndex = 17;
            this.ReplaceField.UseWaitCursor = true;
            this.ReplaceField.TextChanged += new System.EventHandler(this.ReplaceField_TextChanged);
            // 
            // FormReplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 205);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ReplaceField);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonReplaceAll);
            this.Controls.Add(this.buttonReplace);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.labelHeade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxRegister);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.searchField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(543, 205);
            this.MinimumSize = new System.Drawing.Size(543, 205);
            this.Name = "FormReplace";
            this.Text = "FormReplace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label closeButton;
        private Label labelHeade;
        private Label label1;
        private CheckBox checkBoxRegister;
        private Button buttonSearch;
        private TextBox searchField;
        private Button buttonReplace;
        private Button buttonReplaceAll;
        private Button buttonCancel;
        private Label label3;
        private TextBox ReplaceField;
    }
}