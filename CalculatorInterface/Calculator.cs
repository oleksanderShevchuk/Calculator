﻿using Calculator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorInterface
{
    public partial class Calculator : Form
    {
        private Calculations calculations = new Calculations();
        private string IsSymbol;
        private decimal firstValue;
        private decimal secondValue;
        public Calculator()
        {
            InitializeComponent();
        }

        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0")
            {
                label1.Text += "0";
            }
        }
        private void OneBtn_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text == "0" ? "1" : label1.Text += "1";
        }
        private void TwoBtn_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text == "0" ? "2" : label1.Text += "2";
        }

        private void ThreeBtn_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text == "0" ? "3" : label1.Text += "3";
        }

        private void FourBtn_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text == "0" ? "4" : label1.Text += "4";
        }

        private void FiveBtn_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text == "0" ? "5" : label1.Text += "5";
        }

        private void SixBtn_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text == "0" ? "6" : label1.Text += "6";
        }

        private void SevenBtn_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text == "0" ? "7" : label1.Text += "7";
        }

        private void EightBtn_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text == "0" ? "8" : label1.Text += "8";
        }

        private void NineBtn_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text == "0" ? "9" : label1.Text += "9";
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            CalculationsBtn(sender, e, "+");
        }
        private void SubtractionBtn_Click(object sender, EventArgs e)
        {
            CalculationsBtn(sender, e, "-");
        }

        private void CalculationsBtn(object sender, EventArgs e, string symbol)
        {
            if (label1.Text != null)
            {   
                if (label2.Text == "")
                {
                    firstValue = Convert.ToDecimal(label1.Text);
                    label2.Text = label1.Text + " " + symbol;
                    label1.Text = "0";
                }
                else
                {
                    TotalBtn_Click(sender, e);
                    label2.Text = label1.Text + " " + symbol;
                    label1.Text = "0";
                }
                IsSymbol = symbol;
            }
        }

        private void TotalBtn_Click(object sender, EventArgs e)
        {
            secondValue = Convert.ToDecimal(label1.Text);
            decimal result = 0;
            if (label1.Text != null && label2.Text != null)
            {
                switch (IsSymbol)
                {
                    case "+":
                        result = calculations.Addition(firstValue, secondValue);
                        break;
                    case "-":
                        result = calculations.Subtraction(firstValue, secondValue);
                        break;
                    default:
                        break;
                }
                firstValue = result;
                label1.Text = result.ToString();
                label2.Text = "";
            }
            
        }
        private void DotBtn_Click(object sender, EventArgs e)
        {
            label1.Text += ",";
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            label2.Text = "";
        }
    }
}