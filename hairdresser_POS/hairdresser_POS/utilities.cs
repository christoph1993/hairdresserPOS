using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hairdresser_POS
{
    class utilities
    {
        /// <summary>
        /// Toggle visibility of given inputs
        /// </summary>
        /// <param name="inputForms">Inputs to toggle</param>
        public void toggleVisibility(Control[] inputForms)
        {
            inputForms.ToList().ForEach(c => c.Visible = (c.Visible) ? false : true);
        }

        /// <summary>
        /// Create a generic error message for a textbox and focus on after error
        /// </summary>
        /// <param name="errorString">Error string to show</param>
        /// <param name="errorName">Name of error</param>
        /// <param name="textbox">Textbox where error occured</param>
        public void textBoxMessageError(string errorString, string errorName, TextBox textbox)
        {
            MessageBox.Show(errorString, errorName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            textbox.ResetText();
            textbox.Focus();
        }

        /// <summary>
        /// Utilitiy function to show a textbox to recieve string input
        /// </summary>
        /// <param name="message">Message that appears on box</param>
        /// <param name="label"></param>
        /// <param name="parent">Parent Form</param>
        /// <returns>Returns the entered text</returns>
        public string textMessageBox(string message, string label, Form parent)
        {
            string text = null;
            using (customDialogTextBox messageBox = new customDialogTextBox())
            {
                messageBox.setLabelValue(message, label);
                messageBox.ShowDialog(parent);
                if (messageBox.DialogResult == DialogResult.OK)
                {
                    text = messageBox.getTextBoxValue();
                    if (String.IsNullOrEmpty(text))
                    {
                        MessageBox.Show("Please enter a value or press Cancel", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return (this.textMessageBox(message, label, parent));
                    }
                    else
                    {
                        return text;
                    }
                }
            }
            return text;
        }

        /// <summary>
        /// Function to show and return a list of options to be selected. Single option only (radio button)
        /// </summary>
        /// <param name="radioNames">Names of each choice on radio button</param>
        /// <param name="radioText"></param>
        /// <param name="label"></param>
        /// <param name="parent">Parent form</param>
        /// <returns>Radio selection</returns>
        public string radioButtonBox(string[] radioNames, string[] radioText, string label, Form parent)
        {
            string radioName = null;
            using (radioSelect selectDraft = new radioSelect())
            {
                selectDraft.setTitle(label);
                selectDraft.generateRadioButtons(radioNames, radioText);
                selectDraft.ShowDialog();
                if (selectDraft.DialogResult == DialogResult.OK)
                {
                    radioName = selectDraft.getSelectedRadioButton();
                    if (String.IsNullOrEmpty(radioName))
                    {
                        MessageBox.Show("Please make a selection.\nOtherwise press close", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return (this.radioButtonBox(radioNames, radioText, label, parent));
                    }
                    else
                    {
                        return radioName;
                    }
                }
            }
            return radioName;
        }
    }
}
