using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Search
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Matches.Clear();
            Regex regex = new Regex(Search.Text);
            string[] content = Text.Text.Split(' ');

            foreach (string word in content) {
                if (regex.IsMatch(word))
                {
                    Matches.Text += word + ", ";
                }
            }

       
        }
    }
}
