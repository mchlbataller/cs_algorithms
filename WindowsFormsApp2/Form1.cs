using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void submitNumber_Click(object sender, EventArgs e)
        {
            Converter c = new Converter();

            // convert input texts
			//
            c.dec = Convert.ToInt32(numInput.Text);
            c.bas = Convert.ToInt32(baseSelector.Text);
            c.temp = c.dec;             // assigning decimal to temp for future use

            c.converterProcess(numOutput, c.dec, c.bas, c.converted, c.i, c.temp);          // first arg is about passing a reference to the converterProcess 
                                                                                            // so that the method can actually modify the object.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tribonacci_Sequence t = new Tribonacci_Sequence();
            t.Start(trib_Output, 0, Convert.ToInt32(trib_Input.Text));
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Sortings s = new Sortings();

            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            int i = 1;
            if (e.KeyCode == Keys.Enter)
            {
                
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            converter.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tribonacci.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
        }
    }
}
