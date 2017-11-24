using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuN.Controller
{
    class Class16 : Model
    {

        //**************************************************************************************
        //Hàm kiểm tra tính hợp lệ trong một ô 9x9
        public override bool feasibleBlock(Number[,] Sudoku, int x, int y, int number, int value)
        {
            //Kiểm tra xe có bị trùng với ô nào trong khối của nó không
            int a = x / 4, b = y / 4;
            for (int i = 4 * a; i < 4 * a + 4; i++)
            {
                for (int j = 4 * b; j < 4 * b + 4; j++)
                {
                    if (Sudoku[i, j].Value == value && i != x && j != y) return false;
                }
            }
            return true;

        }


        //**************************************************************************************
        // Xử lý cho 100 ô đưa nó vào mảng textbox
        public TextBox[,] clickMove81toArray(
            TextBox pic0101, TextBox pic0102, TextBox pic0103, TextBox pic0104, TextBox pic0105, TextBox pic0106, TextBox pic0107, TextBox pic0108, TextBox pic0109, TextBox pic0110, TextBox pic0111, TextBox pic0112, TextBox pic0113, TextBox pic0114, TextBox pic0115, TextBox pic0116,
            TextBox pic0201, TextBox pic0202, TextBox pic0203, TextBox pic0204, TextBox pic0205, TextBox pic0206, TextBox pic0207, TextBox pic0208, TextBox pic0209, TextBox pic0210, TextBox pic0211, TextBox pic0212, TextBox pic0213, TextBox pic0214, TextBox pic0215, TextBox pic0216,
            TextBox pic0301, TextBox pic0302, TextBox pic0303, TextBox pic0304, TextBox pic0305, TextBox pic0306, TextBox pic0307, TextBox pic0308, TextBox pic0309, TextBox pic0310, TextBox pic0311, TextBox pic0312, TextBox pic0313, TextBox pic0314, TextBox pic0315, TextBox pic0316,
            TextBox pic0401, TextBox pic0402, TextBox pic0403, TextBox pic0404, TextBox pic0405, TextBox pic0406, TextBox pic0407, TextBox pic0408, TextBox pic0409, TextBox pic0410, TextBox pic0411, TextBox pic0412, TextBox pic0413, TextBox pic0414, TextBox pic0415, TextBox pic0416,
            TextBox pic0501, TextBox pic0502, TextBox pic0503, TextBox pic0504, TextBox pic0505, TextBox pic0506, TextBox pic0507, TextBox pic0508, TextBox pic0509, TextBox pic0510, TextBox pic0511, TextBox pic0512, TextBox pic0513, TextBox pic0514, TextBox pic0515, TextBox pic0516,
            TextBox pic0601, TextBox pic0602, TextBox pic0603, TextBox pic0604, TextBox pic0605, TextBox pic0606, TextBox pic0607, TextBox pic0608, TextBox pic0609, TextBox pic0610, TextBox pic0611, TextBox pic0612, TextBox pic0613, TextBox pic0614, TextBox pic0615, TextBox pic0616,
            TextBox pic0701, TextBox pic0702, TextBox pic0703, TextBox pic0704, TextBox pic0705, TextBox pic0706, TextBox pic0707, TextBox pic0708, TextBox pic0709, TextBox pic0710, TextBox pic0711, TextBox pic0712, TextBox pic0713, TextBox pic0714, TextBox pic0715, TextBox pic0716,
            TextBox pic0801, TextBox pic0802, TextBox pic0803, TextBox pic0804, TextBox pic0805, TextBox pic0806, TextBox pic0807, TextBox pic0808, TextBox pic0809, TextBox pic0810, TextBox pic0811, TextBox pic0812, TextBox pic0813, TextBox pic0814, TextBox pic0815, TextBox pic0816,
            TextBox pic0901, TextBox pic0902, TextBox pic0903, TextBox pic0904, TextBox pic0905, TextBox pic0906, TextBox pic0907, TextBox pic0908, TextBox pic0909, TextBox pic0910, TextBox pic0911, TextBox pic0912, TextBox pic0913, TextBox pic0914, TextBox pic0915, TextBox pic0916,
            TextBox pic1001, TextBox pic1002, TextBox pic1003, TextBox pic1004, TextBox pic1005, TextBox pic1006, TextBox pic1007, TextBox pic1008, TextBox pic1009, TextBox pic1010, TextBox pic1011, TextBox pic1012, TextBox pic1013, TextBox pic1014, TextBox pic1015, TextBox pic1016,
            TextBox pic1101, TextBox pic1102, TextBox pic1103, TextBox pic1104, TextBox pic1105, TextBox pic1106, TextBox pic1107, TextBox pic1108, TextBox pic1109, TextBox pic1110, TextBox pic1111, TextBox pic1112, TextBox pic1113, TextBox pic1114, TextBox pic1115, TextBox pic1116,
            TextBox pic1201, TextBox pic1202, TextBox pic1203, TextBox pic1204, TextBox pic1205, TextBox pic1206, TextBox pic1207, TextBox pic1208, TextBox pic1209, TextBox pic1210, TextBox pic1211, TextBox pic1212, TextBox pic1213, TextBox pic1214, TextBox pic1215, TextBox pic1216,
            TextBox pic1301, TextBox pic1302, TextBox pic1303, TextBox pic1304, TextBox pic1305, TextBox pic1306, TextBox pic1307, TextBox pic1308, TextBox pic1309, TextBox pic1310, TextBox pic1311, TextBox pic1312, TextBox pic1313, TextBox pic1314, TextBox pic1315, TextBox pic1316,
            TextBox pic1401, TextBox pic1402, TextBox pic1403, TextBox pic1404, TextBox pic1405, TextBox pic1406, TextBox pic1407, TextBox pic1408, TextBox pic1409, TextBox pic1410, TextBox pic1411, TextBox pic1412, TextBox pic1413, TextBox pic1414, TextBox pic1415, TextBox pic1416,
            TextBox pic1501, TextBox pic1502, TextBox pic1503, TextBox pic1504, TextBox pic1505, TextBox pic1506, TextBox pic1507, TextBox pic1508, TextBox pic1509, TextBox pic1510, TextBox pic1511, TextBox pic1512, TextBox pic1513, TextBox pic1514, TextBox pic1515, TextBox pic1516,
            TextBox pic1601, TextBox pic1602, TextBox pic1603, TextBox pic1604, TextBox pic1605, TextBox pic1606, TextBox pic1607, TextBox pic1608, TextBox pic1609, TextBox pic1610, TextBox pic1611, TextBox pic1612, TextBox pic1613, TextBox pic1614, TextBox pic1615, TextBox pic1616,
            Number[,] num
            )
        {

            TextBox[,] array = new TextBox[16, 16];

            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    array[i, j] = new TextBox();
                }
            }
            array[0, 0] = pic0101; array[0, 1] = pic0102; array[0, 2] = pic0103; array[0, 3] = pic0104; array[0, 4] = pic0105; array[0, 5] = pic0106; array[0, 6] = pic0107; array[0, 7] = pic0108; array[0, 8] = pic0109; array[0, 9] = pic0110; array[0, 10] = pic0111; array[0, 11] = pic0112; array[0, 12] = pic0113; array[0, 13] = pic0114; array[0, 14] = pic0115; array[0, 15] = pic0116;
            array[1, 0] = pic0201; array[1, 1] = pic0202; array[1, 2] = pic0203; array[1, 3] = pic0204; array[1, 4] = pic0205; array[1, 5] = pic0206; array[1, 6] = pic0207; array[1, 7] = pic0208; array[1, 8] = pic0209; array[1, 9] = pic0210; array[1, 10] = pic0211; array[1, 11] = pic0212; array[1, 12] = pic0213; array[1, 13] = pic0214; array[1, 14] = pic0215; array[1, 15] = pic0216;
            array[2, 0] = pic0301; array[2, 1] = pic0302; array[2, 2] = pic0303; array[2, 3] = pic0304; array[2, 4] = pic0305; array[2, 5] = pic0306; array[2, 6] = pic0307; array[2, 7] = pic0308; array[2, 8] = pic0309; array[2, 9] = pic0310; array[2, 10] = pic0311; array[2, 11] = pic0312; array[2, 12] = pic0313; array[2, 13] = pic0314; array[2, 14] = pic0315; array[2, 15] = pic0316;
            array[3, 0] = pic0401; array[3, 1] = pic0402; array[3, 2] = pic0403; array[3, 3] = pic0404; array[3, 4] = pic0405; array[3, 5] = pic0406; array[3, 6] = pic0407; array[3, 7] = pic0408; array[3, 8] = pic0409; array[3, 9] = pic0410; array[3, 10] = pic0411; array[3, 11] = pic0412; array[3, 12] = pic0413; array[3, 13] = pic0414; array[3, 14] = pic0415; array[3, 15] = pic0416;
            array[4, 0] = pic0501; array[4, 1] = pic0502; array[4, 2] = pic0503; array[4, 3] = pic0504; array[4, 4] = pic0505; array[4, 5] = pic0506; array[4, 6] = pic0507; array[4, 7] = pic0508; array[4, 8] = pic0509; array[4, 9] = pic0510; array[4, 10] = pic0511; array[4, 11] = pic0512; array[4, 12] = pic0513; array[4, 13] = pic0514; array[4, 14] = pic0515; array[4, 15] = pic0516;
            array[5, 0] = pic0601; array[5, 1] = pic0602; array[5, 2] = pic0603; array[5, 3] = pic0604; array[5, 4] = pic0605; array[5, 5] = pic0606; array[5, 6] = pic0607; array[5, 7] = pic0608; array[5, 8] = pic0609; array[5, 9] = pic0610; array[5, 10] = pic0611; array[5, 11] = pic0612; array[5, 12] = pic0613; array[5, 13] = pic0614; array[5, 14] = pic0615; array[5, 15] = pic0616;
            array[6, 0] = pic0701; array[6, 1] = pic0702; array[6, 2] = pic0703; array[6, 3] = pic0704; array[6, 4] = pic0705; array[6, 5] = pic0706; array[6, 6] = pic0707; array[6, 7] = pic0708; array[6, 8] = pic0709; array[6, 9] = pic0710; array[6, 10] = pic0711; array[6, 11] = pic0712; array[6, 12] = pic0713; array[6, 13] = pic0714; array[6, 14] = pic0715; array[6, 15] = pic0716;
            array[7, 0] = pic0801; array[7, 1] = pic0802; array[7, 2] = pic0803; array[7, 3] = pic0804; array[7, 4] = pic0805; array[7, 5] = pic0806; array[7, 6] = pic0807; array[7, 7] = pic0808; array[7, 8] = pic0809; array[7, 9] = pic0810; array[7, 10] = pic0811; array[7, 11] = pic0812; array[7, 12] = pic0813; array[7, 13] = pic0814; array[7, 14] = pic0815; array[7, 15] = pic0816;
            array[8, 0] = pic0901; array[8, 1] = pic0902; array[8, 2] = pic0903; array[8, 3] = pic0904; array[8, 4] = pic0905; array[8, 5] = pic0906; array[8, 6] = pic0907; array[8, 7] = pic0908; array[8, 8] = pic0909; array[8, 9] = pic0910; array[8, 10] = pic0911; array[8, 11] = pic0912; array[8, 12] = pic0913; array[8, 13] = pic0914; array[8, 14] = pic0915; array[8, 15] = pic0916;
            array[9, 0] = pic1001; array[9, 1] = pic1002; array[9, 2] = pic1003; array[9, 3] = pic1004; array[9, 4] = pic1005; array[9, 5] = pic1006; array[9, 6] = pic1007; array[9, 7] = pic1008; array[9, 8] = pic1009; array[9, 9] = pic1010; array[9, 10] = pic1011; array[9, 11] = pic1012; array[9, 12] = pic1013; array[9, 13] = pic1014; array[9, 14] = pic1015; array[9, 15] = pic1016;
            array[10, 0] = pic1101; array[10, 1] = pic1102; array[10, 2] = pic1103; array[10, 3] = pic1104; array[10, 4] = pic1105; array[10, 5] = pic1106; array[10, 6] = pic1107; array[10, 7] = pic1108; array[10, 8] = pic1109; array[10, 9] = pic1110; array[10, 10] = pic1111; array[10, 11] = pic1112; array[10, 12] = pic1113; array[10, 13] = pic1114; array[10, 14] = pic1115; array[10, 15] = pic1116;
            array[11, 0] = pic1201; array[11, 1] = pic1202; array[11, 2] = pic1203; array[11, 3] = pic1204; array[11, 4] = pic1205; array[11, 5] = pic1206; array[11, 6] = pic1207; array[11, 7] = pic1208; array[11, 8] = pic1209; array[11, 9] = pic1210; array[11, 10] = pic1211; array[11, 11] = pic1212; array[11, 12] = pic1213; array[11, 13] = pic1214; array[11, 14] = pic1215; array[11, 15] = pic1216;
            array[12, 0] = pic1301; array[12, 1] = pic1302; array[12, 2] = pic1303; array[12, 3] = pic1304; array[12, 4] = pic1305; array[12, 5] = pic1306; array[12, 6] = pic1307; array[12, 7] = pic1308; array[12, 8] = pic1309; array[12, 9] = pic1310; array[12, 10] = pic1311; array[12, 11] = pic1312; array[12, 12] = pic1313; array[12, 13] = pic1314; array[12, 14] = pic1315; array[12, 15] = pic1316;
            array[13, 0] = pic1401; array[13, 1] = pic1402; array[13, 2] = pic1403; array[13, 3] = pic1404; array[13, 4] = pic1405; array[13, 5] = pic1406; array[13, 6] = pic1407; array[13, 7] = pic1408; array[13, 8] = pic1409; array[13, 9] = pic1410; array[13, 10] = pic1411; array[13, 11] = pic1412; array[13, 12] = pic1413; array[13, 13] = pic1414; array[13, 14] = pic1415; array[13, 15] = pic1416;
            array[14, 0] = pic1501; array[14, 1] = pic1502; array[14, 2] = pic1503; array[14, 3] = pic1504; array[14, 4] = pic1505; array[14, 5] = pic1506; array[14, 6] = pic1507; array[14, 7] = pic1508; array[14, 8] = pic1509; array[14, 9] = pic1510; array[14, 10] = pic1511; array[14, 11] = pic1512; array[14, 12] = pic1513; array[14, 13] = pic1514; array[14, 14] = pic1515; array[14, 15] = pic1516;
            array[15, 0] = pic1601; array[15, 1] = pic1602; array[15, 2] = pic1603; array[15, 3] = pic1604; array[15, 4] = pic1605; array[15, 5] = pic1606; array[15, 6] = pic1607; array[15, 7] = pic1608; array[15, 8] = pic1609; array[15, 9] = pic1610; array[15, 10] = pic1611; array[15, 11] = pic1612; array[15, 12] = pic1613; array[15, 13] = pic1614; array[15, 14] = pic1615; array[15, 15] = pic1616;
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    if (array[i, j].Text.Trim() == "")
                    {
                        try { num[i, j].Value = 0; }
                        catch
                        {
                            //MessageBox.Show("Loi la tai" + i + "vs" + j, "How play game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }


                    }
                    else
                    {
                        try
                        {
                            num[i, j].Value = Convert.ToInt32(array[i, j].Text.Trim());
                        }
                        catch
                        {
                            if (num[i, j].Value != -1) MessageBox.Show("Error Row " + (i + 1) + " and Colum " + (j + 1), "Check Maxtrix", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            num[i, j].Value = -1;
                        }
                    }
                }
            }
            return array;

        }
    }
}
