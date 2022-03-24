using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Affine_Transformations
{
    public partial class FormOperations : Form
    {
        Matrix matr;//матрица с которой работаем

        public FormOperations(Matrix matr)
        {
            this.matr = matr;
            InitializeComponent();
        }

        private void ShowDeterminant()
        {
            textBoxDet.Text = matr.Determinant();
        }


        //заполняет GUI столбец значениями
        private void FillColumn(Term[] colValues, DataGridView col)
        {
            DataTable TableColumn = new DataTable();

            TableColumn.Columns.Add("0", typeof(string));

            //заполняем таблицу
            for (int i = 0; i < matr.Size; i++)
            {
                DataRow row = TableColumn.NewRow();
                row["0"] = colValues[i];
                TableColumn.Rows.Add(row);
            }

            col.DataSource = TableColumn;
        }

        //считывает значения из GUI столбца
        private Term[] ReadColumn(DataGridView col)
        {
            Term[] result = new Term[matr.Size];

            for (int i = 0; i < matr.Size; i++)
            {
                DataRow row = ((DataTable)col.DataSource).Rows[i];
                result[i] = (String) row["0"];
            }

            return result;
        }

        //кнопка умножения на столбец
        private void buttonColumnMult_Click(object sender, EventArgs e)
        {
            var column = ReadColumn(dataGridViewColumn);
            var columnRes = matr.MultToColumn(column);
            FillColumn(columnRes, dataGridViewColumnRes);
        }

        private void reverseMatr()
        {
            Matrix revMatr = matr.ReverseMatr();
            dataGridViewReverse.DataSource = revMatr.ConvertToDataTable();
        }


        private void FormOperations_Load(object sender, EventArgs e)
        {
            ShowDeterminant();
            FillColumn(new Term[] { "1", "1", "1", "1" }, dataGridViewColumn);
            reverseMatr();
        }

        private void buttonSaveToSandbox_Click(object sender, EventArgs e)
        {
            Matrix resMatr = new Matrix(matr.Size);
            resMatr.Title = "Обратная матрица";
            resMatr.FromDataTable((DataTable)dataGridViewReverse.DataSource);
            FormMain.sandbox.AddMatrix(resMatr);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
