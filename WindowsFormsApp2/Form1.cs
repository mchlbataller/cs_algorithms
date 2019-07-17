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


        // Array has been pre-declared since the programmer has no idea how to do it without
        // encountering any errors.
        public int[] numbers1 = new int[25] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public int[] numbers2 = new int[25] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public int[] numbers3 = new int[25] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        //Initialize form
        public Form1()
        {
            InitializeComponent();
        }



        public void submitNumber_Click(object sender, EventArgs e)
        {
            Converter c = new Converter();

            // convert input texts
			//
            c.temp = Convert.ToInt32(numInput.Text);

            c.Start(numOutput, Convert.ToInt32(numInput.Text), Convert.ToInt32(baseSelector.Text), c.converted, c.i, c.temp);   
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
        
        // Event Handler for the Enter key to be assigned to the array
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            Sortings s = new Sortings();


            if (e.KeyCode == Keys.Enter)
            {
                
                //  Converts the user input to Int and assign them to arr[i].
                numbers1[i] = Convert.ToInt32(textBox1.Text);
                numbers2[i] = Convert.ToInt32(textBox1.Text);
                numbers3[i] = Convert.ToInt32(textBox1.Text);
                i++;

                

                Debug.WriteLine(s.counter);


                // clearing the textbox...
                textBox1.Text = "";

            }

            // Calls the sorting functions when the input reaches the max index array
            if (i == 25)
            {
                s.BubbleSort(numbers1);
                s.Insertion_Sort(numbers2);
                s.QuickSort(numbers3, 0, numbers3.Length - 1);

                Debug.WriteLine("");
                for (int j = 0; j < 25; j++)
                {
                    rt1.AppendText(numbers1[j].ToString());
                    rt2.AppendText(numbers2[j].ToString());
                    rt3.AppendText(numbers3[j].ToString());

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

        private void matrixSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(matrixSelector.Text)
            {
                case "2": matrix2.Visible = true; break;
            }
        }

        private void proceed_Click(object sender, EventArgs e)
        {
            Conics c = new Conics();
            try
            {
                // getting the user's input
                c.a = int.Parse(textBox11.Text);
                c.b = int.Parse(textBox12.Text);
                c.c = int.Parse(textBox13.Text);
                c.d = int.Parse(textBox14.Text);
                c.f = int.Parse(textBox97.Text);
                c.g = int.Parse(textBox17.Text);
            }
            catch
            {

                // if error occurs, the program will terminate
                MessageBox.Show("Input must be integer! \n Program Terminating.......");
                this.Close();
            }
            finally
            {
                // determining the conic section using the value from the discriminant formula
                c.bSquare = c.b * c.b;
                c.discriminant = c.bSquare - (4) * (c.a) * (c.c);

                if (c.a == c.c && c.b == 0) // circle
                {
                    c.circleOutput();
                }
                else if (c.discriminant == 0 && c.b == 0 && c.c == 0) // vertical parabola
                {
                    c.parabolaVerticalOutput();
                }
                else if (c.discriminant == 0 && c.a == 0 && c.b == 0) // horizontal parabola
                {
                    c.parabolaHorizontalOutput();
                }

                else if (c.discriminant < 0) // ellipse
                {
                    c.ellipseOutput();
                }
                else if (c.discriminant > 0) // hyperbola
                {
                    c.hyperbolaOutput();
                }

            }
        }
        private void clear_Click(object sender, EventArgs e)
        {
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox97.Clear();
            textBox17.Clear();
        }

        private void conicsButton_Click(object sender, EventArgs e)
        {
            conics.BringToFront();
        }

        private void executeSorting_Click(object sender, EventArgs e)
        {

        }

        private void debug_Click(object sender, EventArgs e)
        {
            TestClass t = new TestClass();

            t.a = 1;
            t.output();
        }
    }
}
