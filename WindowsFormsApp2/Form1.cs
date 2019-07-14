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
        private int a, b, c, d, f, g;
        private int bSquare = 0;
        private int discriminant;


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


        int counter;

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

                // These lines of codes are used by the programmer during debugging process.
                // debug start
                //Debug.WriteLine("");
                //Debug.WriteLine($"{i - 1}");
                //for (int j = 0; j < 24; j++)
                //{
                //    Debug.Write(numbers1[j]);
                //}
                // debug end


                // clearing the textbox...
                textBox1.Text = "";

            }


            // TO BE DELETED
            // Call the function when i has reached the max
            // array index value
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

        private void proceed_Click(object sender, EventArgs e)
        {
            try
            {
                // getting the user's input
                a = int.Parse(textBox11.Text);
                b = int.Parse(textBox12.Text);
                c = int.Parse(textBox13.Text);
                d = int.Parse(textBox14.Text);
                f = int.Parse(textBox97.Text);
                g = int.Parse(textBox17.Text);

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
                bSquare = b * b;
                discriminant = bSquare - (4) * (a) * (c);

                if (a == c && b == 0) // circle
                {
                    circleOutput();

                }
                else if (discriminant == 0 && b == 0 && c == 0) // vertical parabola
                {
                    parabolaVerticalOutput();
                }
                else if (discriminant == 0 && a == 0 && b == 0) // horizontal parabola
                {
                    parabolaHorizontalOutput();
                }

                else if (discriminant < 0) // ellipse
                {
                    ellipseOutput();
                }
                else if (discriminant > 0) // hyperbola
                {
                    hyperbolaOutput();

                }

            }
        }

        private void clear_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void conicsButton_Click(object sender, EventArgs e)
        {
            conics.BringToFront();
        }

        // nested methods for conic outputs
        private void circleOutput()
        {
            double r, x, y, h, k, ga, radius;

            x = d / (2 * a);
            y = f / (2 * a);
            r = (x * x) + (y * y);

            h = -(x); // vertex at h
            k = -(y); // vertex at k

            ga = g / a;
            radius = Math.Sqrt(r - ga);

            outputNumber.AppendText($"The conic section is circle\nThe radius is {radius}. \n Vertex at ({h}, {k})");

        }
        private void parabolaVerticalOutput()
        {
            double x, y, h, k, focus;
            string upWard, downWard;

            x = d / (2 * a);
            y = (d * d) / 4;

            h = -(x); // vertex at h
            k = (y - g) / f; // vertex at k

            focus = 4 / a;

            if (focus > 0)
            {
                upWard = "upwards";
                outputNumber.AppendText($"The conic section is Vertical Parabola\nThe focus is {focus}. \n Vertex at ({h}, {k}) opening {upWard}");
            }
            else
            {
                downWard = "downwards";
                outputNumber.AppendText($"The conic section is Vertical Parabola\nThe focus is {focus}. \n Vertex at ({h}, {k}) opening {downWard}");
            }

        }

        private void parabolaHorizontalOutput()
        {
            double x, y, h, k, focus;
            string upWard, downWard;

            x = f / (2 * c);
            y = (f * f) / 4;


            focus = 4 / c;
            h = (y - g) / d; // vertex at h
            k = -(x); // vertex at k

            if (focus > 0)
            {
                upWard = "upwards";
                outputNumber.AppendText($"The conic section is Horizontal Parabola\nThe focus is {focus}. \n Vertex at ({h}, {k}) opening {upWard}");
            }
            else
            {
                downWard = "downwards";
                outputNumber.AppendText($"The conic section is Horizontal Parabola\nThe focus is {focus}. \n Vertex at ({h}, {k}) opening {downWard}");
            }

        }

        private void ellipseOutput()
        {
            double h, k, semiAxesA, semiAxesB;


            h = -d / (2 * a); // vertex at h
            k = -f / 2; // vertex at k


            semiAxesA = Math.Sqrt(c);
            semiAxesB = Math.Sqrt(1);

            outputNumber.AppendText($"The conic section is Ellipse. \nThe semi-axes are  a = {semiAxesA} and b {semiAxesB} . \n Vertex at ({h}, {k}).");
        }


        private void hyperbolaOutput() // standard hyperbola
        {
            double x, asymptotes;

            x = -d / (2 * a);

            asymptotes = Math.Abs(b / a) * x;

            outputNumber.AppendText($"The conic section is Hyperbola \n The horizontal asymptote is {asymptotes}.");
        }

    }
}
