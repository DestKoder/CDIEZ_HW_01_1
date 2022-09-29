using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace С_DIEZ_HW_01_1
{
    public partial class Form1 : Form
    {

        string login = "admin";
        string password = "admin";

        public Form1()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            button1.TextAlign = button1.TextAlign == ContentAlignment.MiddleLeft ? ContentAlignment.MiddleRight : ContentAlignment.MiddleLeft;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text.Equals(login) && textBox2.Text.Equals(password) ? "Вы успешно вошли" : "Некорректные данные для входа");
        }
    }
}
