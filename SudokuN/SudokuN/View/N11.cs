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
    public partial class N11 : Form
    {
        Number[,] nb = new Number[11, 11];
        TextBox[,] lbl = new TextBox[11, 11];
        Model md = new Model();
        Class11 n11 = new Class11();
        public N11()
        {
            InitializeComponent();
        }

        private void N11_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            nb = md.newMatrix(11);
            //Nạp ma trận lên và hiển thị hình ảnh
            lbl = n11.clickMove81toArray(
             lbl0101, lbl0102, lbl0103, lbl0104, lbl0105, lbl0106, lbl0107, lbl0108, lbl0109, lbl0110, lbl0111,
             lbl0201, lbl0202, lbl0203, lbl0204, lbl0205, lbl0206, lbl0207, lbl0208, lbl0209, lbl0210, lbl0211,
             lbl0301, lbl0302, lbl0303, lbl0304, lbl0305, lbl0306, lbl0307, lbl0308, lbl0309, lbl0310, lbl0311,
             lbl0401, lbl0402, lbl0403, lbl0404, lbl0405, lbl0406, lbl0407, lbl0408, lbl0409, lbl0410, lbl0411,
             lbl0501, lbl0502, lbl0503, lbl0504, lbl0505, lbl0506, lbl0507, lbl0508, lbl0509, lbl0510, lbl0511,
             lbl0601, lbl0602, lbl0603, lbl0604, lbl0605, lbl0606, lbl0607, lbl0608, lbl0609, lbl0610, lbl0611,
             lbl0701, lbl0702, lbl0703, lbl0704, lbl0705, lbl0706, lbl0707, lbl0708, lbl0709, lbl0710, lbl0711,
             lbl0801, lbl0802, lbl0803, lbl0804, lbl0805, lbl0806, lbl0807, lbl0808, lbl0809, lbl0810, lbl0811,
             lbl0901, lbl0902, lbl0903, lbl0904, lbl0905, lbl0906, lbl0907, lbl0908, lbl0909, lbl0910, lbl0911,
             lbl1001, lbl1002, lbl1003, lbl1004, lbl1005, lbl1006, lbl1007, lbl1008, lbl1009, lbl1010, lbl1011,
             lbl1101, lbl1102, lbl1103, lbl1104, lbl1105, lbl1106, lbl1107, lbl1108, lbl1109, lbl1110, lbl1111,
             nb);
            // Giải ma trận rỗng một cách ngẫu nhiên
            n11.solveSudoku(nb, 0, 0, 11);
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    lbl[i, j].Text = nb[i, j].Value.ToString();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
