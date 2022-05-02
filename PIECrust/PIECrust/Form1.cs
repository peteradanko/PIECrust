using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIECrust
{
    public partial class Form1 : Form
    {
        string Resolution = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(richTextBoxResolution.Text == "")
            {
                Resolution = "To Be Determined";
            }else
            {
                Resolution = richTextBoxResolution.Text;
            }
            
            Clipboard.SetText("****************************************"
                + "\n" + "*ENVIRONMENT*" + "\n\n" + textBoxEnvironment.Text
                + "\n\n" +"------------------------------------"
                + "\n\n" + "*PROBLEM*"
                + "\n\n" + "Product: " + textBoxProduct.Text
                + "\n\n" + richTextBoxProblem.Text
                + "\n\n" + "------------------------------------"
                + "\n\n" + "*IMPACT*"
                + "\n\n" + richTextBoxImpact.Text
                + "\n\n" + "------------------------------------"
                + "\n\n" + "*EXPECTATION*"
                + "\n\n" + richTextBoxExpectation.Text
                + "\n\n" + "------------------------------------"
                + "\n\n" + "*RESOLUTION*"
                + "\n\n" + Resolution);
        }

        private void buttonIRT_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("Hello " + textBoxName.Text
                + "\n\n" + $"Thank you for opening this ticket with us. Before we get started, I wanted to confirm that the problem you are experiencing with {textBoxProduct.Text} can be summarized as follows:"
                + "\n\n" + richTextBoxProblem.Text
                + "\n\n" + "I also wanted to confirm that the impact to you as a customer can be quantified by the following statement"
                + "\n\n" + richTextBoxImpact.Text
                + "\n\n" + "Please let me know if I have articulated your expectations for this ticket accurately:"
                + "\n\n" + richTextBoxExpectation.Text
                + "\n\n" + "If I've missed anything or interpreted the ticket incorrectly, please let me know. Additionally, please let me know your upcoming schedule so that we may connect."
                + "\n" + "Thank you!");
        }
    }
}
