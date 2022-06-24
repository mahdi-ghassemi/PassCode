using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace PassCode
{
    public partial class Form1 : Form
    {
        private int _second;
        private char[] _passCode = { '1', '2', '3', '4', '5', '6', '7', '8' };
        private const int _passCodeTime = 3;
        private DateTime _start;
        private DateTime _end;
        private TimeSpan _ts;
        private string _ueserInput;



        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
                textBox2.Focus();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != null)
                textBox3.Focus();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            if (textBox3.Text != null)
            {
                _start = DateTime.Now;
                textBox4.Focus();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            if (textBox4.Text != null)
            {
                _end = DateTime.Now;
                textBox5.Focus();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text != null)
                textBox6.Focus();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text != null)
                textBox7.Focus();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text != null)
                textBox8.Focus();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.Text != null)
                LoginBT.Focus();
        }

        private void LoginBT_Click(object sender, EventArgs e)
        {
            if (LoginBT.Text == "Login")
            {
                Login();
            }
            else if (LoginBT.Text == "Try Again")
            {
                TryAgain();
            }
           

        }

        private void TryAgain()
        {
            lblResult.Visible = false;
            label1.Visible = true;

            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;

            LoginBT.Text = "Login";
           
            
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox1.Focus();
        }

        private void Login()
        {
            _ts = _end - _start;
            _second = _ts.Seconds;

            String PassCode = new String(_passCode);
            _ueserInput = textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text + textBox5.Text + textBox6.Text + textBox7.Text + textBox8.Text;

            if (PassCode == _ueserInput && _second == _passCodeTime)
            {
                ShowMsg(1);
            }
            else
            {
                ShowMsg(2);
            }   
           
        }


        private void ShowMsg(int r)
        {

            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            label1.Visible = false;
            if (r == 1)
            {
                lblResult.Text = "Weldone !!! You entered correct Passcode";
                lblResult.ForeColor = System.Drawing.Color.Green;
            }
            if (r == 2)
            {
                lblResult.Text = "Opps , Sorry !!! You entered wrong Passcode";
                lblResult.ForeColor = System.Drawing.Color.Red;
            }
            
            lblResult.Visible = true;
            LoginBT.Text = "Try Again";
        }

      




    }
}
