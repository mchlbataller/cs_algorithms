/*
 * Progress so far:
 *      Assigned the textboxes to their respective variables
 *      Laid out the equations
 * Bugs encountered:
 *      zeroes on output,
 *      Arithmetic errors on proceeding rounds.
 */




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp2
{
    class Gauss : Form1
    {
        public double x1, x2, x3, x4, x5,
            A1, B1, C1, D1, E1, constant1,
            A2, B2, C2, D2, E2, constant2,
            A3, B3, C3, D3, E3, constant3,
            A4, B4, C4, D4, E4, constant4,
            A5, B5, C5, D5, E5, constant5;

        // Functions for finding x.
        private double fx1()
        {
            return (-(B1 * x2) - (C1 * x3) - (D1 * x4) - (E1 * x5) - constant1) / A1;
        }
        private double fx2()
        {
            return (-(A2 * x1) - (C2 * x3) - (D2 * x4) - (E2 * x5) - constant2) / B2;
        }
        private double fx3()
        {
            return (-(A3 * x1) - (B3 * x2) - (D3 * x4) - (E3 * x5) - constant3) / C3;
        }
        private double fx4()
        {
            return (-(A4 * x1) - (B4 * x2) - (C4 * x3) - (E4 * x5) - constant4) / D4;
        }
        private double fx5()
        {
            return (-(A5 * x1) - (B5 * x2) - (C5 * x3) - (D5 * x4) - constant5) / E5;
        }

        public void Start(RichTextBox outputValues, TextBox a1, TextBox b1, TextBox c1, TextBox d1, TextBox e1, TextBox const1,
            TextBox a2, TextBox b2, TextBox c2, TextBox d2, TextBox e2, TextBox const2,
            TextBox a3, TextBox b3, TextBox c3, TextBox d3, TextBox e3, TextBox const3,
            TextBox a4, TextBox b4, TextBox c4, TextBox d4, TextBox e4, TextBox const4,
            TextBox a5, TextBox b5, TextBox c5, TextBox d5, TextBox e5, TextBox const5, int round)
        {
            if (round == 1)
            {
                A1 = Convert.ToDouble(a1.Text); B1 = Convert.ToDouble(b1.Text); C1 = Convert.ToDouble(c1.Text);
                D1 = Convert.ToDouble(d1.Text); E1 = Convert.ToDouble(e1.Text); constant1 = Convert.ToDouble(const1.Text);
                A2 = Convert.ToDouble(a2.Text); B2 = Convert.ToDouble(b2.Text); C2 = Convert.ToDouble(c2.Text);
                D2 = Convert.ToDouble(d2.Text); E2 = Convert.ToDouble(e2.Text); constant2 = Convert.ToDouble(const2.Text);
                A3 = Convert.ToDouble(a3.Text); B3 = Convert.ToDouble(b3.Text); C3 = Convert.ToDouble(c3.Text);
                D3 = Convert.ToDouble(d3.Text); E3 = Convert.ToDouble(e3.Text); constant3 = Convert.ToDouble(const3.Text);
                A4 = Convert.ToDouble(a4.Text); B4 = Convert.ToDouble(b4.Text); C4 = Convert.ToDouble(c4.Text);
                D4 = Convert.ToDouble(d4.Text); E4 = Convert.ToDouble(e4.Text); constant4 = Convert.ToDouble(const4.Text);
                A5 = Convert.ToDouble(a5.Text); B5 = Convert.ToDouble(b5.Text); C5 = Convert.ToDouble(c5.Text);
                D5 = Convert.ToDouble(d5.Text); E5 = Convert.ToDouble(e5.Text); constant5 = Convert.ToDouble(const5.Text);

                x1 = 0; x2 = 0; x3 = 0; x4 = 0; x5 = 0;
                x1 = fx1();
                x2 = fx2();
                x3 = fx3();
                x4 = fx4();
                x5 = fx5();

                outputValues.AppendText("First Round: "
                    + Environment.NewLine + $"x1 equals {x1.ToString()}"
                    + Environment.NewLine + $"x2 equals {x2.ToString()}"
                    + Environment.NewLine + $"x3 equals {x3.ToString()}"
                    + Environment.NewLine + $"x4 equals {x4.ToString()}"
                    + Environment.NewLine + $"x5 equals {x5.ToString()}");
            }
            else if (round == 2)
            {
                x1 = fx1();
                x2 = fx2();
                x3 = fx3();
                x4 = fx4();
                x5 = fx5();
                outputValues.AppendText(Environment.NewLine + "Second Round: "
                    + Environment.NewLine + $"x1 equals {x1.ToString()}"
                    + Environment.NewLine + $"x2 equals {x2.ToString()}"
                    + Environment.NewLine + $"x3 equals {x3.ToString()}"
                    + Environment.NewLine + $"x4 equals {x4.ToString()}"
                    + Environment.NewLine + $"x5 equals {x5.ToString()}");
            }
            else if (round == 3)
            {
                x1 = fx1();
                x2 = fx2();
                x3 = fx3();
                x4 = fx4();
                x5 = fx5();
                outputValues.AppendText(Environment.NewLine + "Third Round: "
                    + Environment.NewLine + $"x1 equals {x1.ToString()}"
                    + Environment.NewLine + $"x2 equals {x2.ToString()}"
                    + Environment.NewLine + $"x3 equals {x3.ToString()}"
                    + Environment.NewLine + $"x4 equals {x4.ToString()}"
                    + Environment.NewLine + $"x5 equals {x5.ToString()}");
            }
            
        }
        
    }
}
