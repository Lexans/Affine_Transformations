using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Affine_Transformations
{
    public partial class FormMain : Form
    {
        public static MatrixGui sandbox; //gui песочницы
        public static MatrixGui workenv; //gui рабочей среды

        public FormMain()
        {
            InitializeComponent();
            sandbox = new MatrixGui(tableLayoutPanelSandbox);
            workenv = new MatrixGui(tableLayoutPanelWorkenv);
        }

        //кнопка добавления 3x3
        private void toolStripButton3x3_Click(object sender, EventArgs e)
        {
            Matrix matr = new Matrix(3);
            FormCreate3 formCreate3 = new FormCreate3(matr);
            if (formCreate3.ShowDialog() == DialogResult.OK)
            {
                matr = formCreate3.matrix;
                sandbox.AddMatrix(matr);
            }
        }

        private void toolStripButton4x4_Click(object sender, EventArgs e)
        {
            Matrix matr = new Matrix(4);
            FormCreate4 formCreate4 = new FormCreate4(matr);
            if (formCreate4.ShowDialog() == DialogResult.OK)
            {
                matr = formCreate4.matrix;
                sandbox.AddMatrix(matr);
            }
        }

        private void toolStripButtonClear_Click(object sender, EventArgs e)
        {
            workenv.Clear();
        }


        private void toolStripButtonMuliplicateReverse_Click(object sender, EventArgs e)
        {
            if (workenv.Matrixes.Count > 1)
            {
                FormMultiplication formMultiplication = new FormMultiplication(false);
                formMultiplication.ShowDialog();
            }
            else
                MessageBox.Show("В рабочей среде должно быть 2 и более матриц");
        }

        private void toolStripButtonMultiplicateDirect_Click(object sender, EventArgs e)
        {
            if (workenv.Matrixes.Count > 1)
            {
                FormMultiplication formMultiplication = new FormMultiplication(true);
                formMultiplication.ShowDialog();
            }
            else
                MessageBox.Show("В рабочей среде должно быть 2 и более матриц");
        }

        private void toolStripButtonClearSB_Click(object sender, EventArgs e)
        {
            sandbox.Clear();
        }

        private void toolStripButtonCopyAll_Click(object sender, EventArgs e)
        {
            foreach(Matrix m in sandbox.Matrixes.matrixesOrd)
            {
                FormMain.workenv.AddMatrix(m.Clone());
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialogRes = saveFileDialog1.ShowDialog();

            if (dialogRes == DialogResult.OK)
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream serStream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write);
                bf.Serialize(serStream, sandbox.Matrixes);
                serStream.Close();
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialogRes = openFileDialog1.ShowDialog();

            if (dialogRes == DialogResult.OK)
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream streamIn = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                MatrixCollection matrColectSer = (MatrixCollection)bf.Deserialize(streamIn); //десериализуем объект
                streamIn.Close();

                foreach(Matrix m in matrColectSer.matrixesOrd)
                    sandbox.AddMatrix(m);
            }
        }

        
    }
}
