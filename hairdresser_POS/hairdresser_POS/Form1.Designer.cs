﻿namespace hairdresser_POS
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.appointments = new System.Windows.Forms.TabPage();
            this.sale = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.appointments);
            this.tabControl1.Controls.Add(this.sale);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(820, 509);
            this.tabControl1.TabIndex = 0;
            // 
            // appointments
            // 
            this.appointments.Location = new System.Drawing.Point(4, 22);
            this.appointments.Name = "appointments";
            this.appointments.Padding = new System.Windows.Forms.Padding(3);
            this.appointments.Size = new System.Drawing.Size(812, 483);
            this.appointments.TabIndex = 0;
            this.appointments.Text = "Appointments";
            this.appointments.UseVisualStyleBackColor = true;
            // 
            // sale
            // 
            this.sale.Location = new System.Drawing.Point(4, 22);
            this.sale.Name = "sale";
            this.sale.Padding = new System.Windows.Forms.Padding(3);
            this.sale.Size = new System.Drawing.Size(812, 483);
            this.sale.TabIndex = 1;
            this.sale.Text = "Sale";
            this.sale.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 509);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage appointments;
        private System.Windows.Forms.TabPage sale;
    }
}

