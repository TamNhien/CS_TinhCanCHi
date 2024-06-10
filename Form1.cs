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

        string TinhCan(int nam)
        {
            string[] canArray = { "Canh", "Tân", "Nhâm", "Quý", "Giáp", "Ất", "Bính", "Đinh", "Mậu", "Kỵ" };
            return canArray[nam % 10];
        }

        string TinhChi(int nam)
        {
            string[] chiArray = { "Thân", "Dậu", "Tuất", "Hợi", "Tý", "Sửu", "Dần", "Mão", "Thìn", "Tỵ", "Ngọ", "Mùi" };
            return chiArray[nam % 12];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 2000; i <= 2050; i++)
            {
                lbCanChi.Items.Add($"{i} - {TinhCan(i)} {TinhChi(i)}");
            }
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int nam = Convert.ToInt32(txtNam.Text);
            string can = TinhCan(nam);
            string chi = TinhChi(nam);

            string canChi = $"{can} {chi}";
            txtCanChi.Text = canChi;
        }
    }
}
