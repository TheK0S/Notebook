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
            this.SuspendLayout();
            // 
            // searchField
            // 
            this.searchField.Location = new System.Drawing.Point(75, 8);
            this.searchField.MaximumSize = new System.Drawing.Size(400, 23);
            this.searchField.MinimumSize = new System.Drawing.Size(400, 23);
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(400, 23);
            this.searchField.TabIndex = 1;
            this.searchField.TextChanged += new System.EventHandler(this.searchField_TextChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.Location = new System.Drawing.Point(9, 7);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonSearch.Size = new System.Drawing.Size(59, 24);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Искать";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 219);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.searchField);
            this.Name = "Form2";
            this.Text = "Введите искомый текст";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox searchField;
        private Button buttonSearch;
    }
}