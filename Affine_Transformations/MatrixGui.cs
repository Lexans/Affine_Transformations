using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Resources;
using System.ComponentModel;

namespace Affine_Transformations
{
    public class MatrixGui
    {
        public TableLayoutPanel panel;
        private MatrixCollection matrixes;
        private DataGridView _dataGrid; //ссылка на последнюю добавленную матрицу (костыль для изменения размеров столбцов)

        public MatrixCollection Matrixes
        {
            get { return matrixes; }
            set { matrixes = value; }
        }

        public MatrixGui(TableLayoutPanel panel)
        {
            this.panel = panel;
            matrixes = new MatrixCollection();
        }

        public void AddMatrix(Matrix matr)
        {
            int id = matrixes.Add(matr);
            panel.Controls.Add(TableLayout(id));
            panel.RowCount++;

            
            //авторазмер ячеек
            foreach (DataGridViewColumn c in _dataGrid.Columns)
            {
                c.MinimumWidth = 100;
                c.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            }
            _dataGrid.AutoSize = true;
        }

        public void Clear()
        {
            panel.Controls.Clear();
            matrixes = new MatrixCollection();
        }

        public void Delete(int n, TableLayoutPanel tableLayoutPanel1)
        {
            panel.RowCount--;
            panel.Controls.Remove(tableLayoutPanel1);
            tableLayoutPanel1 = null;
            matrixes.Delete(n);
            matrixes[n] = null;
        }


        /*матрица > gui*/

        //таблица DataGridView матрицы с индексом n
        private DataGridView GenerateDataGrid(int n)
        {
            //таблица значений
            DataGridView dataGrid = new DataGridView();
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.AllowUserToResizeRows = false;
            dataGrid.Name = "dataGridViewMatrix";
            dataGrid.RowTemplate.Height = 24;
            dataGrid.ShowEditingIcon = false;
            dataGrid.AutoSize = true;
            dataGrid.RowHeadersVisible = false;
            dataGrid.ColumnHeadersVisible = false;
            //dataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter; //ЗАВИСАЕТ!
            dataGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler((sender, e) =>
            {
                object newValue = ((DataTable)dataGrid.DataSource).Rows[(int)e.RowIndex][((int)e.ColumnIndex).ToString()];
                if (newValue.GetType() == typeof(string) && (string)newValue != "") matrixes[n][e.RowIndex, e.ColumnIndex] = (string)newValue;
                else
                    ((DataTable)dataGrid.DataSource).Rows[(int)e.RowIndex][((int)e.ColumnIndex).ToString()] = matrixes[n][e.RowIndex, e.ColumnIndex];
            });


            //заполняем dataGrid
            dataGrid.DataSource = matrixes[n].ConvertToDataTable();
            //авторазмер ячеек
            foreach (DataGridViewColumn c in dataGrid.Columns)
            {
                c.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
                c.MinimumWidth = 300;
            }
            dataGrid.AutoSize = true;

            return dataGrid;
        }

        private void CopyToWork(int n)
        {
            FormMain.workenv.AddMatrix(Matrixes[n].Clone());
        }

