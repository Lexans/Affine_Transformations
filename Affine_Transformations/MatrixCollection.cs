using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Affine_Transformations
{
    //коллекция матриц
    [Serializable]
    public class MatrixCollection {
        Dictionary<int, Matrix> matrixes; //каждой матрице поставлен в соответвие уникальный идентификатор
        int maxid; //текущий идентицикатор в словаре
        public List<Matrix> matrixesOrd; //упорядоченный список тех же матриц

        //доступ к матрице по индексу (каждой матрице ставится в соответвие 1 индекс)
        public Matrix this[int n]
        {
            get
            {
                return matrixes[n];
            }
            set
            {
                matrixes[n] = value;
            }
        }

        //общее количество матриц
        public int Count
        {
            get { return matrixesOrd.Count; }
        }

        public MatrixCollection()
        {
            matrixes = new Dictionary<int, Matrix>();
            matrixesOrd = new List<Matrix>();
            maxid = 0;
        }

        //добавляет и возвращает индекс добавленного элемента
        public int Add(Matrix chosedMatr)
        {
            matrixes.Add(maxid, chosedMatr);
            matrixesOrd.Add(chosedMatr);
            maxid++;
            return maxid - 1;
        }

        public void Delete(int n)
        {
            if (matrixes.ContainsKey(n))
            {
                matrixesOrd.Remove(matrixes[n]);
                matrixes.Remove(n);
            }
        }

        public void MoveUp(int n)
        {
            //позиция в упорядоченном списке
            int pos = matrixesOrd.IndexOf(matrixes[n]);

            if (pos >= 1)
            {
                Matrix temp = matrixesOrd[pos-1];
                matrixesOrd[pos - 1] = matrixesOrd[pos];
                matrixesOrd[pos] = temp;
            }
        }

        public void MoveDown(int n)
        {
            //позиция в упорядоченном списке
            int pos = matrixesOrd.IndexOf(matrixes[n]);

            if (pos < (matrixesOrd.Count-1))
            {
                Matrix temp = matrixesOrd[pos + 1];
                matrixesOrd[pos + 1] = matrixesOrd[pos];
                matrixesOrd[pos] = temp;
            }
        }

    }
}
