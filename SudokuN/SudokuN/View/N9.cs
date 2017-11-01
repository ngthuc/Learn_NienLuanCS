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
    public partial class N9 : Form
    {
        Number[,] nb = new Number[9, 9];
        TextBox[,] lbl = new TextBox[9, 9];
        Model md = new Model();
        Class9 n9 = new Class9();
        public N9()
        {
            InitializeComponent();
        }

        private void N9_Load(object sender, EventArgs e)
        {
            nb = md.newMatrix(9);
            //Nạp ma trận lên và hiển thị hình ảnh
            lbl = n9.clickMove81toArray(lbl11, lbl12, lbl13, lbl14, lbl15, lbl16, lbl17, lbl18, lbl19,
             lbl21, lbl22, lbl23, lbl24, lbl25, lbl26, lbl27, lbl28, lbl29,
             lbl31, lbl32, lbl33, lbl34, lbl35, lbl36, lbl37, lbl38, lbl39,
             lbl41, lbl42, lbl43, lbl44, lbl45, lbl46, lbl47, lbl48, lbl49,
             lbl51, lbl52, lbl53, lbl54, lbl55, lbl56, lbl57, lbl58, lbl59,
             lbl61, lbl62, lbl63, lbl64, lbl65, lbl66, lbl67, lbl68, lbl69,
             lbl71, lbl72, lbl73, lbl74, lbl75, lbl76, lbl77, lbl78, lbl79,
             lbl81, lbl82, lbl83, lbl84, lbl85, lbl86, lbl87, lbl88, lbl89,
             lbl91, lbl92, lbl93, lbl94, lbl95, lbl96, lbl97, lbl98, lbl99, nb);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            this.N9_Load(sender, e);
            this.Check_Click(sender, e);
            // Giải ma trận rỗng một cách ngẫu nhiên
            n9.solveSudoku(nb, 0, 0,9);
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
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
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
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
            Class9 n9 = new Class9();
            //Nạp ma trận lên và hiển thị hình ảnh
            TextBox[,] lbl  = n9.clickMove81toArray(
                lbl11, lbl12, lbl13, lbl14, lbl15, lbl16, lbl17, lbl18, lbl19,
             lbl21, lbl22, lbl23, lbl24, lbl25, lbl26, lbl27, lbl28, lbl29,
             lbl31, lbl32, lbl33, lbl34, lbl35, lbl36, lbl37, lbl38, lbl39,
             lbl41, lbl42, lbl43, lbl44, lbl45, lbl46, lbl47, lbl48, lbl49,
             lbl51, lbl52, lbl53, lbl54, lbl55, lbl56, lbl57, lbl58, lbl59,
             lbl61, lbl62, lbl63, lbl64, lbl65, lbl66, lbl67, lbl68, lbl69,
             lbl71, lbl72, lbl73, lbl74, lbl75, lbl76, lbl77, lbl78, lbl79,
             lbl81, lbl82, lbl83, lbl84, lbl85, lbl86, lbl87, lbl88, lbl89,
             lbl91, lbl92, lbl93, lbl94, lbl95, lbl96, lbl97, lbl98, lbl99, nb);
            if (n9.checkFeasible(nb, 9) == false) MessageBox.Show("Can't play this! You must clear and replay", "Check Maxtrix", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("It all ok ! You can continue", "Check Maxtrix", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
