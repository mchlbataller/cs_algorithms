namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.converter = new System.Windows.Forms.Panel();
            this.numOutput = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.baseSelector = new System.Windows.Forms.NumericUpDown();
            this.submitNumber = new System.Windows.Forms.Button();
            this.numInput = new System.Windows.Forms.TextBox();
            this.tribonacci = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.trib_Input = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.trib_Output = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.converter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baseSelector)).BeginInit();
            this.tribonacci.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // converter
            // 
            this.converter.Controls.Add(this.label6);
            this.converter.Controls.Add(this.numOutput);
            this.converter.Controls.Add(this.label3);
            this.converter.Controls.Add(this.label2);
            this.converter.Controls.Add(this.label1);
            this.converter.Controls.Add(this.baseSelector);
            this.converter.Controls.Add(this.submitNumber);
            this.converter.Controls.Add(this.numInput);
            this.converter.Location = new System.Drawing.Point(0, 0);
            this.converter.Name = "converter";
            this.converter.Size = new System.Drawing.Size(598, 338);
            this.converter.TabIndex = 8;
            // 
            // numOutput
            // 
            this.numOutput.Location = new System.Drawing.Point(53, 223);
            this.numOutput.Name = "numOutput";
            this.numOutput.Size = new System.Drawing.Size(499, 69);
            this.numOutput.TabIndex = 14;
            this.numOutput.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Process Output:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Convert into base-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Input a decimal:";
            // 
            // baseSelector
            // 
            this.baseSelector.Location = new System.Drawing.Point(246, 113);
            this.baseSelector.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.baseSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.baseSelector.Name = "baseSelector";
            this.baseSelector.Size = new System.Drawing.Size(120, 20);
            this.baseSelector.TabIndex = 10;
            this.baseSelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // submitNumber
            // 
            this.submitNumber.Location = new System.Drawing.Point(246, 162);
            this.submitNumber.Name = "submitNumber";
            this.submitNumber.Size = new System.Drawing.Size(75, 23);
            this.submitNumber.TabIndex = 9;
            this.submitNumber.Text = "Submit";
            this.submitNumber.UseVisualStyleBackColor = true;
            this.submitNumber.Click += new System.EventHandler(this.submitNumber_Click);
            // 
            // numInput
            // 
            this.numInput.Location = new System.Drawing.Point(246, 72);
            this.numInput.Name = "numInput";
            this.numInput.Size = new System.Drawing.Size(171, 20);
            this.numInput.TabIndex = 8;
            // 
            // tribonacci
            // 
            this.tribonacci.Controls.Add(this.label5);
            this.tribonacci.Controls.Add(this.trib_Output);
            this.tribonacci.Controls.Add(this.button1);
            this.tribonacci.Controls.Add(this.label4);
            this.tribonacci.Controls.Add(this.trib_Input);
            this.tribonacci.Location = new System.Drawing.Point(1, 3);
            this.tribonacci.Name = "tribonacci";
            this.tribonacci.Size = new System.Drawing.Size(598, 331);
            this.tribonacci.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Input Number:";
            // 
            // trib_Input
            // 
            this.trib_Input.Location = new System.Drawing.Point(267, 73);
            this.trib_Input.Name = "trib_Input";
            this.trib_Input.Size = new System.Drawing.Size(105, 20);
            this.trib_Input.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Click Me";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trib_Output
            // 
            this.trib_Output.Location = new System.Drawing.Point(41, 159);
            this.trib_Output.Name = "trib_Output";
            this.trib_Output.Size = new System.Drawing.Size(519, 155);
            this.trib_Output.TabIndex = 3;
            this.trib_Output.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tribonacci Sequence";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Number Converter";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.richTextBox3);
            this.panel1.Controls.Add(this.richTextBox2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 331);
            this.panel1.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(216, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Number Sorting [Incomplete]";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 65);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(192, 243);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(135, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Input Number 1:";
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.Location = new System.Drawing.Point(233, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(207, 65);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(192, 243);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(403, 65);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(192, 243);
            this.richTextBox3.TabIndex = 6;
            this.richTextBox3.Text = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(598, 331);
            this.panel2.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(172, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(244, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Number Converter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(172, 128);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(244, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Tribonacci Sequence";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(172, 186);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(244, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Number Sorter";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 331);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tribonacci);
            this.Controls.Add(this.converter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.converter.ResumeLayout(false);
            this.converter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baseSelector)).EndInit();
            this.tribonacci.ResumeLayout(false);
            this.tribonacci.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Panel converter;
		private System.Windows.Forms.RichTextBox numOutput;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown baseSelector;
		private System.Windows.Forms.Button submitNumber;
		private System.Windows.Forms.TextBox numInput;
		private System.Windows.Forms.Panel tribonacci;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox trib_Input;
        private System.Windows.Forms.RichTextBox trib_Output;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}

