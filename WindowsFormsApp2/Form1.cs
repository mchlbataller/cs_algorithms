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
        private int i = 0;
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

        }


        // Array has been pre-declared since the programmer has no idea how to do it without
        // encountering any errors.
        public int[] numbers1 = new int[25] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public int[] numbers2 = new int[25] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public int[] numbers3 = new int[25] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };


        // Event Handler for the Enter key to be assigned to the array
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            Sortings s = new Sortings();
            if (e.KeyCode == Keys.Enter)
            {

                /* 
                    Numbers have different versions since they must be sorted
                    separately.
                */
                //  Converts the user input to Int and assign them to arr[i].
                numbers1[i] = Convert.ToInt32(textBox1.Text);
                numbers2[i] = Convert.ToInt32(textBox1.Text);
                numbers3[i] = Convert.ToInt32(textBox1.Text);
                i++;
                

                // These lines of codes are used by the programmer during debugging process.
                // debug start
                Debug.WriteLine("");
                Debug.WriteLine($"{i - 1}");
                for (int j = 0; j < 24; j++)
                {
                    Debug.Write(numbers1[j]);
                }
                // debug end


                // clearing the textbox...
                textBox1.Text = "";

            }


            // TO BE DELETED
            // Call the function when i has reached the max
            // array index value
            if (i == 1)
            {
                s.Insertion_Sort(numbers2);


                int[] numbers4 = new int[25] { 5,2,3,1,4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

                test t = new test();
                t.Start();
                for (int j = 0; j < 24; j++)
                {
                    Debug.Write(numbers1[j]);
                }
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
            numberSorting.BringToFront();
        }

        private void debug_Click(object sender, EventArgs e)
        {
        }

        private void matrixSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(matrixSelector.Text)
            {
                case "2": matrix2.Visible = true; break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }
    }
}
