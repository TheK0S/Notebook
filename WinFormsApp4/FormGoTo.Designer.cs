namespace WinFormsApp4
{
    partial class FormGoTo
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
            this.CancelBatton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGoTo = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelBatton
            // 
            this.CancelBatton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBatton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancelBatton.Location = new System.Drawing.Point(239, 113);
            this.CancelBatton.Name = "CancelBatton";
            this.CancelBatton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CancelBatton.Size = new System.Drawing.Size(116, 26);
            this.CancelBatton.TabIndex = 15;
            this.CancelBatton.Text = "Отмена";
            this.CancelBatton.UseVisualStyleBackColor = true;
            this.CancelBatton.UseWaitCursor = true;
            this.CancelBatton.Click += new System.EventHandler(this.CancelBatton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeButton.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.closeButton.Location = new System.Drawing.Point(346, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(25, 25);
            this.closeButton.TabIndex = 14;
            this.closeButton.Text = "╳";
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.closeButton.UseWaitCursor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            this.closeButton.MouseHover += new System.EventHandler(this.closeButton_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(6, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Перейти";
            this.label2.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Номер строки:";
            this.label1.UseWaitCursor = true;
            // 
            // buttonGoTo
            // 
            this.buttonGoTo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGoTo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGoTo.Location = new System.Drawing.Point(109, 113);
            this.buttonGoTo.Name = "buttonGoTo";
            this.buttonGoTo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonGoTo.Size = new System.Drawing.Size(116, 26);
            this.buttonGoTo.TabIndex = 11;
            this.buttonGoTo.Text = "Переход";
            this.buttonGoTo.UseVisualStyleBackColor = true;
            this.buttonGoTo.UseWaitCursor = true;
            this.buttonGoTo.Click += new System.EventHandler(this.buttonGoTo_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(19, 74);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(335, 23);
            this.numericUpDown1.TabIndex = 16;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // FormGoTo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 159);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.CancelBatton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGoTo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(373, 159);
            this.MinimumSize = new System.Drawing.Size(373, 159);
            this.Name = "FormGoTo";
            this.Text = "FormGoTo";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CancelBatton;
        private Label closeButton;
        private Label label2;
        private Label label1;
        private Button buttonGoTo;
        private NumericUpDown numericUpDown1;
    }
}