using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_TinhCanCHi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string tinhcan(int nam)
        {
            string can1 = "";
            switch (nam % 10)
            {
                case 0:
                    can1 = "Canh";
                    break;
                case 1:
                    can1 = "Tân";
                    break;
                case 2:
                    can1 = "Nhâm";
                    break;
                case 3:
                    can1 = "Quý";
                    break;
                case 4:
                    can1 = "Giáp";
                    break;
                case 5:
                    can1 = "Ất";
                    break;
                case 6:
                    can1 = "Bính";
                    break;
                case 7:
                    can1 = "Đinh";
                    break;
                case 8:
                    can1 = "Mậu";
                    break;
                case 9:
                    can1 = "Kỵ";
                    break;
            }
            return can1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string chi = "", can = "";
            for (int i = 2000; i <= 2050; i++)
            {
                //int indexCan = i % 10;
                //int indexChi = i % 12;
                lbCanChi.Items.Add(i.ToString()+ "-" +tinhcan(i));
            }
            
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            string chi = "", can = "";

            switch (Convert.ToInt32(txtNam.Text) % 10)
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
                    can = "Ất";
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
                    can = "Kỵ";
                    break;
            }
            switch (Convert.ToInt32(txtNam.Text) % 12)
            {
                case 0:
                    chi = "Thân";
                    break;
                case 1:
                    chi = "Dậu";
                    break;
                case 2:
                    chi = "Tuất";
                    break;
                case 3:
                    chi = "Hợi";
                    break;
                case 4:
                    chi = "Tý";
                    break;
                case 5:
                    chi = "Sửu";
                    break;
                case 6:
                    chi = "Dần";
                    break;
                case 7:
                    chi = "Mão";
                    break;
                case 8:
                    chi = "Thìn";
                    break;
                case 9:
                    chi = "Tỵ";
                    break;
                case 10:
                    chi = "Ngọ";
                    break;
                case 11:
                    chi = "Mùi";
                    break;
            }
            txtCanChi.Text = can + " " + chi;

            
            lbCanChi.Items.Add(txtCanChi.Text);
        }
    }
}
