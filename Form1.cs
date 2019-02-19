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
                ConsoleBox.AppendText("Error accessign console \r\n");
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
            ConsoleBox.AppendText(consoleOutput.Next(0, 255) + "\r\n");
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Show();
            ConsoleBox.AppendText("Generated civs: Pingala \r\n");
        }
    }
}
