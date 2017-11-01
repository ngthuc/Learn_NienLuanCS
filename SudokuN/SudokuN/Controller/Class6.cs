using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuN.Controller
{
    class Class6 : Model
    {
        //**************************************************************************************
        //Hàm kiểm tra tính hợp lệ trong một ô 9x9
        public override bool feasibleBlock(Number[,] Sudoku, int x, int y, int number, int value)
        {
            //Kiểm tra xe có bị trùng với ô nào trong khối của nó không
            int a = x / 2, b = y / 3;
            for (int i = 2 * a; i < 2 * a + 2; i++)
            {
                for (int j = 3 * b; j < 3 * b + 3; j++)
                {
                    if (Sudoku[i, j].Value == value && i != x && j != y) return false;
                }
            }
            return true;

        }

        //**************************************************************************************
        // Xử lý cho 81 ô đưa nó vào mảng textbox
        public TextBox[,] clickMove81toArray(
            TextBox pic11, TextBox pic12, TextBox pic13, TextBox pic14, TextBox pic15, TextBox pic16, 
            TextBox pic21, TextBox pic22, TextBox pic23, TextBox pic24, TextBox pic25, TextBox pic26, 
            TextBox pic31, TextBox pic32, TextBox pic33, TextBox pic34, TextBox pic35, TextBox pic36, 
            TextBox pic41, TextBox pic42, TextBox pic43, TextBox pic44, TextBox pic45, TextBox pic46, 
            TextBox pic51, TextBox pic52, TextBox pic53, TextBox pic54, TextBox pic55, TextBox pic56, 
            TextBox pic61, TextBox pic62, TextBox pic63, TextBox pic64, TextBox pic65, TextBox pic66,
            Number[,] num
            )
        {

            TextBox[,] array = new TextBox[6, 6];

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    array[i, j] = new TextBox();
                }
            }
            array[0, 0] = pic11; array[0, 1] = pic12; array[0, 2] = pic13; array[0, 3] = pic14; array[0, 4] = pic15; array[0, 5] = pic16;
            array[1, 0] = pic21; array[1, 1] = pic22; array[1, 2] = pic23; array[1, 3] = pic24; array[1, 4] = pic25; array[1, 5] = pic26;
            array[2, 0] = pic31; array[2, 1] = pic32; array[2, 2] = pic33; array[2, 3] = pic34; array[2, 4] = pic35; array[2, 5] = pic36;
            array[3, 0] = pic41; array[3, 1] = pic42; array[3, 2] = pic43; array[3, 3] = pic44; array[3, 4] = pic45; array[3, 5] = pic46;
            array[4, 0] = pic51; array[4, 1] = pic52; array[4, 2] = pic53; array[4, 3] = pic54; array[4, 4] = pic55; array[4, 5] = pic56;
            array[5, 0] = pic61; array[5, 1] = pic62; array[5, 2] = pic63; array[5, 3] = pic64; array[5, 4] = pic65; array[5, 5] = pic66;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
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
