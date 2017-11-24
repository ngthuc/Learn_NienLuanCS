using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SudokuN.Controller;
using System.Windows.Forms;

namespace SudokuN.Controller
{
    class Class4 : Model
    {
        //**************************************************************************************
        //Hàm kiểm tra tính hợp lệ trong một ô 9x9
        public override bool feasibleBlock(Number[,] Sudoku, int x, int y, int number, int value)
        {
            //Kiểm tra xe có bị trùng với ô nào trong khối của nó không
            int a = x / 2, b = y / 2;
            for (int i = 2 * a; i < 2 * a + 2; i++)
            {
                for (int j = 2 * b; j < 2 * b + 2; j++)
                {
                    if (Sudoku[i, j].Value == value && i != x && j != y) return false;
                }
            }
            return true;

        }

        //**************************************************************************************
        // Xử lý cho 81 ô đưa nó vào mảng textbox
        public TextBox[,] clickMove81toArray(
            TextBox pic11, TextBox pic12, TextBox pic13, TextBox pic14,
            TextBox pic21, TextBox pic22, TextBox pic23, TextBox pic24,
            TextBox pic31, TextBox pic32, TextBox pic33, TextBox pic34,
            TextBox pic41, TextBox pic42, TextBox pic43, TextBox pic44,
            Number[,] num
            )
        {

            TextBox[,] array = new TextBox[4, 4];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    array[i, j] = new TextBox();
                }
            }
            array[0, 0] = pic11; array[0, 1] = pic12; array[0, 2] = pic13; array[0, 3] = pic14; 
            array[1, 0] = pic21; array[1, 1] = pic22; array[1, 2] = pic23; array[1, 3] = pic24; 
            array[2, 0] = pic31; array[2, 1] = pic32; array[2, 2] = pic33; array[2, 3] = pic34; 
            array[3, 0] = pic41; array[3, 1] = pic42; array[3, 2] = pic43; array[3, 3] = pic44;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
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
