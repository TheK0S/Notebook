namespace WinFormsApp4
{
    partial class ErrorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorForm));
            this.closeButtonErrorForm = new System.Windows.Forms.Label();
            this.labelHead = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButtonErrorForm
            // 
            this.closeButtonErrorForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButtonErrorForm.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeButtonErrorForm.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.closeButtonErrorForm.Location = new System.Drawing.Point(323, 2);
            this.closeButtonErrorForm.Name = "closeButtonErrorForm";
            this.closeButtonErrorForm.Size = new System.Drawing.Size(25, 25);
            this.closeButtonErrorForm.TabIndex = 8;
            this.closeButtonErrorForm.Text = "╳";
            this.closeButtonErrorForm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.closeButtonErrorForm.Click += new System.EventHandler(this.closeButtonErrorForm_Click);
            this.closeButtonErrorForm.MouseLeave += new System.EventHandler(this.closeButtonErrorForm_MouseLeave);
            this.closeButtonErrorForm.MouseHover += new System.EventHandler(this.closeButtonErrorForm_MouseHover);
            // 
            // labelHead
            // 
            this.labelHead.AutoSize = true;
            this.labelHead.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHead.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelHead.Location = new System.Drawing.Point(2, 2);
            this.labelHead.Name = "labelHead";
            this.labelHead.Size = new System.Drawing.Size(66, 20);
            this.labelHead.TabIndex = 9;
            this.labelHead.Text = "Блокнот";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(41, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 55);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(111, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 23);
            this.label1.TabIndex = 11;
            // 
            // ErrorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 200);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelHead);
            this.Controls.Add(this.closeButtonErrorForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ErrorForm";
            this.Text = "errorForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label closeButtonErrorForm;
        private Label labelHead;
        private PictureBox pictureBox1;
        public Label label1;
    }
}