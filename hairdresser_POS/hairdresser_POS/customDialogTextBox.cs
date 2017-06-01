using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hairdresser_POS
{
    public partial class customDialogTextBox : Form
    {
        public customDialogTextBox()
        {
            InitializeComponent();
            textBox1.Focus();
        }

        public string getTextBoxValue()
        {
            return textBox1.Text;
        }

        public void setLabelValue(string text, string text2)
        {
            label1.Text = text;
            label2.Text = text2;
        }

        private void customTextCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs k)
        {
            if (k.KeyCode == Keys.Enter)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
