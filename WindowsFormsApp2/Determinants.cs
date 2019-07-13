using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WindowsFormsApp2
{
    class Determinants
    {

        private int[,] matrix;      // private means only this class can access this
        private int det;
        public Determinants(int dim)
        {
            matrix = new int[dim, dim];
        }

        public void Determinant_3x3()
        {
            det = (matrix[0, 0]*((matrix[1,1]*matrix[2,2]) - (matrix[1,2]*matrix[2,1])))
                - (matrix[0, 1] * ((matrix[1, 0] * matrix[2, 2]) - (matrix[1,2] * matrix[2,0])))
                - (matrix[0, 2] * ((matrix[1,0] * matrix[2,1]) - (matrix[1,1] * matrix[2,0])));
        }

        
        
    }
}
