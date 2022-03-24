using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using TreeApplication;

namespace Affine_Transformations
{
    [Serializable]
    public class Matrix
    {
        string title; //заголовок (описание) матрицы
        int size; //размер матрицы
        public String[,] values; //значения матрицы

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        public String this[int i, int j]
        {
            get
            {
                return values[i, j];
            }
            set
            {
                values[i, j] = value;
            }
        }

        //возвращает терм элемента (для матопераций)
        public Term term(int i, int j)
        {
            return (Term)this[i, j];
        }

        public Matrix(int size)
        {
            this.size = size;
            this.values = new String[size, size];
        }

        //заполняет матрицу значениями DataTable таблицы
        public void FromDataTable(DataTable TableMatr)
        {
            this.size = TableMatr.Columns.Count;
            this.values = new String[size, size];
            for (int i = 0; i < size; i++)
            {
                DataRow row = TableMatr.Rows[i];
                for (int j = 0; j < size; j++)
                {
                    values[i, j] = (string)row[j.ToString()];
                }
            }
        }

        //возвращает DataTable из текущей матрицы
        public DataTable ConvertToDataTable()
        {
            DataTable TableMatr = new DataTable(); //таблица матрицы

            //задаем столбцы таблицы
            for (int i = 0; i < size; i++)
                TableMatr.Columns.Add(new DataColumn(i.ToString(), typeof(string)));

            //заполняем таблицу
            for (int i = 0; i < size; i++)
            {
                DataRow row = TableMatr.NewRow();
                for (int j = 0; j < size; j++)
                    row[j.ToString()] = values[i, j];
                TableMatr.Rows.Add(row);
            }

            return TableMatr;
        }

        public Matrix Clone()
        {
            Matrix matr = new Matrix(size);
            matr.Title = title;

            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    matr[i, j] = (string)values[i, j].Clone();

            return matr;
        }

        public static Matrix operator *(Matrix m1, Matrix m2)
        {
            Matrix mRes = new Matrix(m1.Size);

            for (int i = 0; i < m1.Size; i++)
                for (int j = 0; j < m1.Size; j++)
                {
                    mRes[i, j] = "";
                    for (int k = 0; k < m1.Size; k++)
                        mRes[i, j] = mRes.term(i, j) | m1.term(i, k) * m2.term(k, j);
                }

            return mRes;
        }

        //определители матрицы 2, 3 и 4 порядков
        public string Determinant()
        {
            string det;


            if (size == 4)
            {
                det = (term(0, 0) * ((term(1, 1) * term(2, 2) * term(3, 3)) | (term(1, 2) * term(2, 3) * term(3, 1)) | (term(2, 1) * term(3, 2) * term(1, 3)) - (term(3, 1) * term(2, 2) * term(1, 3)) - (term(3, 2) * term(2, 3) * term(1, 1)) - (term(1, 2) * term(2, 1) * term(3, 3))))
 - (term(0, 1) * ((term(1, 0) * term(2, 2) * term(3, 3)) | (term(1, 2) * term(2, 3) * term(3, 0)) | (term(2, 0) * term(3, 2) * term(1, 3)) - (term(3, 0) * term(2, 2) * term(1, 3)) - (term(3, 2) * term(2, 3) * term(1, 0)) - (term(2, 0) * term(1, 2) * term(3, 3))))
 | (term(0, 2) * ((term(1, 0) * term(2, 1) * term(3, 3)) | (term(1, 1) * term(2, 3) * term(3, 0)) | (term(2, 0) * term(3, 1) * term(1, 3)) - (term(3, 0) * term(2, 1) * term(1, 3)) - (term(3, 1) * term(2, 3) * term(1, 0)) - (term(2, 0) * term(1, 1) * term(3, 3))))
 - (term(0, 3) * ((term(1, 0) * term(2, 1) * term(3, 2)) | (term(1, 1) * term(2, 2) * term(3, 0)) | (term(2, 0) * term(3, 1) * term(1, 2)) - (term(3, 0) * term(2, 1) * term(1, 2)) - (term(3, 1) * term(2, 2) * term(1, 0)) - (term(2, 0) * term(1, 1) * term(3, 2))));
            }
            else if (size == 3)
            {
                det = term(0, 0) * term(1, 1) * term(2, 2) | term(0, 1) * term(1, 2) * term(2, 0) | term(1, 0) * term(2, 1) * term(0, 2)
                    - term(0, 2) * term(1, 1) * term(2, 0) - term(0, 0) * term(2, 1) * term(1, 2) - term(1, 0) * term(0, 1) * term(2, 2);
            }
            else if (size == 2)
            {
                det = term(0, 0) * term(1, 1) - term(0, 1) * term(1, 0);
            }
            else
            {
                det = "";
            }
            det  = ExpressionString.SimplifyString(det);

            return det;
        }

        public Matrix ReverseMatr()
        {
            Matrix result = new Matrix(size);
            Term determinant = Determinant();

            if (determinant == (Term)"0") return result;

            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                {
                    result[i, j] = AlgAddition(j, i)/determinant;
                    result[i, j] = ExpressionString.SimplifyString(result[i, j]);
                    
                    if ((i + j) % 2 == 1)
                        result[i, j] = "-1"*((Term)result[i, j]);

                    result[i, j] = ExpressionString.SimplifyString(result[i, j]);
                    result[i, j] = result[i, j].Replace("--", "");
                }


            return result;
        }

        //алгебраическое дополнение
        private Term AlgAddition(int ik, int jk)
        {
            Matrix cuttedMatr = new Matrix(size-1);

            for (int i = 0; i < size-1; i++)
                for (int j = 0; j < size-1; j++)
                    cuttedMatr[i, j] = values[i + ((i >= ik) ? 1 : 0), j + ((j >= jk) ? 1 : 0)];

            Term det = cuttedMatr.Determinant();

            return det;
        }

        //умножние на столбец
        public Term[] MultToColumn(Term[] column)
        {
            Term[] result = new Term[Size];

            for (int i = 0; i < Size; i++)
            {
                result[i]="";

                for (int j = 0; j < Size; j++)
                    result[i] = result[i] | term(i, j) * column[j];

                result[i] = ExpressionString.SimplifyString(result[i]);
            }

            

            return result;
        }
    }
}
