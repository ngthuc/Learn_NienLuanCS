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
    public partial class N16 : Form
    {
        Number[,] nb = new Number[16, 16];
        TextBox[,] lbl = new TextBox[16, 16];
        Model md = new Model();
        Class16 n16 = new Class16();
        public N16()
        {
            InitializeComponent();
        }

        private void N16_Load(object sender, EventArgs e)
        {
            nb = md.newMatrix(16);
            //Nạp ma trận lên và hiển thị hình ảnh
            lbl = n16.clickMove81toArray(
                lbl0101, lbl0102, lbl0103, lbl0104, lbl0105, lbl0106, lbl0107, lbl0108, lbl0109, lbl0110, lbl0111, lbl0112, lbl0113, lbl0114, lbl0115, lbl0116,
                lbl0201, lbl0202, lbl0203, lbl0204, lbl0205, lbl0206, lbl0207, lbl0208, lbl0209, lbl0210, lbl0211, lbl0212, lbl0213, lbl0214, lbl0215, lbl0216,
                lbl0301, lbl0302, lbl0303, lbl0304, lbl0305, lbl0306, lbl0307, lbl0308, lbl0309, lbl0310, lbl0311, lbl0312, lbl0313, lbl0314, lbl0315, lbl0316,
                lbl0401, lbl0402, lbl0403, lbl0404, lbl0405, lbl0406, lbl0407, lbl0408, lbl0409, lbl0410, lbl0411, lbl0412, lbl0413, lbl0414, lbl0415, lbl0416,
                lbl0501, lbl0502, lbl0503, lbl0504, lbl0505, lbl0506, lbl0507, lbl0508, lbl0509, lbl0510, lbl0511, lbl0512, lbl0513, lbl0514, lbl0515, lbl0516,
                lbl0601, lbl0602, lbl0603, lbl0604, lbl0605, lbl0606, lbl0607, lbl0608, lbl0609, lbl0610, lbl0611, lbl0612, lbl0613, lbl0614, lbl0615, lbl0616,
                lbl0701, lbl0702, lbl0703, lbl0704, lbl0705, lbl0706, lbl0707, lbl0708, lbl0709, lbl0710, lbl0711, lbl0712, lbl0713, lbl0714, lbl0715, lbl0716,
                lbl0801, lbl0802, lbl0803, lbl0804, lbl0805, lbl0806, lbl0807, lbl0808, lbl0809, lbl0810, lbl0811, lbl0812, lbl0813, lbl0814, lbl0815, lbl0816,
                lbl0901, lbl0902, lbl0903, lbl0904, lbl0905, lbl0906, lbl0907, lbl0908, lbl0909, lbl0910, lbl0911, lbl0912, lbl0913, lbl0914, lbl0915, lbl0916,
                lbl1001, lbl1002, lbl1003, lbl1004, lbl1005, lbl1006, lbl1007, lbl1008, lbl1009, lbl1010, lbl1011, lbl1012, lbl1013, lbl1014, lbl1015, lbl1016,
                lbl1101, lbl1102, lbl1103, lbl1104, lbl1105, lbl1106, lbl1107, lbl1108, lbl1109, lbl1110, lbl1111, lbl1112, lbl1113, lbl1114, lbl1115, lbl1116,
                lbl1201, lbl1202, lbl1203, lbl1204, lbl1205, lbl1206, lbl1207, lbl1208, lbl1209, lbl1210, lbl1211, lbl1212, lbl1213, lbl1214, lbl1215, lbl1216,
                lbl1301, lbl1302, lbl1303, lbl1304, lbl1305, lbl1306, lbl1307, lbl1308, lbl1309, lbl1310, lbl1311, lbl1312, lbl1313, lbl1314, lbl1315, lbl1316,
                lbl1401, lbl1402, lbl1403, lbl1404, lbl1405, lbl1406, lbl1407, lbl1408, lbl1409, lbl1410, lbl1411, lbl1412, lbl1413, lbl1414, lbl1415, lbl1416,
                lbl1501, lbl1502, lbl1503, lbl1504, lbl1505, lbl1506, lbl1507, lbl1508, lbl1509, lbl1510, lbl1511, lbl1512, lbl1513, lbl1514, lbl1515, lbl1516,
                lbl1601, lbl1602, lbl1603, lbl1604, lbl1605, lbl1606, lbl1607, lbl1608, lbl1609, lbl1610, lbl1611, lbl1612, lbl1613, lbl1614, lbl1615, lbl1616,
             nb);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            this.N16_Load(sender, e);
            // Giải ma trận rỗng một cách ngẫu nhiên
            n16.solveSudoku(nb, 0, 0, 16);
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    lbl[i, j].Text = nb[i, j].Value.ToString();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
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
            Class16 n10 = new Class16();
            //Nạp ma trận lên và hiển thị hình ảnh
            TextBox[,] lbl = n16.clickMove81toArray(
             lbl0101, lbl0102, lbl0103, lbl0104, lbl0105, lbl0106, lbl0107, lbl0108, lbl0109, lbl0110, lbl0111, lbl0112, lbl0113, lbl0114, lbl0115, lbl0116,
                lbl0201, lbl0202, lbl0203, lbl0204, lbl0205, lbl0206, lbl0207, lbl0208, lbl0209, lbl0210, lbl0211, lbl0212, lbl0213, lbl0214, lbl0215, lbl0216,
                lbl0301, lbl0302, lbl0303, lbl0304, lbl0305, lbl0306, lbl0307, lbl0308, lbl0309, lbl0310, lbl0311, lbl0312, lbl0313, lbl0314, lbl0315, lbl0316,
                lbl0401, lbl0402, lbl0403, lbl0404, lbl0405, lbl0406, lbl0407, lbl0408, lbl0409, lbl0410, lbl0411, lbl0412, lbl0413, lbl0414, lbl0415, lbl0416,
                lbl0501, lbl0502, lbl0503, lbl0504, lbl0505, lbl0506, lbl0507, lbl0508, lbl0509, lbl0510, lbl0511, lbl0512, lbl0513, lbl0514, lbl0515, lbl0516,
                lbl0601, lbl0602, lbl0603, lbl0604, lbl0605, lbl0606, lbl0607, lbl0608, lbl0609, lbl0610, lbl0611, lbl0612, lbl0613, lbl0614, lbl0615, lbl0616,
                lbl0701, lbl0702, lbl0703, lbl0704, lbl0705, lbl0706, lbl0707, lbl0708, lbl0709, lbl0710, lbl0711, lbl0712, lbl0713, lbl0714, lbl0715, lbl0716,
                lbl0801, lbl0802, lbl0803, lbl0804, lbl0805, lbl0806, lbl0807, lbl0808, lbl0809, lbl0810, lbl0811, lbl0812, lbl0813, lbl0814, lbl0815, lbl0816,
                lbl0901, lbl0902, lbl0903, lbl0904, lbl0905, lbl0906, lbl0907, lbl0908, lbl0909, lbl0910, lbl0911, lbl0912, lbl0913, lbl0914, lbl0915, lbl0916,
                lbl1001, lbl1002, lbl1003, lbl1004, lbl1005, lbl1006, lbl1007, lbl1008, lbl1009, lbl1010, lbl1011, lbl1012, lbl1013, lbl1014, lbl1015, lbl1016,
                lbl1101, lbl1102, lbl1103, lbl1104, lbl1105, lbl1106, lbl1107, lbl1108, lbl1109, lbl1110, lbl1111, lbl1112, lbl1113, lbl1114, lbl1115, lbl1116,
                lbl1201, lbl1202, lbl1203, lbl1204, lbl1205, lbl1206, lbl1207, lbl1208, lbl1209, lbl1210, lbl1211, lbl1212, lbl1213, lbl1214, lbl1215, lbl1216,
                lbl1301, lbl1302, lbl1303, lbl1304, lbl1305, lbl1306, lbl1307, lbl1308, lbl1309, lbl1310, lbl1311, lbl1312, lbl1313, lbl1314, lbl1315, lbl1316,
                lbl1401, lbl1402, lbl1403, lbl1404, lbl1405, lbl1406, lbl1407, lbl1408, lbl1409, lbl1410, lbl1411, lbl1412, lbl1413, lbl1414, lbl1415, lbl1416,
                lbl1501, lbl1502, lbl1503, lbl1504, lbl1505, lbl1506, lbl1507, lbl1508, lbl1509, lbl1510, lbl1511, lbl1512, lbl1513, lbl1514, lbl1515, lbl1516,
                lbl1601, lbl1602, lbl1603, lbl1604, lbl1605, lbl1606, lbl1607, lbl1608, lbl1609, lbl1610, lbl1611, lbl1612, lbl1613, lbl1614, lbl1615, lbl1616,
             nb);
            if (n16.checkFeasible(nb, 16) == false) MessageBox.Show("Can't play this! You must clear and replay", "Check Maxtrix", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("It all ok ! You can continue", "Check Maxtrix", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
