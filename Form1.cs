using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string can, chi;

        private void button2_Click(object sender, EventArgs e)
        {

            switch (Convert.ToInt32(txtduonglich.Text.Substring(3, 1)))
            {
                case 0:
                    can = "Canh";
                    break;
                case 1:
                    can = "Tân";
                    break;
                case 2:
                    can = "Nhâm";
                    break;
                case 3:
                    can = "Quý";
                    break;
                case 4:
                    can = "Giáp";
                    break;
                case 5:
                    can = "ất";
                    break;
                case 6:
                    can = "Bính";
                    break;
                case 7:
                    can = "Đinh";
                    break;
                case 8:
                    can = "Mậu";
                    break;
                case 9:
                    can = "Kỳ";
                    break;
            }

            switch (Convert.ToInt32(txtduonglich.Text) % 12)
            {
                case 0:
                    chi = "Mão";
                    break;
                case 1:
                    chi = "tuất";
                    break;
                case 2:
                    chi = "Hơi";
                    break;
                case 3:
                    chi = "Quý";
                    break;
                case 4:
                    chi = "Sửu";
                    break;
                case 5:
                    chi = "Dần";
                    break;
                case 6:
                    chi = "Thìn";
                    break;
                case 7:
                    chi = "Tị";
                    break;
                case 8:
                    chi = "Ngọ";
                    break;
                case 9:
                    chi = "Mùi";
                    break;
                case 10:
                    chi = "Thân";
                    break;
                case 11:
                    chi = "Dậu";
                    break;
            }
            txtamlich.Text = can + " " + chi;
        }
    }
}

