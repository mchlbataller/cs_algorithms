using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class Converter
    {
        public int i;
        public int dec;    // decimal
        public int bas;    // base
        public int temp;
        public int[] converted = new int[100];


        public void Start(RichTextBox numOutput, int dec, int bas, int[] converted, int i, int temp)
        {
            i = 1;
            
            int checkErrors = conditions(numOutput, dec, bas, converted, i, temp);

            if (checkErrors == 0) // No errors.
            {
                numOutput.AppendText("Number " + temp
                    + " with base-10 to base-" + bas + " is equal to: ");
                converter(numOutput, dec, bas, converted, i, temp);
            } else if (checkErrors == 1)   //Invalid base
            {
                numOutput.AppendText("Your selected base is invalid. Please try again. \r\n");
            } else if (checkErrors == 2) // Unary numeral system
            {
                numOutput.Clear();
                numOutput.AppendText("Food for thought:" + Environment.NewLine + "The unary numeral system is the bijective base-1 numeral system. It is the simplest numeral system to represent natural numbers: in order to represent a number N, an arbitrarily chosen symbol representing 1 is repeated N times. This system is used in tallying. For example, using the tally mark |, the number 6 is represented as ||||||." + Environment.NewLine);
                numOutput.AppendText("TL;DR: The base you selected is invalid since it is only used for tallying.");
            } else if (checkErrors == 3)
            {
                numOutput.AppendText("The input number is invalid.");
            }


        }

        private int conditions(RichTextBox numOutput, int dec, int bas, int[] converted, int i, int temp)
        {
            if (bas == 0)
            {
                return 1;     // return was used to terminate
            }
            else if (bas == 1)
            {
                return 2;
            }

            //	If binary...
            if (bas == 2)
            {
                if (dec > 0)
                {
                    numOutput.AppendText("0");
                }
                // if dec is negative....
                else
                {
                    numOutput.AppendText("1");
                    dec = Math.Abs(dec);
                };
            };


            if (dec > 0 && bas > 36)
            {
                return 3;
            }
            return 0;
        }



        private void converter(RichTextBox numOutput, int dec, int bas, int[] converted, int i, int temp) {

            if (dec < 0 && bas > 0)
            {
                numOutput.AppendText("-");
                dec *= -1;
            }
            for (;;)
            {
                converted[i] = dec % bas;
                dec /= bas;
                i++;

                // Termination
                if (dec == 0)
                {
                    break;
                }
            }

            i--;    // If the proceeding number exceeds, reduce the counter.


            while (i > 0)
            {
                // Switch for Alphabet letters with Printing the converted[i] by default.               
                switch (converted[i])
                {
                    case 10:
                        numOutput.AppendText("A");
                        break;
                    case 11:
                        numOutput.AppendText("B");
                        break;
                    case 12:
                        numOutput.AppendText("C");
                        break;
                    case 13:
                        numOutput.AppendText("D");
                        break;
                    case 14:
                        numOutput.AppendText("E");
                        break;
                    case 15:
                        numOutput.AppendText("F");
                        break;
                    case 16:
                        numOutput.AppendText("G");
                        break;
                    case 17:
                        numOutput.AppendText("H");
                        break;
                    case 18:
                        numOutput.AppendText("I");
                        break;
                    case 19:
                        numOutput.AppendText("J");
                        break;
                    case 20:
                        numOutput.AppendText("K");
                        break;
                    case 21:
                        numOutput.AppendText("L");
                        break;
                    case 22:
                        numOutput.AppendText("M");
                        break;
                    case 23:
                        numOutput.AppendText("N");
                        break;
                    case 24:
                        numOutput.AppendText("O");
                        break;
                    case 25:
                        numOutput.AppendText("P");
                        break;
                    case 26:
                        numOutput.AppendText("Q");
                        break;
                    case 27:
                        numOutput.AppendText("R");
                        break;
                    case 28:
                        numOutput.AppendText("S");
                        break;
                    case 29:
                        numOutput.AppendText("T");
                        break;
                    case 30:
                        numOutput.AppendText("U");
                        break;
                    case 31:
                        numOutput.AppendText("V");
                        break;
                    case 32:
                        numOutput.AppendText("W");
                        break;
                    case 33:
                        numOutput.AppendText("X");
                        break;
                    case 34:
                        numOutput.AppendText("Y");
                        break;
                    case 35:
                        numOutput.AppendText("Z");
                        break;
                    default:
                        numOutput.AppendText(converted[i].ToString());
                        break;
                } // For >10 situations
                --i;
            }
            numOutput.AppendText("\r\n");
            return;
        } 
    }
}