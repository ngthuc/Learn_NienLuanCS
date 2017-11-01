using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuN.Controller
{
    class Class7 : Model
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
                        if (group[j].Value == value && group[j].Row != x && group[j].Column != y) return false;
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
            Number[] group1 = { nb[0, 0], nb[0, 1], nb[0, 2], nb[1, 0], nb[1, 1], nb[1, 2], nb[2, 2] };
            Number[] group2 = { nb[0, 3], nb[0, 4], nb[0, 5], nb[0, 5], nb[1, 4], nb[1, 5], nb[1, 6] };
            Number[] group3 = { nb[2, 0], nb[2, 1], nb[3, 0], nb[3, 1], nb[4, 0], nb[4, 1], nb[5, 0] };
            Number[] group4 = { nb[2, 3], nb[2, 4], nb[3, 2], nb[3, 3], nb[3, 4], nb[4, 2], nb[4, 3] };
            Number[] group5 = { nb[1, 7], nb[2, 5], nb[2, 6], nb[3, 5], nb[3, 6], nb[4, 5], nb[4, 6] };
            Number[] group6 = { nb[5, 1], nb[5, 2], nb[5, 3], nb[6, 0], nb[6, 1], nb[6, 2], nb[6, 3] };
            Number[] group7 = { nb[4, 4], nb[5, 4], nb[5, 5], nb[5, 6], nb[6, 4], nb[6, 5], nb[6, 6] };
            if (findGroup(group1, x, y, number, value))
                if (findGroup(group2, x, y, number, value))
                    if (findGroup(group3, x, y, number, value))
                        if (findGroup(group4, x, y, number, value))
                            if (findGroup(group5, x, y, number, value))
                                if (findGroup(group6, x, y, number, value))
                                    if (findGroup(group7, x, y, number, value)) return true;

            return false;
        }

        //**************************************************************************************
        // Xử lý cho 81 ô đưa nó vào mảng textbox
        public TextBox[,] clickMove81toArray(
            TextBox pic11, TextBox pic12, TextBox pic13, TextBox pic14, TextBox pic15, TextBox pic16, TextBox pic17,
            TextBox pic21, TextBox pic22, TextBox pic23, TextBox pic24, TextBox pic25, TextBox pic26, TextBox pic27,
            TextBox pic31, TextBox pic32, TextBox pic33, TextBox pic34, TextBox pic35, TextBox pic36, TextBox pic37,
            TextBox pic41, TextBox pic42, TextBox pic43, TextBox pic44, TextBox pic45, TextBox pic46, TextBox pic47,
            TextBox pic51, TextBox pic52, TextBox pic53, TextBox pic54, TextBox pic55, TextBox pic56, TextBox pic57,
            TextBox pic61, TextBox pic62, TextBox pic63, TextBox pic64, TextBox pic65, TextBox pic66, TextBox pic67,
            TextBox pic71, TextBox pic72, TextBox pic73, TextBox pic74, TextBox pic75, TextBox pic76, TextBox pic77,
            Number[,] num
            )
        {

            TextBox[,] array = new TextBox[7, 7];

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    array[i, j] = new TextBox();
                }
            }
            array[0, 0] = pic11; array[0, 1] = pic12; array[0, 2] = pic13; array[0, 3] = pic14; array[0, 4] = pic15; array[0, 5] = pic16; array[0, 6] = pic17;
            array[1, 0] = pic21; array[1, 1] = pic22; array[1, 2] = pic23; array[1, 3] = pic24; array[1, 4] = pic25; array[1, 5] = pic26; array[1, 6] = pic27;
            array[2, 0] = pic31; array[2, 1] = pic32; array[2, 2] = pic33; array[2, 3] = pic34; array[2, 4] = pic35; array[2, 5] = pic36; array[2, 6] = pic37;
            array[3, 0] = pic41; array[3, 1] = pic42; array[3, 2] = pic43; array[3, 3] = pic44; array[3, 4] = pic45; array[3, 5] = pic46; array[3, 6] = pic47;
            array[4, 0] = pic51; array[4, 1] = pic52; array[4, 2] = pic53; array[4, 3] = pic54; array[4, 4] = pic55; array[4, 5] = pic56; array[4, 6] = pic57;
            array[5, 0] = pic61; array[5, 1] = pic62; array[5, 2] = pic63; array[5, 3] = pic64; array[5, 4] = pic65; array[5, 5] = pic66; array[5, 6] = pic67;
            array[6, 0] = pic71; array[6, 1] = pic72; array[6, 2] = pic73; array[6, 3] = pic74; array[6, 4] = pic75; array[6, 5] = pic76; array[6, 6] = pic77;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (array[i, j].Text.Trim() == "")
                    {
                        num[i, j].Value = 0;
                    }
                    else
                    {
                        try
                        {
                            num[i, j].Value = Convert.ToInt32(array[i, j].Text.Trim());
                        }
                        catch
                        {
                            num[i, j].Value = -1;
                            MessageBox.Show("Error Row " + (i + 1) + " and Colum " + (j + 1), "Check Maxtrix", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            return array;

        }
    }
}
