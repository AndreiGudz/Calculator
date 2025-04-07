namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            inputAnswereLabel = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            buttonPlus = new Button();
            buttonMinus = new Button();
            buttonMultiply = new Button();
            buttonDivide = new Button();
            buttonSqr = new Button();
            buttonSqrt = new Button();
            buttonEquals = new Button();
            buttonClear = new Button();
            SuspendLayout();
            // 
            // inputAnswereLabel
            // 
            inputAnswereLabel.BackColor = SystemColors.ButtonHighlight;
            inputAnswereLabel.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 204);
            inputAnswereLabel.Location = new Point(12, 21);
            inputAnswereLabel.Name = "inputAnswereLabel";
            inputAnswereLabel.Size = new Size(654, 45);
            inputAnswereLabel.TabIndex = 0;
            inputAnswereLabel.Text = "0";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.1428576F);
            button1.Location = new Point(12, 88);
            button1.Name = "button1";
            button1.Size = new Size(107, 94);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += digitButton_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.1428576F);
            button2.Location = new Point(125, 88);
            button2.Name = "button2";
            button2.Size = new Size(107, 94);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += digitButton_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14.1428576F);
            button3.Location = new Point(238, 88);
            button3.Name = "button3";
            button3.Size = new Size(107, 94);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += digitButton_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 14.1428576F);
            button4.Location = new Point(12, 188);
            button4.Name = "button4";
            button4.Size = new Size(107, 94);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += digitButton_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 14.1428576F);
            button5.Location = new Point(125, 188);
            button5.Name = "button5";
            button5.Size = new Size(107, 94);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += digitButton_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 14.1428576F);
            button6.Location = new Point(238, 188);
            button6.Name = "button6";
            button6.Size = new Size(107, 94);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += digitButton_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 14.1428576F);
            button7.Location = new Point(12, 288);
            button7.Name = "button7";
            button7.Size = new Size(107, 94);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += digitButton_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 14.1428576F);
            button8.Location = new Point(125, 288);
            button8.Name = "button8";
            button8.Size = new Size(107, 94);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += digitButton_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 14.1428576F);
            button9.Location = new Point(238, 288);
            button9.Name = "button9";
            button9.Size = new Size(107, 94);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += digitButton_Click;
            // 
            // button0
            // 
            button0.Font = new Font("Segoe UI", 14.1428576F);
            button0.Location = new Point(125, 388);
            button0.Name = "button0";
            button0.Size = new Size(107, 94);
            button0.TabIndex = 10;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += digitButton_Click;
            // 
            // buttonPlus
            // 
            buttonPlus.Font = new Font("Segoe UI", 14.1428576F);
            buttonPlus.Location = new Point(436, 88);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(107, 94);
            buttonPlus.TabIndex = 11;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += operationButton_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.Font = new Font("Segoe UI", 14.1428576F);
            buttonMinus.Location = new Point(559, 88);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(107, 94);
            buttonMinus.TabIndex = 12;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            buttonMinus.Click += operationButton_Click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.Font = new Font("Segoe UI", 14.1428576F);
            buttonMultiply.Location = new Point(436, 188);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(107, 94);
            buttonMultiply.TabIndex = 13;
            buttonMultiply.Text = "*";
            buttonMultiply.UseVisualStyleBackColor = true;
            buttonMultiply.Click += operationButton_Click;
            // 
            // buttonDivide
            // 
            buttonDivide.Font = new Font("Segoe UI", 14.1428576F);
            buttonDivide.Location = new Point(559, 188);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(107, 94);
            buttonDivide.TabIndex = 14;
            buttonDivide.Text = "/";
            buttonDivide.UseVisualStyleBackColor = true;
            buttonDivide.Click += operationButton_Click;
            // 
            // buttonSqr
            // 
            buttonSqr.Font = new Font("Segoe UI", 14.1428576F);
            buttonSqr.Location = new Point(436, 288);
            buttonSqr.Name = "buttonSqr";
            buttonSqr.Size = new Size(107, 94);
            buttonSqr.TabIndex = 15;
            buttonSqr.Text = "^2";
            buttonSqr.UseVisualStyleBackColor = true;
            buttonSqr.Click += operationButton_Click;
            // 
            // buttonSqrt
            // 
            buttonSqrt.Font = new Font("Segoe UI", 14.1428576F);
            buttonSqrt.Location = new Point(559, 288);
            buttonSqrt.Name = "buttonSqrt";
            buttonSqrt.Size = new Size(107, 94);
            buttonSqrt.TabIndex = 16;
            buttonSqrt.Text = "Sqrt()";
            buttonSqrt.UseVisualStyleBackColor = true;
            buttonSqrt.Click += operationButton_Click;
            // 
            // buttonEquals
            // 
            buttonEquals.Font = new Font("Segoe UI", 14.1428576F);
            buttonEquals.Location = new Point(436, 388);
            buttonEquals.Name = "buttonEquals";
            buttonEquals.Size = new Size(107, 94);
            buttonEquals.TabIndex = 17;
            buttonEquals.Text = "=";
            buttonEquals.UseVisualStyleBackColor = true;
            buttonEquals.Click += buttonEquals_Click;
            // 
            // buttonClear
            // 
            buttonClear.Font = new Font("Segoe UI", 14.1428576F);
            buttonClear.Location = new Point(559, 388);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(107, 94);
            buttonClear.TabIndex = 18;
            buttonClear.Text = "Clr";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // Form1
            // 
            AcceptButton = buttonEquals;
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 502);
            Controls.Add(buttonClear);
            Controls.Add(buttonEquals);
            Controls.Add(buttonSqrt);
            Controls.Add(buttonSqr);
            Controls.Add(buttonDivide);
            Controls.Add(buttonMultiply);
            Controls.Add(buttonMinus);
            Controls.Add(buttonPlus);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(inputAnswereLabel);
            Name = "Form1";
            Text = "Калькулятор";
            ResumeLayout(false);
        }

        #endregion

        private Label inputAnswereLabel;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button buttonPlus;
        private Button buttonMinus;
        private Button buttonMultiply;
        private Button buttonDivide;
        private Button buttonSqr;
        private Button buttonSqrt;
        private Button buttonEquals;
        private Button buttonClear;
    }
}
