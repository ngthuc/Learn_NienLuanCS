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
    public partial class N7 : Form
    {
        Number[,] nb = new Number[7, 7];
        TextBox[,] lbl = new TextBox[7, 7];
        Model md = new Model();
        Class7 n7 = new Class7();
        public N7()
        {
            InitializeComponent();
        }

        private void N7_Load(object sender, EventArgs e)
        {
            nb = md.newMatrix(8);
            //Nạp ma trận lên và hiển thị hình ảnh
            lbl = n7.clickMove81toArray(
             lbl11, lbl12, lbl13, lbl14, lbl15, lbl16, lbl17,
             lbl21, lbl22, lbl23, lbl24, lbl25, lbl26, lbl27,
             lbl31, lbl32, lbl33, lbl34, lbl35, lbl36, lbl37,
             lbl41, lbl42, lbl43, lbl44, lbl45, lbl46, lbl47,
             lbl51, lbl52, lbl53, lbl54, lbl55, lbl56, lbl57,
             lbl61, lbl62, lbl63, lbl64, lbl65, lbl66, lbl67,
             lbl71, lbl72, lbl73, lbl74, lbl75, lbl76, lbl77,
              nb);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            this.N7_Load(sender, e);
            Class7 n7 = new Class7();
            //Nạp ma trận lên và hiển thị hình ảnh
            TextBox[,] lbl = n7.clickMove81toArray(
             lbl11, lbl12, lbl13, lbl14, lbl15, lbl16, lbl17,
             lbl21, lbl22, lbl23, lbl24, lbl25, lbl26, lbl27,
             lbl31, lbl32, lbl33, lbl34, lbl35, lbl36, lbl37,
             lbl41, lbl42, lbl43, lbl44, lbl45, lbl46, lbl47,
             lbl51, lbl52, lbl53, lbl54, lbl55, lbl56, lbl57,
             lbl61, lbl62, lbl63, lbl64, lbl65, lbl66, lbl67,
             lbl71, lbl72, lbl73, lbl74, lbl75, lbl76, lbl77,
             nb);
            if (n7.checkFeasible(nb, 7) == false) MessageBox.Show("Can't play this! You must clear and replay", "Check Maxtrix", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                // Giải ma trận rỗng một cách ngẫu nhiên
                n7.solveSudoku(nb, 0, 0, 7);
                for (int i = 0; i < 7; i++)
                {
                    for (int j = 0; j < 7; j++)
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
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
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
            Class7 n7 = new Class7();
            //Nạp ma trận lên và hiển thị hình ảnh
            TextBox[,] lbl = n7.clickMove81toArray(
             lbl11, lbl12, lbl13, lbl14, lbl15, lbl16, lbl17, 
             lbl21, lbl22, lbl23, lbl24, lbl25, lbl26, lbl27, 
             lbl31, lbl32, lbl33, lbl34, lbl35, lbl36, lbl37, 
             lbl41, lbl42, lbl43, lbl44, lbl45, lbl46, lbl47, 
             lbl51, lbl52, lbl53, lbl54, lbl55, lbl56, lbl57, 
             lbl61, lbl62, lbl63, lbl64, lbl65, lbl66, lbl67, 
             lbl71, lbl72, lbl73, lbl74, lbl75, lbl76, lbl77,           
             nb);
            if (n7.checkFeasible(nb, 7) == false) MessageBox.Show("Can't play this! You must clear and replay", "Check Maxtrix", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("It all ok ! You can continue", "Check Maxtrix", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
