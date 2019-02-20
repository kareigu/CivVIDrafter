using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CivVIDrafter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void consoleLogger(string consoleBuffer, bool newLine)
        {
            if(newLine == true)
            {
                ConsoleBox.AppendText("\r\n" + consoleBuffer);
            }
            else if(newLine == false)
            {
                ConsoleBox.AppendText(consoleBuffer + " \n");
            }
            else
            {
                ConsoleBox.AppendText("Error logging to console \r\n");
            }

        }






        /// <summary>
        /// File menu options
        /// </summary>

        private void FileMenuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FileMenuHelpAbout_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Civ VI Leader Drafter v0.1 \n by: mxr \n");
        }

        private void ConsoleShowButton_Click(object sender, EventArgs e)
        {
            if(ConsoleBox.Visible == false)
            {
                ConsoleBox.Show();
                GenerateButton.Left = 210;
                GenerateButton.Top = 393;
            }
            else if(ConsoleBox.Visible == true)
            {
                ConsoleBox.Hide();
                GenerateButton.Left = 210;
                GenerateButton.Top = 550;
            }
            else
            {
                consoleLogger("Error accessing console", true);
            }

        }



        /// <summary>
        /// Debugging
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void FileMenuDebugAppendConsole_Click(object sender, EventArgs e)
        {
            Random consoleOutput = new Random();
            int sendTestData = consoleOutput.Next();
            consoleLogger(sendTestData.ToString(), true);
        }





        #region Generator
        /// <summary>
        /// Generator code
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void CountSelectNextButton_Click(object sender, EventArgs e)
        {
            PlayercountSelector.Enabled = false;
            PlayerCivCountSelector.Enabled = false;

            //enable dlc selector
            CivFilterSelector.Enabled = true;

            //Check all options by default
            int dlcCount = CivFilterSelector.Items.Count;
            for(int i = dlcCount - 1; i >= 0; i--)
            {
                CivFilterSelector.SetItemCheckState(i, CheckState.Checked);
            }
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {

            //Show pictures of civs and send generation info to console.
            pictureBox1.Show();
            consoleLogger("Generated civs: ", true);

            //enable next button under countselectors
            PlayerCivCountSelector.Enabled = true;
            PlayercountSelector.Enabled = true;

            //disable dlc selector
            CivFilterSelector.Enabled = false;


            //Log generated civs to console
            civGenerator();
        }

        

        private void civGenerator()
        {
            Civs civs = new Civs();
            civs.vanilla();
            civs.rf();
            civs.gs();
            civs.dlc();
            
            for (int i = 0; i < 5; i++)
            {
                consoleLogger(civs.rfCivs[i] + ",", false);
            }
        }


        #endregion
    }
}