        //возврвращает полный gui для матрицы
        private TableLayoutPanel TableLayout(int n)
        {
            TableLayoutPanel tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ToolStrip toolStripTools = new System.Windows.Forms.ToolStrip();
            ToolStripButton toolStripButtonUp = new System.Windows.Forms.ToolStripButton();
            ToolStrip toolStripTitle = new System.Windows.Forms.ToolStrip();
            DataGridView dataGridViewMatr = GenerateDataGrid(n);
            _dataGrid = dataGridViewMatr;
            ToolStripButton toolStripButtonDown = new System.Windows.Forms.ToolStripButton();

            ToolStripButton toolStripDelete = new System.Windows.Forms.ToolStripButton();
            ToolStripButton toolStripButtonCalc = new System.Windows.Forms.ToolStripButton();
            ToolStripLabel toolStripLabelTitle = new System.Windows.Forms.ToolStripLabel();


            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.Controls.Add(toolStripTools, 0, 2);
            tableLayoutPanel1.Controls.Add(toolStripTitle, 0, 0);
            tableLayoutPanel1.Controls.Add(dataGridViewMatr, 0, 1);
            tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tableLayoutPanel1.AutoSize = true;
            //tableLayoutPanel1.Size = new System.Drawing.Size(328, 237);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.AutoScroll = true;
            // 
            // toolStripTools
            // 
            toolStripTools.Dock = System.Windows.Forms.DockStyle.Bottom;
            toolStripTools.ImageScalingSize = new System.Drawing.Size(32, 32);
            toolStripTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            toolStripButtonUp,
            toolStripButtonDown,
            toolStripDelete,
            toolStripButtonCalc});
            toolStripTools.Location = new System.Drawing.Point(0, 198);
            toolStripTools.Name = "toolStripTools";
            toolStripTools.Size = new System.Drawing.Size(328, 39);
            toolStripTools.TabIndex = 0;
            toolStripTools.Text = "toolStrip2";
            // 
            // toolStripButtonRight (только для песочницы)
            // 
            if (this.Equals(FormMain.sandbox))
            {
                ToolStripButton toolStripButtonRight = new System.Windows.Forms.ToolStripButton();
                toolStripTools.Items.Add(toolStripButtonRight);
                toolStripButtonRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
                toolStripButtonRight.Image = global::Affine_Transformations.Properties.Resources.iconchevronright;
                toolStripButtonRight.ImageTransparentColor = System.Drawing.Color.Magenta;
                toolStripButtonRight.Name = "toolStripButtonRight";
                toolStripButtonRight.Size = new System.Drawing.Size(36, 36);
                toolStripButtonRight.Text = "Копировать в рабочую среду";
                toolStripButtonRight.Click += new System.EventHandler((x, y) => { CopyToWork(n); });
            }
            // 
            // toolStripButtonUp
            // 
            toolStripButtonUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripButtonUp.Image = global::Affine_Transformations.Properties.Resources.iconchevronup;
            toolStripButtonUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButtonUp.Name = "toolStripButtonUp";
            toolStripButtonUp.Size = new System.Drawing.Size(36, 36);
            toolStripButtonUp.Text = "Вверх";
            toolStripButtonUp.Click += new System.EventHandler((x, y) =>
            {
                Matrixes.MoveUp(n);
                int pos = panel.Controls.IndexOf(tableLayoutPanel1);
                if (pos >= 1)
                {
                    panel.Controls.SetChildIndex(tableLayoutPanel1, pos - 1);
                }
            });
            //
            // toolStripTitle
            // 
            toolStripTitle.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            toolStripTitle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            toolStripLabelTitle});
            toolStripTitle.Location = new System.Drawing.Point(0, 0);
            toolStripTitle.Name = "toolStripTitle";
            toolStripTitle.Size = new System.Drawing.Size(328, 24);
            toolStripTitle.TabIndex = 1;
            toolStripTitle.Text = "toolStripTilte";
            // 
            // dataGridViewMatr
            // 
            dataGridViewMatr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatr.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridViewMatr.Location = new System.Drawing.Point(3, 27);
            dataGridViewMatr.Name = "dataGridViewMatr";
            dataGridViewMatr.RowTemplate.Height = 24;
            //dataGridViewMatr.Size = new System.Drawing.Size(322, 159);
            dataGridViewMatr.TabIndex = 2;


            // 
            // toolStripButtonDown
            // 
            toolStripButtonDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripButtonDown.Image = global::Affine_Transformations.Properties.Resources.iconchevrondown;
            toolStripButtonDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButtonDown.Name = "toolStripButtonDown";
            toolStripButtonDown.Size = new System.Drawing.Size(36, 36);
            toolStripButtonDown.Text = "Вниз";
            toolStripButtonDown.Click += new System.EventHandler((x, y) =>
            {
                Matrixes.MoveDown(n);
                int pos = panel.Controls.IndexOf(tableLayoutPanel1);
                if (pos < panel.Controls.Count-1)
                {
                    panel.Controls.SetChildIndex(tableLayoutPanel1, pos + 1);
                }
            });
            // 
            // toolStripDelete
            // 
            toolStripDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripDelete.Image = global::Affine_Transformations.Properties.Resources.iconremove;
            toolStripDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripDelete.Name = "toolStripDelete";
            toolStripDelete.Size = new System.Drawing.Size(36, 36);
            toolStripDelete.Text = "Удаление";
            toolStripDelete.Click += new System.EventHandler((x, y) =>
            {
                Delete(n, tableLayoutPanel1);
            });
            // 
            // toolStripButtonCalc
            // 
            toolStripButtonCalc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripButtonCalc.Image = global::Affine_Transformations.Properties.Resources.iconcalculatoralt;
            toolStripButtonCalc.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButtonCalc.Name = "toolStripButtonCalc";
            toolStripButtonCalc.Size = new System.Drawing.Size(36, 36);
            toolStripButtonCalc.Text = "Работа с матрицей";
            toolStripButtonCalc.Click += new System.EventHandler((x, y) =>
            {
                FormOperations formOperations = new FormOperations(matrixes[n]);
                formOperations.ShowDialog();
            });
            // 
            // toolStripLabelTitle
            // 
            toolStripLabelTitle.Name = "toolStripLabelTitle";
            toolStripLabelTitle.Size = new System.Drawing.Size(39, 21);
            toolStripLabelTitle.Text = "(id" + n.ToString()+ ") " + matrixes[n].Title;
            // 
            // 
            // toolStripTools
            // 
            toolStripTools.Location = new System.Drawing.Point(0, 0);
            toolStripTools.Name = "toolStripTools";
            toolStripTools.Size = new System.Drawing.Size(100, 25);
            toolStripTools.TabIndex = 0;
            // 
            // toolStripButtonUp
            // 
            toolStripButtonUp.Name = "toolStripButtonUp";
            toolStripButtonUp.Size = new System.Drawing.Size(23, 23);
            // 
            // toolStripTitle
            // 
            toolStripTitle.Location = new System.Drawing.Point(0, 0);
            toolStripTitle.Name = "toolStripTitle";
            toolStripTitle.Size = new System.Drawing.Size(100, 25);
            toolStripTitle.TabIndex = 0;

            return tableLayoutPanel1;

        }

        //gui > матрица
        private void GenerateControl(int n)
        {

        }
    }
}
