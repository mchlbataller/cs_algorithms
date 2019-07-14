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
		public int dec;    // dec
		public int bas;    // base
		public int temp;
		public int[] converted = new int[100];
		public Converter()
		{
			i = 0;
            temp = 100;
		}

		public void converterProcess(RichTextBox numOutput, int dec, int bas, int[] converted, int i, int temp)
		{
			i = 1;

			numOutput.AppendText("Number " + temp + " with base-10 to base-" + bas + " is equal to: ");




			//			===============	ENTERING CONVERSION PROCESS	=================			//


			//           ===== INITIAL CONDITIONS START =====             //
			// Terminate if entered input is invalid
			if (bas == 0)
			{
				numOutput.AppendText("Your output is invalid. Please try again.\n\n");
				return;     // return was used to terminate
			}
            
			//	If binary...
			if (bas == 2)
			{
				if (dec > 0)
				{
					numOutput.AppendText("0");
				}
				else       // if dec is negative....
				{
					numOutput.AppendText("1");
					dec = Math.Abs(dec);
                };
			};

			if (dec < 0 && bas > 0)
			{
				numOutput.AppendText("-");
				dec *= -1;
			}

			if (dec > 0 && bas > 36)
			{
				numOutput.AppendText("The input is invalid");
				return;
			}

			//          ===== INITIAL CONDITIONS END =====           //

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


			i--;    // Required for the sake of correction.

			// Output
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
