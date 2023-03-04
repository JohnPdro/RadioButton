using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.pctrMorango.Visible = true;
            this.pctrFramboesa.Visible = true;
            this.pctrTomate.Visible = true;

            this.lblMorango.Visible = true;
            this.lblFramboesa.Visible = true;
            this.lblTomate.Visible = true;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.pctrMacaVerde.Visible = true;
            this.pctrKiwi.Visible = true;
            this.pctrLimao.Visible = true;

            this.lblMaca.Visible = true;
            this.lblKiwi.Visible = true;
            this.lblLimao.Visible = true;



        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.pctrMacaVerde.Visible = false;
            this.pctrKiwi.Visible = false;
            this.pctrLimao.Visible = false;

            this.pctrMorango.Visible = false;
            this.pctrFramboesa.Visible = false;
            this.pctrTomate.Visible = false;

            this.lblMorango.Visible = false;
            this.lblFramboesa.Visible = false;
            this.lblTomate.Visible = false;

            this.lblMaca.Visible = false;
            this.lblKiwi.Visible = false;
            this.lblLimao.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

            this.pctrMorango.Visible = true;
            

            this.lblMorango.Visible = true;
            
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            
            this.pctrFramboesa.Visible = true;
            

            
            this.lblFramboesa.Visible = true;
            
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            
            this.pctrTomate.Visible = true;

            
            this.lblTomate.Visible = true;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            this.pctrMacaVerde.Visible = true;
            

            this.lblMaca.Visible = true;
            
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            
            this.pctrKiwi.Visible = true;
            

            
            this.lblKiwi.Visible = true;
            
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            
            this.pctrLimao.Visible = true;

            
            this.lblLimao.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pctrMorango_Click(object sender, EventArgs e)
        {

        }
    }
}
