﻿namespace Calculator_Rohde_Nick
{
    partial class Calculator
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.display = new System.Windows.Forms.TextBox();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.openP = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.times = new System.Windows.Forms.Button();
            this.enter = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.closeP = new System.Windows.Forms.Button();
            this.exponentiate = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(47, 15);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(292, 20);
            this.display.TabIndex = 0;
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(51, 102);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(40, 40);
            this.seven.TabIndex = 1;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.digit7Press);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(116, 102);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(40, 40);
            this.eight.TabIndex = 2;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.digit8Press);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(178, 102);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(40, 40);
            this.nine.TabIndex = 3;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.digit9Press);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(242, 134);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(40, 40);
            this.plus.TabIndex = 4;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.opAddPress);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(242, 180);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(40, 40);
            this.divide.TabIndex = 5;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.opDivPress);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(51, 160);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(40, 40);
            this.four.TabIndex = 6;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.digit4Press);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(116, 160);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(40, 40);
            this.five.TabIndex = 7;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.digit5Press);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(178, 160);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(40, 40);
            this.six.TabIndex = 8;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.digit6Press);
            // 
            // openP
            // 
            this.openP.Location = new System.Drawing.Point(242, 226);
            this.openP.Name = "openP";
            this.openP.Size = new System.Drawing.Size(40, 40);
            this.openP.TabIndex = 9;
            this.openP.Text = "(";
            this.openP.UseVisualStyleBackColor = true;
            this.openP.Click += new System.EventHandler(this.openParenPress);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(178, 217);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(40, 40);
            this.three.TabIndex = 10;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.digit3Press);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(116, 217);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(40, 40);
            this.two.TabIndex = 11;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.digit2Press);
            // 
            // one
            // 
            this.one.AccessibleName = "One Button";
            this.one.Location = new System.Drawing.Point(51, 217);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(40, 40);
            this.one.TabIndex = 12;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.digit1Press);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(51, 278);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(80, 40);
            this.zero.TabIndex = 13;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.digit0Press);
            // 
            // times
            // 
            this.times.Location = new System.Drawing.Point(299, 180);
            this.times.Name = "times";
            this.times.Size = new System.Drawing.Size(40, 40);
            this.times.TabIndex = 14;
            this.times.Text = "*";
            this.times.UseVisualStyleBackColor = true;
            this.times.Click += new System.EventHandler(this.opMulPress);
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(146, 278);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(80, 40);
            this.enter.TabIndex = 15;
            this.enter.Text = "Enter";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.verifyInput);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(299, 134);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(40, 40);
            this.minus.TabIndex = 16;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.opSubPress);
            // 
            // closeP
            // 
            this.closeP.Location = new System.Drawing.Point(299, 226);
            this.closeP.Name = "closeP";
            this.closeP.Size = new System.Drawing.Size(40, 40);
            this.closeP.TabIndex = 17;
            this.closeP.Text = ")";
            this.closeP.UseVisualStyleBackColor = true;
            this.closeP.Click += new System.EventHandler(this.closeParenPress);
            // 
            // exponentiate
            // 
            this.exponentiate.Location = new System.Drawing.Point(269, 88);
            this.exponentiate.Name = "exponentiate";
            this.exponentiate.Size = new System.Drawing.Size(40, 40);
            this.exponentiate.TabIndex = 18;
            this.exponentiate.Text = "^";
            this.exponentiate.UseVisualStyleBackColor = true;
            this.exponentiate.Click += new System.EventHandler(this.opExpPress);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Location = new System.Drawing.Point(50, 37);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(53, 13);
            this.error.TabIndex = 19;
            this.error.Text = "error label";
            this.error.Visible = false;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(87, 59);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(32, 13);
            this.resultLabel.TabIndex = 20;
            this.resultLabel.Text = "result";
            this.resultLabel.Visible = false;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(250, 278);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(80, 40);
            this.clear.TabIndex = 21;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clearPress);
            // 
            // Calculator
            // 
            this.AcceptButton = this.enter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 344);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.error);
            this.Controls.Add(this.exponentiate);
            this.Controls.Add(this.closeP);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.times);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.one);
            this.Controls.Add(this.two);
            this.Controls.Add(this.three);
            this.Controls.Add(this.openP);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.display);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button openP;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button times;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button closeP;
        private System.Windows.Forms.Button exponentiate;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button clear;
    }
}

