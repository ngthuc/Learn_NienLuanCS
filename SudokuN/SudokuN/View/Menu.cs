using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuN.View
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            lbl3.Parent = picBack;
            lbl4.Parent = picBack;
            lbl5.Parent = picBack;
            lbl6.Parent = picBack;
            lbl7.Parent = picBack;
            lbl8.Parent = picBack;
            lbl9.Parent = picBack;
            lbl10.Parent = picBack;
            lbl12.Parent = picBack;
            lbl16.Parent = picBack;
            lblHome.Parent = picBack;
            lblAbout.Parent = picBack;


        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            About about = new About();
            this.Hide();
            about.ShowDialog();
            this.Show();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            N3 frm3 = new N3();
            this.Hide();
            frm3.ShowDialog();
            this.Show();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            N4 frm4 = new N4();
            this.Hide();
            frm4.ShowDialog();
            this.Show();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            N5 frm5 = new N5();
            this.Hide();
            frm5.ShowDialog();
            this.Show();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            N6 frm6 = new N6();
            this.Hide();
            frm6.ShowDialog();
            this.Show();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            N7 frm7 = new N7();
            this.Hide();
            frm7.ShowDialog();
            this.Show();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            N8 frm8 = new N8();
            this.Hide();
            frm8.ShowDialog();
            this.Show();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            N9 frm9 = new N9();
            this.Hide();
            frm9.ShowDialog();
            this.Show();
            
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            N10 frm10 = new N10();
            this.Hide();
            frm10.ShowDialog();
            this.Show();

        }

        private void btn11_Click(object sender, EventArgs e)
        {
            N11a frm11 = new N11a();
            this.Hide();
            frm11.ShowDialog();
            this.Show();
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            N12 frm12 = new N12();
            this.Hide();
            frm12.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            N16 frm16 = new N16();
            this.Hide();
            frm16.ShowDialog();
            this.Show();
        }

        private void lblAbout_MouseHover(object sender, EventArgs e)
        {
            lblAbout.ForeColor = Color.White;
            lblHome.ForeColor = Color.White;
        }

        private void lblAbout_MouseLeave(object sender, EventArgs e)
        {
            lblAbout.ForeColor = Color.Crimson;
            lblHome.ForeColor = Color.Crimson;
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
