using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnBuyukSayiForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList listNumber = new ArrayList();

        private Boolean isNotEmpty()
        {
            if (input1.Text != "" && input2.Text != "" && input3.Text != "" && input4.Text != "" && input5.Text != ""
                && input6.Text != "")
                return true;
            return false;
        }


        private void buttonFindNumber_Click(object sender, EventArgs e)
        {
            if (isNotEmpty())
            {
                listNumber.Clear();
                listNumber.Add(Int16.Parse(input1.Text));
                listNumber.Add(Int16.Parse(input2.Text));
                listNumber.Add(Int16.Parse(input3.Text));
                listNumber.Add(Int16.Parse(input4.Text));
                listNumber.Add(Int16.Parse(input5.Text));
                listNumber.Add(Int16.Parse(input6.Text));
                listNumber.Sort();
                listNumber.Reverse();
                MessageBox.Show("En büyük 3. sayı: " + listNumber[2].ToString());
            }
            else
            {
                MessageBox.Show("Eksik sayılar var.");
            }
        }


        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            input1.Text = "";
            input2.Text = "";
            input3.Text = "";
            input4.Text = "";
            input5.Text = "";
            input6.Text = "";
        }
    }
}
