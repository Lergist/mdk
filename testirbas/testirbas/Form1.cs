using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testirbas
{
    public partial class Form1 : Form
    {
        registred reg = new registred();
        Form2 f2 = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string prior = reg.login(textBox1.Text, textBox2.Text);
            if(prior == "1")
            {
                f2.Show();
            }
        }
    }
}
