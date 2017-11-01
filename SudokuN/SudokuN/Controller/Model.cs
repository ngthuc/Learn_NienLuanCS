using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuN.Controller
{
   class Model
    {
        //**************************************************************************************
        //Tạo ra một giá trị cho một block
        public Number newBlockValue(int row, int colum, int status, int value)
        {
            Number num = new Number();
            num.Row = row;
            num.Column = colum;
            num.Status = status;
            num.Value = value;
            return num;
        }

        //**************************************************************************************
        //Hàm tạo ma trận rỗng x*y
        public Number[,] newMatrix(int number)
        {
            Number[,] num = new Number[number, number];


            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    //Tạo ô i cột j với ô này false (bị khóa lại) và giá trị ban đầu bị trống
                    num[i, j] = this.newBlockValue(i, j, 0, 0);
                }

            }
            return num;
        }

        //**************************************************************************************
        //Hàm kiểm tra tính hợp lệ của một số theo chiều ngang
        public bool feasibleRow(Number[,] Sudoku, int number,int x,int y,  int value)
        {
            int i = 0;
            //Kiểm tra tính hợp lệ trên hàng x xem có ô nào trùng nào không, trùng báo sai
            for (i = 0; i < number; i++)
            {
                if (Sudoku[x, i].Value == value && i!=y) return false;
            }
            return true;
        }

        //**************************************************************************************
        //Hàm kiểm tra tính hợp lệ của một số theo chiều dọc
        public bool feasibleColum(Number[,] Sudoku, int number,  int x, int y,int value)
        {
            int i = 0;
            //Kiểm tra tính hợp lệ trên hàng y xem có ô nào trùng nào không, trùng báo sai
            for (i = 0; i < number; i++)
            {
                if (Sudoku[i,y].Value == value && i!=x) return false;
            }
            return true;
        }

        //**************************************************************************************
        //Hàm kiểm tra tính hợp lệ trong một ô 9x9
        public virtual bool feasibleBlock(Number[,] Sudoku, int x, int y, int number, int value) { return true; }

        //**************************************************************************************
        //Hàm trộn chuỗi để tự động giải sudoku một cách ngẫu nhiên
        public int[] autoConvertArray(int number)
        {
            int[] arrayNum = new int[number];

            //Nạp các giá trị có thể vào một mảng
            for (int a = 0; a < number; a++)
            {
                arrayNum[a] = a + 1;
            }

            //Tạo ra giá trị tự động tên ran
            Random ran = new Random();
            int x, y, temp;
            //Trộn 50 lần
            for (int i = 1; i < 50; i++)
            {
                x = ran.Next(0, number - 1);
                y = ran.Next(0, number - 1);
                temp = arrayNum[x];
                arrayNum[x] = arrayNum[y];
                arrayNum[y] = temp;
            }
            return arrayNum;

        }
        //**************************************************************************************
        public bool feasibleAll(Number[,] Sudoku, int number, int x, int y, int value)
        {
            //Kiểm tra tính hợp lệ trên hàng x xem có ô nào trùng không, trùng thì báo sai
            if (!feasibleRow(Sudoku, number, x,y ,value)) return false;
            //Kiểm tra tính hợp lệ trên hàng y xem có ô nào trùng không, trùng thì báo sai
            else if (!feasibleColum(Sudoku, number, x,y, value)) return false;
            //Kiểm tra xe có bị trùng với ô nào trong khối của nó không
            else if (!feasibleBlock(Sudoku, x, y, number, value)) return false;
            //Qua các trường hợp trên là hợp lệ
            return true;
        }

        //**************************************************************************************
        //Hàm kiểm tra tính khả thi của ma trận khi đem nó đi giải
        public bool checkFeasible(Number[,] Sudoku, int number)
        {
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    if (!feasibleAll(Sudoku, number,i,j, Sudoku[i, j].Value) && Sudoku[i, j].Value != 0 ) return false;
                    if (Convert.ToInt32(Sudoku[i, j].Value) < 0 || Convert.ToInt32(Sudoku[i, j].Value) > number) return false;
                }

            }
            this.solveSudoku(Sudoku, 0, 0, number);
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    if (Sudoku[i, j].Value == 0) return false;
                }

            }
            return true;
        }

        //**************************************************************************************
        //???????????????????????????????????Hàm tự động sinh một ma trận
        public Number[,] randomNumber(int number, int numberAuto)
        {
            // Chọn 1 con số ngẫu nhiên và cho nó vào một ô ngẫu nhiên ta được một ma trận chưa đầy đủ,
            // Sau đó tiến hành giải nó , ta được một ma trận hoàn chỉnh

            Random ran = new Random();
            int count = ran.Next(1, numberAuto);// Chọn ngẫu nhiên một số lượng sẽ sinh 

            Number[,] Sudoku = new Number[number, number];

            //Lần lượt đưa các giá trị vào

            //Tạo một bảng trống và đưa giá trị vào giải
            int value = ran.Next(1, number); // Chọn một giá trị ngẫu nhiên;
            int row = ran.Next(0, number - 1); // Chọn hàng ngẫu nhiên
            int colum = ran.Next(0, number - 1); //Chọn cột ngẫu nhiên
            int i;
            do
            {
                Sudoku = this.newMatrix(number);
                i = 0;
                while (i < count)
                {
                    while (Sudoku[row, colum].Value == 0)
                    {
                        Sudoku[row, colum].Value = value;
                        //Tạo một bảng trống và đưa giá trị vào giải
                        i++;
                    }
                    value = ran.Next(1, number); // Chọn một giá trị
                    row = ran.Next(0, number - 1); // Chọn hàng
                    colum = ran.Next(0, number - 1); //Chọn cột

                }
                solveSudoku(Sudoku, 0, 0, number);
            } while (checkFeasible(Sudoku, number) == false);
            return Sudoku;
        }

        //**************************************************************************************
        //Hàm kiểm tra xem ma trận đã chạy hết chưa, (kiểm tra xem còn giá trị 0 nào không)
        public bool CheckEmpty(Number[,] Sudoku, int number)
        {
            for (int i = 0; i < number; i++)
                for (int j = 0; j < number; j++)
                    if (Sudoku[i, j].Value == 0)
                        return true;
            return false;
        }

        //**************************************************************************************
        //Hàm tự động chọn số vị trí random để bật cho người dùng chơi
        //number -> số cạnh ma trận, numBerBlock -> số ô muốn hiển thị
        public Number[,] randomBlockView(Number[,] Sudoku, int numBerBlock, int number)
        {
            int i = 0;
            while (i < numBerBlock)
            {
                Random r1 = new Random();
                Random r2 = new Random();

                //Chọn cột
                int row = r1.Next(0, number - 1);

                //Chọn hàng
                int colum = r2.Next(0, number - 1);
                bool checkValue = true;

                //Kiểm tra xem ô chọn có bị trùng hay không
                if (Sudoku[row, colum].Status == 1)
                {
                    checkValue = false;
                    break;
                }

                //Nếu không trùng thì bật nó lên
                if (checkValue == true)
                {
                    Sudoku[row, colum].Status = 1;
                    i++;
                }

            }
            return Sudoku;
        }

        //**************************************************************************************
        //Hàm giải Sudoku
        public void solveSudoku(Number[,] Sudoku, int x, int y, int number)
        {
            if (y == number)
            {
                if (x == number - 1)
                {
                    return;
                }
                else
                {
                    solveSudoku(Sudoku, x + 1, 0, number);
                }
            }
            else if (Sudoku[x, y].Value == 0)
            {
                //Hàm tự sinh thứ tự đảo lộn các số từ 1 tới 9
                int[] arrayAuto = new int[number];
                arrayAuto = this.autoConvertArray(number);
                for (int k = 1; k <= number; k++)
                {
                    if (feasibleAll(Sudoku, number,x, y,arrayAuto[k - 1]) == true)
                    {
                        Sudoku[x, y].Value = arrayAuto[k - 1];
                     // MessageBox.Show("Loi la tai" + x + "vs" + y+"value = "+ Sudoku[x, y].Value, "How play game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        solveSudoku(Sudoku, x, y + 1, number);
                        if (CheckEmpty(Sudoku, number) == false) return;
                        Sudoku[x, y].Value = 0;
                    }
                }
            }
            else
            {
                solveSudoku(Sudoku, x, y + 1, number);
            }
        }
    }
}
