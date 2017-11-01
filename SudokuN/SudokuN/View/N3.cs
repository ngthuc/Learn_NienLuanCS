using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SudokuN.Controller;

namespace SudokuN.View
{
    public partial class N3 : Form
    {
        Number[,] nb = new Number[3, 3];
        TextBox[,] lbl = new TextBox[3, 3];
        Model md = new Model();
        Class3 n3 = new Class3();
        public N3()
        {
            InitializeComponent();
        }

        private void N3_Load(object sender, EventArgs e)
        {
            nb = md.newMatrix(3);
            //Nạp ma trận lên và hiển thị hình ảnh
            lbl = n3.clickMove81toArray(
             lbl11, lbl12, lbl13,
             lbl21, lbl22, lbl23,
             lbl31, lbl32, lbl33,
              nb);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {   
            this.N3_Load(sender, e);
            Check_Click(sender, e);
            // Giải ma trận rỗng một cách ngẫu nhiên
            n3.solveSudoku(nb, 0, 0, 3);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    lbl[i, j].Text = nb[i, j].Value.ToString();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    lbl[i, j].Text = "";
                }
            }
        }

        private void lblBack_MouseHover(object sender, EventArgs e)
        {
            lblBack.ForeColor = Color.White;
        }

        private void lblResult_MouseHover(object sender, EventArgs e)
        {
          lblResult.ForeColor = Color.White;
        }

        private void lblClear_MouseHover(object sender, EventArgs e)
        {
            lblClear.ForeColor = Color.White;
        }

        private void lblClear_MouseMove(object sender, MouseEventArgs e)
        {
            lblBack.ForeColor = Color.Crimson;
        }
        
        private void lblBack_MouseLeave(object sender, EventArgs e)
        {
            lblBack.ForeColor = Color.Crimson;
        }

        private void lblResult_MouseLeave(object sender, EventArgs e)
        {
            lblResult.ForeColor = Color.Crimson;
        }

        private void lblClear_MouseLeave(object sender, EventArgs e)
        {
            lblClear.ForeColor = Color.Crimson;
        }

        private void Check_Click(object sender, EventArgs e)
        {
            Class3 n3 = new Class3();
            //Nạp ma trận lên và hiển thị hình ảnh
            TextBox[,] lbl = n3.clickMove81toArray(
             lbl11, lbl12, lbl13, 
             lbl21, lbl22, lbl23, 
             lbl31, lbl32, lbl33, 
             nb);
            if (n3.checkFeasible(nb, 3) == false) MessageBox.Show("Can't play this! You must clear and replay", "Check Maxtrix", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("It all ok ! You can continue", "Check Maxtrix", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
