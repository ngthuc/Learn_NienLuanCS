using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuN.Controller
{
    class Class11a : Model
    {
        //Tìm kiếm trong một group xem một ô thuộc group nào
        public bool findGroup(Number[] group, int x, int y, int number, int value)
        {
            for (int i = 0; i < number; i++)
            {
                if (x == group[i].Row && y == group[i].Column)
                {
                    for (int j = 0; j < number; j++)
                    {
                        if (group[j].Value == value) return false;
                    }
                }
            }
            return true;
        }

        //**************************************************************************************
        //Hàm kiểm tra tính hợp lệ trong một ô 9x9
        public override bool feasibleBlock(Number[,] nb, int x, int y, int number, int value)
        {
            //Xác định các tập hợp
            Number[] group1 = { nb[0, 0], nb[0, 1], nb[0, 2], nb[0, 3], nb[1, 0], nb[1, 1], nb[1, 2], nb[1, 3], nb[2, 1], nb[2, 2], nb[2, 3] };
            Number[] group2 = { nb[0, 4], nb[0, 5], nb[0, 6], nb[1, 4], nb[1, 5], nb[1, 6], nb[2, 4], nb[2, 5], nb[2, 6], nb[3, 5], nb[3, 6] };
            Number[] group3 = { nb[0, 7], nb[0, 8], nb[0, 9], nb[0, 10], nb[1, 7], nb[1, 8], nb[1, 9], nb[1, 10], nb[2, 8], nb[2, 9], nb[2, 10] };
            Number[] group4 = { nb[2, 0], nb[3, 0], nb[3, 1], nb[3, 2], nb[3, 3], nb[4, 0], nb[4, 1], nb[4, 2], nb[4, 3], nb[5, 2], nb[5, 3] };
            Number[] group5 = { nb[3, 4], nb[4, 4], nb[4, 5], nb[4, 4], nb[5, 4], nb[5, 5], nb[5, 6], nb[6, 4], nb[6, 5], nb[6, 6], nb[7, 6] };
            Number[] group6 = { nb[2, 7], nb[3, 7], nb[3, 8], nb[3, 9], nb[3, 10], nb[4, 7], nb[4, 8], nb[4, 9], nb[4, 10], nb[5, 9], nb[5, 10] };
            Number[] group7 = { nb[6, 0], nb[6, 1], nb[7, 0], nb[7, 1], nb[7, 2], nb[7, 3], nb[8, 0], nb[8, 1], nb[8, 2], nb[8, 3], nb[9, 3] };
            Number[] group8 = { nb[8, 0], nb[8, 1], nb[8, 2], nb[9, 0], nb[9, 1], nb[9, 2], nb[9, 3], nb[10, 0], nb[10, 1], nb[10, 2], nb[10, 3] };
            Number[] group9 = { nb[6, 4], nb[6, 5], nb[7, 4], nb[7, 5], nb[7, 6], nb[8, 4], nb[8, 5], nb[8, 6], nb[9, 4], nb[9, 5], nb[9, 6] };
            Number[] group10 = { nb[6, 7], nb[6, 8], nb[7, 7], nb[7, 8], nb[7, 9], nb[7, 10], nb[8, 7], nb[8, 8], nb[8, 9], nb[8, 10], nb[9, 10] };
            Number[] group11 = { nb[8, 7], nb[8, 8], nb[8, 9], nb[9, 7], nb[9, 8], nb[9, 9], nb[9, 10], nb[10, 7], nb[10, 8], nb[10, 9], nb[10, 10] };
            if (findGroup(group1, x, y, number, value))
                if (findGroup(group2, x, y, number, value))
                    if (findGroup(group3, x, y, number, value))
                        if (findGroup(group4, x, y, number, value))
                            if (findGroup(group5, x, y, number, value))
                                if (findGroup(group6, x, y, number, value))
                                    if (findGroup(group7, x, y, number, value))
                                        if (findGroup(group8, x, y, number, value))
                                            if (findGroup(group9, x, y, number, value))
                                                if (findGroup(group10, x, y, number, value))
                                                    if (findGroup(group11, x, y, number, value)) return true;

            return false;
        }


        //**************************************************************************************
        // Xử lý cho 100 ô đưa nó vào mảng textbox
        public TextBox[,] clickMove81toArray(
            TextBox pic0101, TextBox pic0102, TextBox pic0103, TextBox pic0104, TextBox pic0105, TextBox pic0106, TextBox pic0107, TextBox pic0108, TextBox pic0109, TextBox pic0110, TextBox pic0111,
            TextBox pic0201, TextBox pic0202, TextBox pic0203, TextBox pic0204, TextBox pic0205, TextBox pic0206, TextBox pic0207, TextBox pic0208, TextBox pic0209, TextBox pic0210, TextBox pic0211,
            TextBox pic0301, TextBox pic0302, TextBox pic0303, TextBox pic0304, TextBox pic0305, TextBox pic0306, TextBox pic0307, TextBox pic0308, TextBox pic0309, TextBox pic0310, TextBox pic0311,
            TextBox pic0401, TextBox pic0402, TextBox pic0403, TextBox pic0404, TextBox pic0405, TextBox pic0406, TextBox pic0407, TextBox pic0408, TextBox pic0409, TextBox pic0410, TextBox pic0411,
            TextBox pic0501, TextBox pic0502, TextBox pic0503, TextBox pic0504, TextBox pic0505, TextBox pic0506, TextBox pic0507, TextBox pic0508, TextBox pic0509, TextBox pic0510, TextBox pic0511,
            TextBox pic0601, TextBox pic0602, TextBox pic0603, TextBox pic0604, TextBox pic0605, TextBox pic0606, TextBox pic0607, TextBox pic0608, TextBox pic0609, TextBox pic0610, TextBox pic0611,
            TextBox pic0701, TextBox pic0702, TextBox pic0703, TextBox pic0704, TextBox pic0705, TextBox pic0706, TextBox pic0707, TextBox pic0708, TextBox pic0709, TextBox pic0710, TextBox pic0711,
            TextBox pic0801, TextBox pic0802, TextBox pic0803, TextBox pic0804, TextBox pic0805, TextBox pic0806, TextBox pic0807, TextBox pic0808, TextBox pic0809, TextBox pic0810, TextBox pic0811,
            TextBox pic0901, TextBox pic0902, TextBox pic0903, TextBox pic0904, TextBox pic0905, TextBox pic0906, TextBox pic0907, TextBox pic0908, TextBox pic0909, TextBox pic0910, TextBox pic0911,
            TextBox pic1001, TextBox pic1002, TextBox pic1003, TextBox pic1004, TextBox pic1005, TextBox pic1006, TextBox pic1007, TextBox pic1008, TextBox pic1009, TextBox pic1010, TextBox pic1011,
            TextBox pic1101, TextBox pic1102, TextBox pic1103, TextBox pic1104, TextBox pic1105, TextBox pic1106, TextBox pic1107, TextBox pic1108, TextBox pic1109, TextBox pic1110, TextBox pic1111,
            Number[,] num
            )
        {

            TextBox[,] array = new TextBox[11, 11];

            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    array[i, j] = new TextBox();
                }
            }
            array[0, 0] = pic0101; array[0, 1] = pic0102; array[0, 2] = pic0103; array[0, 3] = pic0104; array[0, 4] = pic0105; array[0, 5] = pic0106; array[0, 6] = pic0107; array[0, 7] = pic0108; array[0, 8] = pic0109; array[0, 9] = pic0110; array[0, 10] = pic0111;
            array[1, 0] = pic0201; array[1, 1] = pic0202; array[1, 2] = pic0203; array[1, 3] = pic0204; array[1, 4] = pic0205; array[1, 5] = pic0206; array[1, 6] = pic0207; array[1, 7] = pic0208; array[1, 8] = pic0209; array[1, 9] = pic0210; array[1, 10] = pic0211;
            array[2, 0] = pic0301; array[2, 1] = pic0302; array[2, 2] = pic0303; array[2, 3] = pic0304; array[2, 4] = pic0305; array[2, 5] = pic0306; array[2, 6] = pic0307; array[2, 7] = pic0308; array[2, 8] = pic0309; array[2, 9] = pic0310; array[2, 10] = pic0311;
            array[3, 0] = pic0401; array[3, 1] = pic0402; array[3, 2] = pic0403; array[3, 3] = pic0404; array[3, 4] = pic0405; array[3, 5] = pic0406; array[3, 6] = pic0407; array[3, 7] = pic0408; array[3, 8] = pic0409; array[3, 9] = pic0410; array[3, 10] = pic0411;
            array[4, 0] = pic0501; array[4, 1] = pic0502; array[4, 2] = pic0503; array[4, 3] = pic0504; array[4, 4] = pic0505; array[4, 5] = pic0506; array[4, 6] = pic0507; array[4, 7] = pic0508; array[4, 8] = pic0509; array[4, 9] = pic0510; array[4, 10] = pic0511;
            array[5, 0] = pic0601; array[5, 1] = pic0602; array[5, 2] = pic0603; array[5, 3] = pic0604; array[5, 4] = pic0605; array[5, 5] = pic0606; array[5, 6] = pic0607; array[5, 7] = pic0608; array[5, 8] = pic0609; array[5, 9] = pic0610; array[5, 10] = pic0611;
            array[6, 0] = pic0701; array[6, 1] = pic0702; array[6, 2] = pic0703; array[6, 3] = pic0704; array[6, 4] = pic0705; array[6, 5] = pic0706; array[6, 6] = pic0707; array[6, 7] = pic0708; array[6, 8] = pic0709; array[6, 9] = pic0710; array[6, 10] = pic0711;
            array[7, 0] = pic0801; array[7, 1] = pic0802; array[7, 2] = pic0803; array[7, 3] = pic0804; array[7, 4] = pic0805; array[7, 5] = pic0806; array[7, 6] = pic0807; array[7, 7] = pic0808; array[7, 8] = pic0809; array[7, 9] = pic0810; array[7, 10] = pic0811;
            array[8, 0] = pic0901; array[8, 1] = pic0902; array[8, 2] = pic0903; array[8, 3] = pic0904; array[8, 4] = pic0905; array[8, 5] = pic0906; array[8, 6] = pic0907; array[8, 7] = pic0908; array[8, 8] = pic0909; array[8, 9] = pic0910; array[8, 10] = pic0911;
            array[9, 0] = pic1001; array[9, 1] = pic1002; array[9, 2] = pic1003; array[9, 3] = pic1004; array[9, 4] = pic1005; array[9, 5] = pic1006; array[9, 6] = pic1007; array[9, 7] = pic1008; array[9, 8] = pic1009; array[9, 9] = pic1010; array[9, 10] = pic1011;
            array[10, 0] = pic1101; array[10, 1] = pic1102; array[10, 2] = pic1103; array[10, 3] = pic1104; array[10, 4] = pic1105; array[10, 5] = pic1106; array[10, 6] = pic1107; array[10, 7] = pic1108; array[10, 8] = pic1109; array[10, 9] = pic1110; array[10, 10] = pic1111;


            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    if (array[i, j].Text.Trim() == "")
                    {
                        try { num[i, j].Value = 0; }
                        catch
                        {
                            MessageBox.Show("Loi la tai" + i + "vs" + j, "How play game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }


                    }
                    else
                    {
                        num[i, j].Value = Convert.ToInt32(array[i, j].Text.Trim());
                    }
                }
            }
            return array;

        }
    }
}
