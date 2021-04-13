using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;

namespace HostMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"\d+");
            Match match = regex.Match(textBox1.Text);

            if (!match.Success)
            {
                MessageBox.Show("Put a correct IP Address!");
            }
            else
            {
                using (StreamWriter sw = File.AppendText("host.txt"))
                {
                    sw.WriteLine(textBox1.Text + " growtopia1.com"); // Write text to .txt file
                    sw.WriteLine(textBox1.Text + " growtopia2.com");
                    sw.Close();
                    MessageBox.Show("Host has been created!");
                    textBox1.Text = String.Empty;
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Robertas64 and Artemis\nPublished to Github\nDiscord :\nRobertas#4190\nartemis#7157");
        }
    }
}
