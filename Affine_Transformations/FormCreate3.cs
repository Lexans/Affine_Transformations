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
    public partial class FormCreate3 : Form
    {
        public Matrix matrix; //создаваемая матрица
        public int dim = 3; //размерность

        public FormCreate3(Matrix matrix)
        {
            InitializeComponent();
            this.matrix = matrix;
            InitializeGridTable(dataGridViewMatrCustom);
        }

        //матрица перемещения
        private void buttonSaveMove_Click(object sender, EventArgs e)
        {
            if (textBoxMoveDx.Text != "" && textBoxMoveDy.Text != "")
            {
                matrix = MatrixCreator.MoveMatr(radioButtonMoveOBJ.Checked, dim, new String[] { textBoxMoveDx.Text, textBoxMoveDy.Text });
                matrix.Title = textBoxMoveTitle.Text;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Задайте значения всем коэффициентам");
                this.DialogResult = DialogResult.None;
            }
        }

        //матрица масштабирования
        private void buttonZoomSave_Click(object sender, EventArgs e)
        {
            if (textBoxZoomKx.Text != "" && textBoxZoomKy.Text != "")
            {
                matrix = MatrixCreator.ZoomMatr(radioButtonZoomObj.Checked, dim, new String[] { textBoxZoomKx.Text, textBoxZoomKy.Text });
                matrix.Title = textBoxZoomTitle.Text;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Задайте значения всем коэффициентам");
                this.DialogResult = DialogResult.None;
            }
        }

        //матрица поворота
        private void buttonTurnSave_Click(object sender, EventArgs e)
        {
            if (textBoxTurnAngle.Text != "")
            {
                matrix = MatrixCreator.TurnMatr3(radioButtonZoomObj.Checked, textBoxTurnAngle.Text, checkBoxTurnNoSolve.Checked);
                matrix.Title = textBoxTurnTitle.Text;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Задайте значение углу");
                this.DialogResult = DialogResult.None;
            }
        }

        //матрица сдвига
        private void buttonShearSave_Click(object sender, EventArgs e)
        {
            if (textBoxShearH.Text != "")
            {
                char axis;
                if (radioButtonShearX.Checked)
                    axis = 'x';
                else
                    axis = 'y';

                matrix = MatrixCreator.ShearMatr3(radioButtonTurnObj.Checked, textBoxShearH.Text, axis);
                matrix.Title = textBoxShearTitle.Text;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Задайте значение величине сдвига");
                this.DialogResult = DialogResult.None;
            }
        }

        /*произвольная матрица */
        private void buttonSaveCustom_Click(object sender, EventArgs e)
        {
            SaveToMatrix(dataGridViewMatrCustom);
            matrix.Title = textBoxTitleCustom.Text;
        }
        private void InitializeGridTable(DataGridView dataGrid)
        {
            DataTable TableMatr = new DataTable(); //таблица матрицы
            //задаем столбцы таблицы
            for (int i = 0; i < dim; i++)
            {
                var column = new DataColumn(i.ToString(), typeof(string));
                
                TableMatr.Columns.Add(column);
            }

            //заполняем таблицу
            for (int i = 0; i < dim; i++)
            {
                DataRow row = TableMatr.NewRow();
                for (int j = 0; j < dim; j++)
                    row[(j).ToString()] = "";
                TableMatr.Rows.Add(row);
            }

            for (int i = 0; i < (dim - 1); i++)
                TableMatr.Rows[dim - 1][(i).ToString()] = "0";
            TableMatr.Rows[dim - 1][(dim - 1).ToString()] = "1";

            dataGrid.DataSource = TableMatr;
            foreach(DataGridViewColumn c in dataGrid.Columns)
            {
                c.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
                c.MinimumWidth=100;
            }
            dataGrid.AutoSize = true;
        }
        private void SaveToMatrix(DataGridView dataGrid)
        {
            //определяем не пуста ли введенная матрица
            bool isEmpty = false;

            for (int i = 0; i < dim; i++)
            {
                DataRow row = ((DataTable)dataGrid.DataSource).Rows[i];
                for (int j = 0; j < dim; j++)
                {
                    if ((string)row[j.ToString()] == "")
                    {
                        isEmpty = true;
                        break;
                    }
                }
            }

            if (!isEmpty)
            {
                matrix.FromDataTable((DataTable)dataGridViewMatrCustom.DataSource);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Задайте значения всем ячейкам");
                this.DialogResult = DialogResult.None;
            }
        }

       
    }
}
