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
    public partial class FormCreate4 : Form
    {
        public Matrix matrix; //создаваемая матрица
        public int dim = 4; //размерность

        public FormCreate4(Matrix matrix)
        {
            InitializeComponent();
            this.matrix = matrix;
            InitializeGridTable(dataGridViewMatrCustom);
        }


        /*произвольная матрица */
        private void buttonSaveCustom_Click(object sender, EventArgs e)
        {
            SaveToMatrix(dataGridViewMatrCustom);
            matrix.Title = textBoxTitleCustom.Text;

        }
        //создает пустые ячейки таблицы
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
            foreach (DataGridViewColumn c in dataGrid.Columns)
            {
                c.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
                c.MinimumWidth = 100;
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

        private void buttonSaveMove_Click(object sender, EventArgs e)
        {
            if (textBoxMoveDx.Text != "" && textBoxMoveDy.Text != "" && textBoxMoveDz.Text != "")
            {
                matrix = MatrixCreator.MoveMatr(radioButtonMoveOBJ.Checked, dim, new String[] { textBoxMoveDx.Text, textBoxMoveDy.Text, textBoxMoveDz.Text });
                matrix.Title = textBoxMoveTitle.Text;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Задайте значения всем коэффициентам");
                this.DialogResult = DialogResult.None;
            }
        }

        private void buttonZoomSave_Click(object sender, EventArgs e)
        {
            if (textBoxZoomKx.Text != "" && textBoxZoomKy.Text != "" && textBoxZoomKz.Text != "")
            {
                matrix = MatrixCreator.ZoomMatr(radioButtonZoomObj.Checked, dim, new String[] { textBoxZoomKx.Text, textBoxZoomKy.Text, textBoxZoomKz.Text });
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
                char axis;
                if (radioButtonTurnX.Checked)
                    axis = 'x';
                else if (radioButtonTurnY.Checked)
                    axis = 'y';
                else
                    axis = 'z';

                matrix = MatrixCreator.TurnMatr4(radioButtonZoomObj.Checked, textBoxTurnAngle.Text, axis, checkBoxTurnNoSolve.Checked);
                matrix.Title = textBoxTurnTitle.Text;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Задайте значение углу");
                this.DialogResult = DialogResult.None;
            }
        }

        private void buttonShearSave_Click(object sender, EventArgs e)
        {
            if (textBoxShearH.Text != "")
            {
                char axisAlong;
                if (radioButtonShearX.Checked)
                    axisAlong = 'x';
                else if (radioButtonShearY.Checked)
                    axisAlong = 'y';
                else
                    axisAlong = 'z';

                char axisProp;
                if (radioButtonShearPropX.Checked)
                    axisProp = 'x';
                else if (radioButtonShearPropY.Checked)
                    axisProp = 'y';
                else
                    axisProp = 'z';

                matrix = MatrixCreator.ShearMatr4(radioButtonTurnObj.Checked, textBoxShearH.Text, axisAlong, axisProp);
                matrix.Title = textBoxShearTitle.Text;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Задайте значение величине сдвига");
                this.DialogResult = DialogResult.None;
            }
        }

    }
}
