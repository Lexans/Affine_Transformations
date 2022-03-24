using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TreeApplication;

namespace Affine_Transformations
{
    public partial class FormMultiplication : Form
    {
        Matrix resMatr; //матрица-результат

        bool isDirect;

        public FormMultiplication(bool isDirect)
        {
            InitializeComponent();

            this.Text += " (" + ((isDirect) ? "прямой порядок" : "обратный порядок") + ")";
            this.isDirect = isDirect;
        }


        //метод перемножения
        private void Multiplication(bool isDirect)//isDirect: прямое перемножение? иначе обратное
        {
            //проверка - все матрицы одной размерности?
            MatrixCollection matrixesEnv = FormMain.workenv.Matrixes;
            bool isEqDim = true; //все матрицы одной размерности?
            int dim = matrixesEnv.matrixesOrd[0].Size;
            for (int i = 1; i < matrixesEnv.Count; i++)
                if (matrixesEnv.matrixesOrd[i].Size != dim)
                {
                    isEqDim = false;
                    break;
                }

            if (!isEqDim)
            {
                MessageBox.Show("Ошибка. Матрицы имеют разные размерности");
                this.DialogResult = DialogResult.Abort;
            }


            if (isDirect) //в прямом порядке
            {
                resMatr = matrixesEnv.matrixesOrd[0];
                for (int i = 1; i < matrixesEnv.Count; i++)
                    resMatr = resMatr * matrixesEnv.matrixesOrd[i];
            }
            else //перемножение в обратном порядке
            {
                resMatr = matrixesEnv.matrixesOrd[matrixesEnv.Count - 1];
                for (int i = (matrixesEnv.Count - 2); i >= 0; i--)
                    resMatr = resMatr * matrixesEnv.matrixesOrd[i];
            }

            //упрощаем матрицу
            dim = matrixesEnv.matrixesOrd[0].Size;
            for (int i = 0; i < dim; i++)
                for (int j = 0; j < dim; j++)
                {
                    resMatr[i, j] = ExpressionString.SimplifyString(resMatr[i, j]);
                }

            //авторазмер ячеек
            foreach (DataGridViewColumn c in dataGridViewMatr.Columns)
            {
                c.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
                c.MinimumWidth = 300;
            }

            dataGridViewMatr.DataSource = resMatr.ConvertToDataTable(); 
        }

        //сохранение в песочницу
        private void buttonSaveToSandbox_Click(object sender, EventArgs e)
        {
            resMatr.Title = "Результат умножения";
            FormMain.sandbox.AddMatrix(resMatr);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void FormMultiplication_Load(object sender, EventArgs e)
        {
            Multiplication(isDirect);
        }

    }
}
