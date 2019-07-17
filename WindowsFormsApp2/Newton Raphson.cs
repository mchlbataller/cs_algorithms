using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class NewtonRaphson
    {
        public static double Sqrt(double x, int y)
        {
            double z = x;
            double w = 1;
            double e = 0.000001;
            while (z - w > e)
            {
                z = ((y - 1) * z + w) / y;
                w = x / Math.Pow(z, (y - 1));
            }
            return z;
        }

        public static void Start(RichTextBox output, double num, int rad)
        {
            if (rad == 1)
            {
                output.AppendText($"The 1st root of {num} is {num}" + Environment.NewLine);
            }
            else if (rad == 2)
            {
                output.AppendText($"The square root of {num} is {NewtonRaphson.Sqrt(num, rad)}" + Environment.NewLine);
            }
            else if (rad == 3)
            {
                output.AppendText($"The third root of {num} is {NewtonRaphson.Sqrt(num, rad)}" + Environment.NewLine);
            }
            else
            {
                output.AppendText($"The {rad}th root of {num} is {NewtonRaphson.Sqrt(num, rad)}" + Environment.NewLine);
            }
        }


    }
}

