namespace hairdresser_POS
{
    partial class customDialogTextBox
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
            this.customTextCancel = new System.Windows.Forms.Button();
            this.customTextOk = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // customTextCancel
            // 
            this.customTextCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.customTextCancel.Location = new System.Drawing.Point(16, 85);
            this.customTextCancel.Name = "customTextCancel";
            this.customTextCancel.Size = new System.Drawing.Size(75, 23);
            this.customTextCancel.TabIndex = 2;
            this.customTextCancel.Text = "Cancel";
            this.customTextCancel.UseVisualStyleBackColor = true;
            this.customTextCancel.Click += new System.EventHandler(this.customTextCancel_Click);
            // 
            // customTextOk
            // 
            this.customTextOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.customTextOk.Location = new System.Drawing.Point(110, 85);
            this.customTextOk.Name = "customTextOk";
            this.customTextOk.Size = new System.Drawing.Size(75, 23);
            this.customTextOk.TabIndex = 1;
            this.customTextOk.Text = "OK";
            this.customTextOk.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // customDialogTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(202, 127);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.customTextOk);
            this.Controls.Add(this.customTextCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "customDialogTextBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "customDialogTextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button customTextCancel;
        private System.Windows.Forms.Button customTextOk;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}