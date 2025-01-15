namespace CALCULATOR_2._0
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
            txtTotal = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btnCLR = new Button();
            btndot = new Button();
            btn0 = new Button();
            btn9 = new Button();
            btnCalc = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            btnErase = new Button();
            btnPluMin = new Button();
            SuspendLayout();
            // 
            // txtTotal
            // 
            txtTotal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTotal.Font = new Font("Segoe UI Semibold", 35F, FontStyle.Bold);
            txtTotal.Location = new Point(12, 12);
            txtTotal.Multiline = true;
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(700, 76);
            txtTotal.TabIndex = 0;
            txtTotal.TextChanged += txtTotal_TextChanged;
            // 
            // btn1
            // 
            btn1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.Location = new Point(45, 99);
            btn1.Name = "btn1";
            btn1.Size = new Size(70, 54);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn2.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.Location = new Point(147, 100);
            btn2.Name = "btn2";
            btn2.Size = new Size(76, 53);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn3.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.Location = new Point(265, 99);
            btn3.Name = "btn3";
            btn3.Size = new Size(78, 54);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn4.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.Location = new Point(379, 100);
            btn4.Name = "btn4";
            btn4.Size = new Size(76, 53);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn8.Location = new Point(378, 201);
            btn8.Name = "btn8";
            btn8.Size = new Size(78, 51);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn7.Location = new Point(264, 201);
            btn7.Name = "btn7";
            btn7.Size = new Size(81, 51);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn6.Location = new Point(146, 201);
            btn6.Name = "btn6";
            btn6.Size = new Size(78, 51);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn5.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5.Location = new Point(44, 201);
            btn5.Name = "btn5";
            btn5.Size = new Size(70, 51);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btnCLR
            // 
            btnCLR.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCLR.Location = new Point(366, 287);
            btnCLR.Name = "btnCLR";
            btnCLR.Size = new Size(102, 50);
            btnCLR.TabIndex = 12;
            btnCLR.Text = "CLEAR";
            btnCLR.UseVisualStyleBackColor = true;
            btnCLR.Click += btnCLR_Click;
            // 
            // btndot
            // 
            btndot.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndot.Location = new Point(264, 287);
            btndot.Name = "btndot";
            btndot.Size = new Size(80, 50);
            btndot.TabIndex = 11;
            btndot.Text = ".";
            btndot.UseVisualStyleBackColor = true;
            btndot.Click += btndot_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn0.Location = new Point(146, 288);
            btn0.Name = "btn0";
            btn0.Size = new Size(78, 50);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn9.Location = new Point(44, 287);
            btn9.Name = "btn9";
            btn9.Size = new Size(72, 51);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btnCalc
            // 
            btnCalc.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalc.Location = new Point(129, 363);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(227, 50);
            btnCalc.TabIndex = 13;
            btnCalc.Text = "CALCULATE";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // button14
            // 
            button14.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button14.Location = new Point(503, 100);
            button14.Name = "button14";
            button14.Size = new Size(78, 50);
            button14.TabIndex = 14;
            button14.Text = "+";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // button15
            // 
            button15.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button15.Location = new Point(503, 173);
            button15.Name = "button15";
            button15.Size = new Size(78, 50);
            button15.TabIndex = 15;
            button15.Text = "-";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // button16
            // 
            button16.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button16.Location = new Point(503, 252);
            button16.Name = "button16";
            button16.Size = new Size(78, 50);
            button16.TabIndex = 16;
            button16.Text = "*";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // button17
            // 
            button17.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button17.Location = new Point(503, 330);
            button17.Name = "button17";
            button17.Size = new Size(78, 50);
            button17.TabIndex = 17;
            button17.Text = "/";
            button17.UseVisualStyleBackColor = true;
            button17.Click += button17_Click;
            // 
            // btnErase
            // 
            btnErase.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnErase.Location = new Point(608, 100);
            btnErase.Name = "btnErase";
            btnErase.Size = new Size(99, 53);
            btnErase.TabIndex = 18;
            btnErase.Text = "Back";
            btnErase.UseVisualStyleBackColor = true;
            btnErase.Click += btnErase_Click;
            // 
            // btnPluMin
            // 
            btnPluMin.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPluMin.Location = new Point(608, 177);
            btnPluMin.Name = "btnPluMin";
            btnPluMin.Size = new Size(99, 42);
            btnPluMin.TabIndex = 19;
            btnPluMin.Text = "+/-";
            btnPluMin.UseVisualStyleBackColor = true;
            btnPluMin.Click += btnPluMin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(739, 471);
            Controls.Add(btnPluMin);
            Controls.Add(btnErase);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(btnCalc);
            Controls.Add(btnCLR);
            Controls.Add(btndot);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(txtTotal);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTotal;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn8;
        private Button btn7;
        private Button btn6;
        private Button btn5;
        private Button btnCLR;
        private Button btndot;
        private Button btn0;
        private Button btn9;
        private Button btnCalc;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button btnErase;
        private Button btnPluMin;
    }
}
