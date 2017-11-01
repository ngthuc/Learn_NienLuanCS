using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuN.Controller
{
    class Number
    {
        private int row; //hàng của ô
        private int column; //cột của ô
        private int status;
        /*** trạng thái ô
         * -1 là trạng thái mới khởi tạo
         * 0 là trạng thái mặc định bị che đi, click vào để chỉnh sửa số cho nó
         * 1 là trạng thái ô cho sẵn không thể sửa
         * 2 là ô đã điền rồi, nhưng có thể chỉnh sửa lại
         */
        private int value; // Chứa giá trị cho một ô

        public int Row
        {
            get
            {
                return row;
            }

            set
            {
                row = value;
            }
        }

        public int Column
        {
            get
            {
                return column;
            }

            set
            {
                column = value;
            }
        }
        public int Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
            }
        }

        public int Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }
    }
}
