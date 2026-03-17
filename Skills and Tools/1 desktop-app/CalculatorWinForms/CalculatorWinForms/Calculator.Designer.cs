namespace CalculatorWinForms
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tblMain = new TableLayoutPanel();
            txtFactor1 = new TextBox();
            txtFactor2 = new TextBox();
            txtAnswer = new TextBox();
            txtOperator = new TextBox();
            btnSign = new Button();
            btn0 = new Button();
            btnDecimal = new Button();
            btnEquals = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnAdd = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnSubtract = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btnClear = new Button();
            tblMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tblMain.ColumnCount = 4;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblMain.Controls.Add(txtFactor1, 0, 0);
            tblMain.Controls.Add(txtFactor2, 2, 0);
            tblMain.Controls.Add(txtAnswer, 3, 0);
            tblMain.Controls.Add(txtOperator, 1, 0);
            tblMain.Controls.Add(btnSign, 0, 5);
            tblMain.Controls.Add(btn0, 1, 5);
            tblMain.Controls.Add(btnDecimal, 2, 5);
            tblMain.Controls.Add(btnEquals, 3, 5);
            tblMain.Controls.Add(btn1, 0, 4);
            tblMain.Controls.Add(btn2, 1, 4);
            tblMain.Controls.Add(btn3, 2, 4);
            tblMain.Controls.Add(btnAdd, 3, 4);
            tblMain.Controls.Add(btn4, 0, 3);
            tblMain.Controls.Add(btn5, 1, 3);
            tblMain.Controls.Add(btn6, 2, 3);
            tblMain.Controls.Add(btnSubtract, 3, 3);
            tblMain.Controls.Add(btn7, 0, 2);
            tblMain.Controls.Add(btn8, 1, 2);
            tblMain.Controls.Add(btn9, 2, 2);
            tblMain.Controls.Add(btnMultiply, 3, 2);
            tblMain.Controls.Add(btnDivide, 3, 1);
            tblMain.Controls.Add(btnClear, 0, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 6;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666718F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tblMain.Size = new Size(511, 703);
            tblMain.TabIndex = 0;
            // 
            // txtFactor1
            // 
            txtFactor1.BackColor = Color.LightGray;
            txtFactor1.Dock = DockStyle.Fill;
            txtFactor1.Location = new Point(4, 4);
            txtFactor1.Multiline = true;
            txtFactor1.Name = "txtFactor1";
            txtFactor1.Size = new Size(120, 110);
            txtFactor1.TabIndex = 0;
            txtFactor1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFactor2
            // 
            txtFactor2.BackColor = Color.LightGray;
            txtFactor2.Dock = DockStyle.Fill;
            txtFactor2.Location = new Point(258, 4);
            txtFactor2.Multiline = true;
            txtFactor2.Name = "txtFactor2";
            txtFactor2.Size = new Size(120, 110);
            txtFactor2.TabIndex = 2;
            txtFactor2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtAnswer
            // 
            txtAnswer.BackColor = Color.LightGray;
            txtAnswer.Dock = DockStyle.Fill;
            txtAnswer.Location = new Point(385, 4);
            txtAnswer.Multiline = true;
            txtAnswer.Name = "txtAnswer";
            txtAnswer.ReadOnly = true;
            txtAnswer.Size = new Size(122, 110);
            txtAnswer.TabIndex = 3;
            // 
            // txtOperator
            // 
            txtOperator.BackColor = Color.LightGray;
            txtOperator.Dock = DockStyle.Fill;
            txtOperator.Location = new Point(131, 4);
            txtOperator.Multiline = true;
            txtOperator.Name = "txtOperator";
            txtOperator.Size = new Size(120, 110);
            txtOperator.TabIndex = 1;
            txtOperator.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSign
            // 
            btnSign.BackColor = Color.LightSteelBlue;
            btnSign.Dock = DockStyle.Fill;
            btnSign.Location = new Point(4, 585);
            btnSign.Name = "btnSign";
            btnSign.Size = new Size(120, 114);
            btnSign.TabIndex = 18;
            btnSign.Text = "-/+";
            btnSign.UseVisualStyleBackColor = false;
            // 
            // btn0
            // 
            btn0.BackColor = Color.LightSteelBlue;
            btn0.Dock = DockStyle.Fill;
            btn0.Location = new Point(131, 585);
            btn0.Name = "btn0";
            btn0.Size = new Size(120, 114);
            btn0.TabIndex = 19;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            // 
            // btnDecimal
            // 
            btnDecimal.BackColor = Color.LightSteelBlue;
            btnDecimal.Dock = DockStyle.Fill;
            btnDecimal.Location = new Point(258, 585);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(120, 114);
            btnDecimal.TabIndex = 20;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = false;
            // 
            // btnEquals
            // 
            btnEquals.BackColor = Color.LightCoral;
            btnEquals.Dock = DockStyle.Fill;
            btnEquals.Location = new Point(385, 585);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(122, 114);
            btnEquals.TabIndex = 21;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = false;
            // 
            // btn1
            // 
            btn1.BackColor = Color.LightSteelBlue;
            btn1.Dock = DockStyle.Fill;
            btn1.Location = new Point(4, 469);
            btn1.Name = "btn1";
            btn1.Size = new Size(120, 109);
            btn1.TabIndex = 14;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            btn2.BackColor = Color.LightSteelBlue;
            btn2.Dock = DockStyle.Fill;
            btn2.Location = new Point(131, 469);
            btn2.Name = "btn2";
            btn2.Size = new Size(120, 109);
            btn2.TabIndex = 15;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            btn3.BackColor = Color.LightSteelBlue;
            btn3.Dock = DockStyle.Fill;
            btn3.Location = new Point(258, 469);
            btn3.Name = "btn3";
            btn3.Size = new Size(120, 109);
            btn3.TabIndex = 16;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightCoral;
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.Location = new Point(385, 469);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(122, 109);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            btn4.BackColor = Color.LightSteelBlue;
            btn4.Dock = DockStyle.Fill;
            btn4.Location = new Point(4, 353);
            btn4.Name = "btn4";
            btn4.Size = new Size(120, 109);
            btn4.TabIndex = 10;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            btn5.BackColor = Color.LightSteelBlue;
            btn5.Dock = DockStyle.Fill;
            btn5.Location = new Point(131, 353);
            btn5.Name = "btn5";
            btn5.Size = new Size(120, 109);
            btn5.TabIndex = 11;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            btn6.BackColor = Color.LightSteelBlue;
            btn6.Dock = DockStyle.Fill;
            btn6.Location = new Point(258, 353);
            btn6.Name = "btn6";
            btn6.Size = new Size(120, 109);
            btn6.TabIndex = 12;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            // 
            // btnSubtract
            // 
            btnSubtract.BackColor = Color.LightCoral;
            btnSubtract.Dock = DockStyle.Fill;
            btnSubtract.Location = new Point(385, 353);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(122, 109);
            btnSubtract.TabIndex = 13;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = false;
            // 
            // btn7
            // 
            btn7.BackColor = Color.LightSteelBlue;
            btn7.Dock = DockStyle.Fill;
            btn7.Location = new Point(4, 237);
            btn7.Name = "btn7";
            btn7.Size = new Size(120, 109);
            btn7.TabIndex = 6;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            // 
            // btn8
            // 
            btn8.BackColor = Color.LightSteelBlue;
            btn8.Dock = DockStyle.Fill;
            btn8.Location = new Point(131, 237);
            btn8.Name = "btn8";
            btn8.Size = new Size(120, 109);
            btn8.TabIndex = 7;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            // 
            // btn9
            // 
            btn9.BackColor = Color.LightSteelBlue;
            btn9.Dock = DockStyle.Fill;
            btn9.Location = new Point(258, 237);
            btn9.Name = "btn9";
            btn9.Size = new Size(120, 109);
            btn9.TabIndex = 8;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.LightCoral;
            btnMultiply.Dock = DockStyle.Fill;
            btnMultiply.Location = new Point(385, 237);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(122, 109);
            btnMultiply.TabIndex = 9;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = false;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.LightCoral;
            btnDivide.Dock = DockStyle.Fill;
            btnDivide.Location = new Point(385, 121);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(122, 109);
            btnDivide.TabIndex = 5;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.LightCoral;
            tblMain.SetColumnSpan(btnClear, 3);
            btnClear.Dock = DockStyle.Fill;
            btnClear.Location = new Point(4, 121);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(374, 109);
            btnClear.TabIndex = 4;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 703);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Calculator";
            Text = "Calculator";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private TextBox txtFactor1;
        private TextBox txtFactor2;
        private TextBox txtAnswer;
        private TextBox txtOperator;
        private Button btnSign;
        private Button btn0;
        private Button btnDecimal;
        private Button btnEquals;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnAdd;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnSubtract;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btnClear;
    }
}