using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _作業02_Exec2_Message_Q2_21謝孟勳
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timeLabel_Click(object sender, EventArgs e)
        {

        }

        private void greetButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;

            if (name == String.Empty)
            {
                MessageBox.Show("您沒有輸入");
            }

            else
            {
                DateTime timemessage = DateTime.Now;
                timeLabel.Text = Convert.ToString($"現在時間是: {timemessage}");

                string message = $"Hi , {name} 您好";
                greetingLabel.Text = message;

                MessageBox.Show(Convert.ToString($"現在時間是: {timemessage}"));
            }
        }   
    }
}
