using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Conics
    {
        // nested methods for conic outputs
        void circleOutput()
        {
            double r, x, y, h, k, ga, radius;

            x = d / (2 * a);
            y = f / (2 * a);
            r = (x * x) + (y * y);

            h = -(x); // vertex at h
            k = -(y); // vertex at k

            ga = g / a;
            radius = Math.Sqrt(r - ga);

            MessageBox.Show($"The conic section is circle\nThe radius is {radius}. \n Vertex at ({h}, {k})");

        }
        void parabolaVerticalOutput()
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
                MessageBox.Show($"The conic section is Vertical Parabola\nThe focus is {focus}. \n Vertex at ({h}, {k}) opening {upWard}");
            }
            else
            {
                downWard = "downwards";
                MessageBox.Show($"The conic section is Vertical Parabola\nThe focus is {focus}. \n Vertex at ({h}, {k}) opening {downWard}");
            }

        }

        void parabolaHorizontalOutput()
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
                MessageBox.Show($"The conic section is Horizontal Parabola\nThe focus is {focus}. \n Vertex at ({h}, {k}) opening {upWard}");
            }
            else
            {
                downWard = "downwards";
                MessageBox.Show($"The conic section is Horizontal Parabola\nThe focus is {focus}. \n Vertex at ({h}, {k}) opening {downWard}");
            }

        }

        void ellipseOutput()
        {
            double h, k, semiAxesA, semiAxesB;


            h = -d / (2 * a); // vertex at h
            k = -f / 2; // vertex at k


            semiAxesA = Math.Sqrt(c);
            semiAxesB = Math.Sqrt(1);

            MessageBox.Show($"The conic section is Ellipse. \nThe semi-axes are  a = {semiAxesA} and b {semiAxesB} . \n Vertex at ({h}, {k}).");
        }
        void hyperbolaOutput() // standard hyperbola
        {
            double x, asymptotes;

            x = -d / (2 * a);

            asymptotes = Math.Abs(b / a) * x;

            MessageBox.Show($"The conic section is Hyperbola \n The horizontal asymptote is {asymptotes}.");
        }


    }
}
}
