using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuN.Controller
{
    class Class9 : Model
    {
        //**************************************************************************************
        //Hàm kiểm tra tính hợp lệ trong một ô 9x9
        public override bool feasibleBlock(Number[,] Sudoku, int x, int y,int number, int value)
        {
            //Kiểm tra xe có bị trùng với ô nào trong khối của nó không
            int a = x / 3, b = y / 3;
            for (int i = 3 * a; i < 3 * a + 3; i++)
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
            TextBox pic11, TextBox pic12, TextBox pic13, TextBox pic14, TextBox pic15, TextBox pic16, TextBox pic17, TextBox pic18, TextBox pic19,
            TextBox pic21, TextBox pic22, TextBox pic23, TextBox pic24, TextBox pic25, TextBox pic26, TextBox pic27, TextBox pic28, TextBox pic29,
            TextBox pic31, TextBox pic32, TextBox pic33, TextBox pic34, TextBox pic35, TextBox pic36, TextBox pic37, TextBox pic38, TextBox pic39,
            TextBox pic41, TextBox pic42, TextBox pic43, TextBox pic44, TextBox pic45, TextBox pic46, TextBox pic47, TextBox pic48, TextBox pic49,
            TextBox pic51, TextBox pic52, TextBox pic53, TextBox pic54, TextBox pic55, TextBox pic56, TextBox pic57, TextBox pic58, TextBox pic59,
            TextBox pic61, TextBox pic62, TextBox pic63, TextBox pic64, TextBox pic65, TextBox pic66, TextBox pic67, TextBox pic68, TextBox pic69,
            TextBox pic71, TextBox pic72, TextBox pic73, TextBox pic74, TextBox pic75, TextBox pic76, TextBox pic77, TextBox pic78, TextBox pic79,
            TextBox pic81, TextBox pic82, TextBox pic83, TextBox pic84, TextBox pic85, TextBox pic86, TextBox pic87, TextBox pic88, TextBox pic89,
            TextBox pic91, TextBox pic92, TextBox pic93, TextBox pic94, TextBox pic95, TextBox pic96, TextBox pic97, TextBox pic98, TextBox pic99,
            Number[,] num
            )
        {

            TextBox[,] array = new TextBox[9, 9];

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    array[i, j] = new TextBox();
                }
            }
            array[0, 0] = pic11; array[0, 1] = pic12; array[0, 2] = pic13; array[0, 3] = pic14; array[0, 4] = pic15; array[0, 5] = pic16; array[0, 6] = pic17; array[0, 7] = pic18; array[0, 8] = pic19;
            array[1, 0] = pic21; array[1, 1] = pic22; array[1, 2] = pic23; array[1, 3] = pic24; array[1, 4] = pic25; array[1, 5] = pic26; array[1, 6] = pic27; array[1, 7] = pic28; array[1, 8] = pic29;
            array[2, 0] = pic31; array[2, 1] = pic32; array[2, 2] = pic33; array[2, 3] = pic34; array[2, 4] = pic35; array[2, 5] = pic36; array[2, 6] = pic37; array[2, 7] = pic38; array[2, 8] = pic39;
            array[3, 0] = pic41; array[3, 1] = pic42; array[3, 2] = pic43; array[3, 3] = pic44; array[3, 4] = pic45; array[3, 5] = pic46; array[3, 6] = pic47; array[3, 7] = pic48; array[3, 8] = pic49;
            array[4, 0] = pic51; array[4, 1] = pic52; array[4, 2] = pic53; array[4, 3] = pic54; array[4, 4] = pic55; array[4, 5] = pic56; array[4, 6] = pic57; array[4, 7] = pic58; array[4, 8] = pic59;
            array[5, 0] = pic61; array[5, 1] = pic62; array[5, 2] = pic63; array[5, 3] = pic64; array[5, 4] = pic65; array[5, 5] = pic66; array[5, 6] = pic67; array[5, 7] = pic68; array[5, 8] = pic69;
            array[6, 0] = pic71; array[6, 1] = pic72; array[6, 2] = pic73; array[6, 3] = pic74; array[6, 4] = pic75; array[6, 5] = pic76; array[6, 6] = pic77; array[6, 7] = pic78; array[6, 8] = pic79;
            array[7, 0] = pic81; array[7, 1] = pic82; array[7, 2] = pic83; array[7, 3] = pic84; array[7, 4] = pic85; array[7, 5] = pic86; array[7, 6] = pic87; array[7, 7] = pic88; array[7, 8] = pic89;
            array[8, 0] = pic91; array[8, 1] = pic92; array[8, 2] = pic93; array[8, 3] = pic94; array[8, 4] = pic95; array[8, 5] = pic96; array[8, 6] = pic97; array[8, 7] = pic98; array[8, 8] = pic99;

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
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
                            MessageBox.Show("Error Row "+(i+1)+" and Colum "+(j+1), "Check Maxtrix", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            return array;

        }


    }
}
