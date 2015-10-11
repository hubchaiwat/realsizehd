using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RealSizeHD
{
    public partial class Form1 : Form
    {
        private CConverter cConvert;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn4TB_Click(object sender, EventArgs e)
        {
            cConvert = new CConverter("4TB");
            tbSizeGB.Text = cConvert.getSizeGB().ToString();
            tbSizeMB.Text = cConvert.getSizeMB().ToString();
            tbSizeTB.Text = cConvert.getSizeTB().ToString();
        }

        private void btn2TB_Click(object sender, EventArgs e)
        {
            cConvert = new CConverter("2TB");
            tbSizeGB.Text = cConvert.getSizeGB().ToString();
            tbSizeMB.Text = cConvert.getSizeMB().ToString();
            tbSizeTB.Text = cConvert.getSizeTB().ToString();
        }

        private void btn1TB_Click(object sender, EventArgs e)
        {
            cConvert = new CConverter("1TB");
            tbSizeGB.Text = cConvert.getSizeGB().ToString();
            tbSizeMB.Text = cConvert.getSizeMB().ToString();
            tbSizeTB.Text = cConvert.getSizeTB().ToString();
        }

        private void btn500GB_Click(object sender, EventArgs e)
        {
            cConvert = new CConverter("500GB");
            tbSizeGB.Text = cConvert.getSizeGB().ToString();
            tbSizeMB.Text = cConvert.getSizeMB().ToString();
            tbSizeTB.Text = cConvert.getSizeTB().ToString();
        }

        private void btn250GB_Click(object sender, EventArgs e)
        {
            cConvert = new CConverter("250GB");
            tbSizeGB.Text = cConvert.getSizeGB().ToString();
            tbSizeMB.Text = cConvert.getSizeMB().ToString();
            tbSizeTB.Text = cConvert.getSizeTB().ToString();
        }

        private void btn125GB_Click(object sender, EventArgs e)
        {
            cConvert = new CConverter("125GB");
            tbSizeGB.Text = cConvert.getSizeGB().ToString();
            tbSizeMB.Text = cConvert.getSizeMB().ToString();
            tbSizeTB.Text = cConvert.getSizeTB().ToString();
        }

        private void btn480GB_Click(object sender, EventArgs e)
        {
            cConvert = new CConverter("480GB");
            tbSizeGB.Text = cConvert.getSizeGB().ToString();
            tbSizeMB.Text = cConvert.getSizeMB().ToString();
            tbSizeTB.Text = cConvert.getSizeTB().ToString();
        }

        private void btn240GB_Click(object sender, EventArgs e)
        {
            cConvert = new CConverter("240GB");
            tbSizeGB.Text = cConvert.getSizeGB().ToString();
            tbSizeMB.Text = cConvert.getSizeMB().ToString();
            tbSizeTB.Text = cConvert.getSizeTB().ToString();
        }

        private void btn120GB_Click(object sender, EventArgs e)
        {
            cConvert = new CConverter("120GB");
            tbSizeGB.Text = cConvert.getSizeGB().ToString();
            tbSizeMB.Text = cConvert.getSizeMB().ToString();
            tbSizeTB.Text = cConvert.getSizeTB().ToString();
        }
    }
}
