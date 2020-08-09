using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace is_bitirici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "İş Bitirici";
            listBox1.Text = "";
            listBox2.Text = "";
            //şimdilik listboxları ilk açılışta temizliyor, vt eklenince kaldırılacak!
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int sayac = 0;

        private void button1_Click(object sender, EventArgs e)
        {  
            if(textBox1.Text == "")
            {
                
            }
            else
            {
                sayac++;
                listBox1.Items.Add(sayac + ") " + textBox1.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.Text);
            Console.WriteLine(listBox1.SelectedIndex);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.ClearSelected();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
