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
    public partial class radioSelect : Form
    {
        public radioSelect()
        {
            InitializeComponent();
        }

        public void generateRadioButtons(string[] radioNames, string[] radioText)
        {
            System.Windows.Forms.RadioButton[] buttons = new System.Windows.Forms.RadioButton[radioNames.Length];
            for(int i = 0; i < radioNames.Length; i++)
            {
                buttons[i] = new RadioButton();
                buttons[i].Text = radioText[i];
                buttons[i].Name = radioNames[i];
                buttons[i].Location = new System.Drawing.Point(20, 30 + i * 20);
                buttons[i].Size = new System.Drawing.Size(radioText[i].Length * 20, 20);
                this.Controls.Add(buttons[i]);
            }
        }

        public void setTitle(string title)
        {
            label1.Text = title;
        }

        public string getSelectedRadioButton()
        {
            foreach(Control ctl in this.Controls)
            {
                if(ctl.GetType() == typeof(RadioButton))
                {
                    RadioButton rb = (RadioButton)ctl;
                    if (rb.Checked)
                        return rb.Name;
                }
            }
            return null;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
