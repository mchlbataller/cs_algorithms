using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp2
{
	class Tribonacci_Sequence
	{
		// A tribonacci sequence starts at 0 and proceeds to 1.
		private int n0 = 0;    
		private int n1 = 1;
		private int n2 = 1;
		private int temp;


        public void Start(RichTextBox r, int i, int userInput)
		{
			for (;n2 < userInput;)      // Stop the loop if the any of the variables exceed the num input by user
			{
				if (i == 1)
				{
					r.AppendText($"{n0}, {n1}, {n2}, ");
				}
				else r.AppendText(temp + ", ");

				temp = n0 + n1 + n2;

				// Continue the adding process
				n0 = n1;
				n1 = n2;
				n2 = temp;
			}
		}
	}
}
