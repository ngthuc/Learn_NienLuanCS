using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuN.Controller
{
    class Class3 : Model
    {
        //**************************************************************************************
        //Hàm kiểm tra tính hợp lệ trong một ô 9x9
        public override bool feasibleBlock(Number[,] Sudoku, int x, int y, int number, int value) { return true; }

        //**************************************************************************************
        // Xử lý cho 81 ô đưa nó vào mảng textbox
        public TextBox[,] clickMove81toArray(
            TextBox pic11, TextBox pic12, TextBox pic13,
            TextBox pic21, TextBox pic22, TextBox pic23,
            TextBox pic31, TextBox pic32, TextBox pic33,
            Number[,] num
            )
        {

            TextBox[,] array = new TextBox[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array[i, j] = new TextBox();
                }
            }
            array[0, 0] = pic11; array[0, 1] = pic12; array[0, 2] = pic13; 
            array[1, 0] = pic21; array[1, 1] = pic22; array[1, 2] = pic23; 
            array[2, 0] = pic31; array[2, 1] = pic32; array[2, 2] = pic33; 
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
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
