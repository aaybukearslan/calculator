using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        bool operators=false;
        double sonuc = 0;
        string opt = "";
        double ksonuc = 0;
        int faktoriyel=1;
        int x, y;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOlay(object sender, EventArgs e)
        {
            if (txtSonuc.Text == "0" ||  operators )
                txtSonuc.Clear();
            operators = false;
            Button btn = (Button)sender;
            txtSonuc.Text += btn.Text;
        }

        private void optIslem(object sender, EventArgs e)
        {
            operators = true;
            Button btn = (Button)sender;
            string newOpt = btn.Text;
            label1.Text = label1.Text + " " + txtSonuc.Text + " "+newOpt;
            switch(opt)
            {
                case "+": txtSonuc.Text = (sonuc + double.Parse(txtSonuc.Text)).ToString();break;
                case "-": txtSonuc.Text = (sonuc - double.Parse(txtSonuc.Text)).ToString(); break;
                case "*": txtSonuc.Text = (sonuc * double.Parse(txtSonuc.Text)).ToString(); break;
                case "/": txtSonuc.Text = (sonuc / double.Parse(txtSonuc.Text)).ToString(); break;
            }
            sonuc = double.Parse(txtSonuc.Text);
            txtSonuc.Text = sonuc.ToString();
            opt = newOpt;
                        

        }

        private void button17_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = "0";
            label1.Text = "";
            opt = "";
            sonuc = 0;

        }

        private void button15_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            operators = true;
            switch (opt)
            {
                case "+": txtSonuc.Text = (sonuc + double.Parse(txtSonuc.Text)).ToString(); break;
                case "-": txtSonuc.Text = (sonuc - double.Parse(txtSonuc.Text)).ToString(); break;
                case "*": txtSonuc.Text = (sonuc * double.Parse(txtSonuc.Text)).ToString(); break;
                case "/": txtSonuc.Text = (sonuc / double.Parse(txtSonuc.Text)).ToString(); break;
            }
            sonuc = double.Parse(txtSonuc.Text);
            txtSonuc.Text = sonuc.ToString();
            opt = "";
        
           
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (txtSonuc.Text == "0")
            {
                txtSonuc.Text = "0";
            }
            else if(operators)
            {
                txtSonuc.Text = "0";

            }
            if(!txtSonuc.Text.Contains(","))
            {
                txtSonuc.Text += ",";
            }

        }

        private void button23_Click(object sender, EventArgs e)
        {

            sonuc = double.Parse(txtSonuc.Text);
            ksonuc = sonuc * sonuc;
            txtSonuc.Text = "";
            txtSonuc.Text +=ksonuc;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            sonuc = double.Parse(txtSonuc.Text);
            txtSonuc.Text = "";
            txtSonuc.Text+=Math.Sqrt(sonuc);
        }

        private void button20_Click(object sender, EventArgs e)
        {
           
           
            sonuc = double.Parse(txtSonuc.Text);
            for (int i = 1; i <= sonuc; i++)
            {
                faktoriyel = faktoriyel *= i;
            }
            txtSonuc.Text = "";
            txtSonuc.Text += faktoriyel.ToString() ;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            int rakam = txtSonuc.Text.Length;
            if (rakam > 0)
            {
                txtSonuc.Text = txtSonuc.Text.Substring(0, rakam - 1);
            }
            
        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
           x = Convert.ToInt32(txtSonuc.Text);
          opt = "mod";
            label1.Text = txtSonuc.Text + "(mod)";
            txtSonuc.Text = "0";





        }

        private void txtSonuc_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSonuc_KeyPress(object sender, KeyPressEventArgs e)
        {
      
            
        }

        private void txtSonuc_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
    }
    }


