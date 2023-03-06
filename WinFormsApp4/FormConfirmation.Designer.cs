namespace WinFormsApp4
{
    partial class FormConfirmation
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
            this.label1 = new System.Windows.Forms.Label();
            this.CancelBatton = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Все несохраненные данные будут утрачены. Вы уверены?";
            // 
            // CancelBatton
            // 
            this.CancelBatton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBatton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancelBatton.Location = new System.Drawing.Point(236, 62);
            this.CancelBatton.Name = "CancelBatton";
            this.CancelBatton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CancelBatton.Size = new System.Drawing.Size(116, 26);
            this.CancelBatton.TabIndex = 11;
            this.CancelBatton.Text = "Отмена";
            this.CancelBatton.UseVisualStyleBackColor = true;
            this.CancelBatton.UseWaitCursor = true;
            this.CancelBatton.Click += new System.EventHandler(this.CancelBatton_Click);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConfirm.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonConfirm.Location = new System.Drawing.Point(98, 62);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonConfirm.Size = new System.Drawing.Size(116, 26);
            this.buttonConfirm.TabIndex = 10;
            this.buttonConfirm.Text = "Подтвердить";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.UseWaitCursor = true;
            // 
            // FormConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 108);
            this.Controls.Add(this.CancelBatton);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.label1);
            this.Enabled = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConfirmation";
            this.Text = "FormConfirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button CancelBatton;
        private Button buttonConfirm;
    }
}