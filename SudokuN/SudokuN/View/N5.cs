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
    public partial class N5 : Form
    {
        Number[,] nb = new Number[5,5 ];
        TextBox[,] lbl = new TextBox[5, 5];
        Model md = new Model();
        Class5 n5 = new Class5();
        public N5()
        {
            InitializeComponent();
        }

        private void N5_Load(object sender, EventArgs e)
        {
            nb = md.newMatrix(5);
            //Nạp ma trận lên và hiển thị hình ảnh
            lbl = n5.clickMove81toArray(
             lbl11, lbl12, lbl13, lbl14, lbl15,
             lbl21, lbl22, lbl23, lbl24, lbl25,
             lbl31, lbl32, lbl33, lbl34, lbl35,
             lbl41, lbl42, lbl43, lbl44, lbl45,
             lbl51, lbl52, lbl53, lbl54, lbl55,
              nb);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            this.N5_Load(sender, e);
            Class5 n5 = new Class5();
            //Nạp ma trận lên và hiển thị hình ảnh
            TextBox[,] lbl = n5.clickMove81toArray(
             lbl11, lbl12, lbl13, lbl14, lbl15,
             lbl21, lbl22, lbl23, lbl24, lbl25,
             lbl31, lbl32, lbl33, lbl34, lbl35,
             lbl41, lbl42, lbl43, lbl44, lbl45,
             lbl51, lbl52, lbl53, lbl54, lbl55,
             nb);
            if (n5.checkFeasible(nb, 5) == false) MessageBox.Show("Can't play this! You must clear and replay", "Check Maxtrix", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                // Giải ma trận rỗng một cách ngẫu nhiên
                n5.solveSudoku(nb, 0, 0, 5);
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        lbl[i, j].Text = nb[i, j].Value.ToString();
                    }
                }
            }

           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
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
            Class5 n5 = new Class5();
            //Nạp ma trận lên và hiển thị hình ảnh
            TextBox[,] lbl = n5.clickMove81toArray(
             lbl11, lbl12, lbl13, lbl14, lbl15, 
             lbl21, lbl22, lbl23, lbl24, lbl25, 
             lbl31, lbl32, lbl33, lbl34, lbl35, 
             lbl41, lbl42, lbl43, lbl44, lbl45,
             lbl51, lbl52, lbl53, lbl54, lbl55,
             nb);
            if (n5.checkFeasible(nb, 5) == false) MessageBox.Show("Can't play this! You must clear and replay", "Check Maxtrix", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("It all ok ! You can continue", "Check Maxtrix", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
