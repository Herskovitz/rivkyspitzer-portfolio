using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWinForms
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            btn0.Click += Btn_Click;
            btn1.Click += Btn_Click;
            btn2.Click += Btn_Click;
            btn3.Click += Btn_Click;
            btn4.Click += Btn_Click;
            btn5.Click += Btn_Click;
            btn6.Click += Btn_Click;
            btn7.Click += Btn_Click;
            btn8.Click += Btn_Click;
            btn9.Click += Btn_Click;
            btnAdd.Click += BtnOperator_Click;
            btnSubtract.Click += BtnOperator_Click;
            btnMultiply.Click += BtnOperator_Click;
            btnDivide.Click += BtnOperator_Click;
            btnClear.Click += BtnClear_Click;
            btnEquals.Click += BtnEquals_Click;
            btnDecimal.Click += BtnDecimal_Click;
            btnSign.Click += BtnSign_Click;

        }

        private int DetermineCurrentFactor()
        {
            int n = 0;

            if (txtFactor1.Text == "" || txtOperator.Text == "")
            {
                n = 1;
            }
            else if (txtFactor1.Text != "" && txtAnswer.Text == "" && txtOperator.Text != "")
            {
                n = 2;
            }

            return n;
        }

        private string GetCurrentFactorValue()
        {
            string factorvalue = "";
            int dcf = DetermineCurrentFactor();

            switch (dcf)
            {
                case 1:
                    factorvalue = txtFactor1.Text;
                    break;
                case 2:
                    factorvalue = txtFactor2.Text;
                    break;
            }
            return factorvalue;
        }

        private void SetCurrentFactorValue(string inputvalue)
        {
            int dcf = DetermineCurrentFactor();

            switch (dcf)
            {
                case 1:
                    txtFactor1.Text = inputvalue;
                    break;
                case 2:
                    txtFactor2.Text = inputvalue;
                    break;
            }
        }

        private void InputSign()
        {
            string gcfv = GetCurrentFactorValue();

            switch (gcfv.StartsWith("-"))
            {
                case true:
                    SetCurrentFactorValue(gcfv.Substring(1));
                    break;
                case false:
                    SetCurrentFactorValue("-" + gcfv);
                    break;
            }
        }

        private void InputDecimal()
        {
            string gcfv = GetCurrentFactorValue();

            if (!gcfv.Contains("."))
            {
                SetCurrentFactorValue(gcfv + ".");
            }
        }

        private void Calculate()
        {

            decimal Factor1 = 0;
            decimal Factor2 = 0;
            decimal Answer = 0;

            bool x = decimal.TryParse(txtFactor1.Text, out Factor1);
            bool y = decimal.TryParse(txtFactor2.Text, out Factor2);

            string opr = txtOperator.Text;

            if (x == false)
            {
                txtFactor1.Text = "";
            }
            else if (y == false)
            {
                txtFactor2.Text = "";
            }

            else if (opr == "÷" && txtFactor2.Text == "0")
            {
                txtFactor2.Text = "";

            }
            else if (txtFactor1.Text != "" && txtFactor2.Text != "" && txtOperator.Text != "")

            {

                switch (opr)
                {
                    case "+":
                        Answer = Factor1 + Factor2;
                        break;
                    case "-":
                        Answer = Factor1 - Factor2;
                        break;
                    case "*":
                        Answer = Factor1 * Factor2;
                        break;
                    case "÷":
                        Answer = Factor1 / Factor2;
                        break;
                }
            }

            txtAnswer.Text = Answer.ToString();
        }

        private void BtnSign_Click(object? sender, EventArgs e)
        {
            InputSign();
        }


        private void BtnDecimal_Click(object? sender, EventArgs e)
        {
            InputDecimal();
        }


        private void BtnEquals_Click(object? sender, EventArgs e)
        {
            Calculate();
        }

        private void BtnClear_Click(object? sender, EventArgs e)
        {
            txtFactor1.Text = "";
            txtOperator.Text = "";
            txtFactor2.Text = "";
            txtAnswer.Text = "";
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            Button btn = (Button)sender;
            SetCurrentFactorValue(GetCurrentFactorValue() + btn.Text);
        }

        private void BtnOperator_Click(object? sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtOperator.Text = btn.Text;
        }
    }
}