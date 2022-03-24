using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Affine_Transformations
{
    //создание матриц перобразований
    static class MatrixCreator
    {
        //создает матрицу перемещения dim порядка, с коэфциентами ds
        public static Matrix MoveMatr(bool isObject, int dim, string[] ds)
        {
            Matrix resMatr = new Matrix(dim);
            for(int i = 0; i<dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    if (i == j)
                        resMatr[i, j] = "1";
                    else if(j==dim-1)
                        resMatr[i, j] = ((isObject) ? ds[i] : (string)-((Term)ds[i]));
                    else resMatr[i, j] = "0";
                }
            }

            return resMatr;
        }


        //создает матрицу перемещения dim порядка, с коэфциентами ds
        public static Matrix ZoomMatr(bool isObject, int dim, string[] ks)
        {
            Matrix resMatr = new Matrix(dim);
            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    if (i == j)
                    {
                        if (j != dim - 1) 
                            resMatr[i, j] = ((isObject) ? ks[i] : (string)(((Term)"1")/(Term)ks[i]));
                        else //для последнего столбца
                            resMatr[i, j] = "1";
                    }
                    else resMatr[i, j] = "0";
                }
            }

            return resMatr;
        }

        //матрица поворота 3х3
        //а - угол в градусах
        public static Matrix TurnMatr3(bool isObject, string a, bool noSolve)
        {
            if(noSolve)
                a += "°";

            Matrix resMatr = new Matrix(3);
            resMatr[0, 0] = Term.Cos(a);
            resMatr[0, 1] = (isObject) ? -Term.Sin(a) : Term.Sin(a);
            resMatr[0, 2] = "0";

            resMatr[1, 0] = (!isObject) ? -Term.Sin(a) : Term.Sin(a);
            resMatr[1, 1] = Term.Cos(a);
            resMatr[1, 2] = "0";

            resMatr[2, 0] = resMatr[2, 1] = "0";
            resMatr[2, 2] = "1";

            return resMatr;
        }

        //матрица поворота 4х4
        //а - угол в градусах. axis - ось (x,y,z)
        public static Matrix TurnMatr4(bool isObject, string a, char axis, bool noSolve)
        {
            if (noSolve)
                a += "°";

            Matrix resMatr = new Matrix(4);

            if (axis == 'x')
            {
                //нулевая строка
                resMatr[0, 0] = "1";
                for (int i = 1; i < 4; i++)
                    resMatr[0, i] = "0";
                
                //первая строка
                resMatr[1, 0] = resMatr[1, 3] = "0";
                resMatr[1, 1] = Term.Cos(a);
                resMatr[1, 2] = (isObject) ? -(Term.Sin(a)) : Term.Sin(a);

                //вторая строка
                resMatr[2, 0] = resMatr[1, 3] = "0";
                resMatr[2, 1] = (!isObject) ? -(Term.Sin(a)) : Term.Sin(a);
                resMatr[2, 2] = Term.Cos(a);

            }
            else if (axis == 'y')
            {
                resMatr[0, 1] = resMatr[1, 3] = "0";
                resMatr[0, 0] = Term.Cos(a);
                resMatr[0, 2] = (!isObject) ? -(Term.Sin(a)) : Term.Sin(a);

                resMatr[1, 0] = resMatr[1, 2] = resMatr[1, 3] = "0";
                resMatr[1, 1] = "1";

                resMatr[2, 0] = (isObject) ? -(Term.Sin(a)) : Term.Sin(a);
                resMatr[2, 1] = resMatr[2, 2] = "0";
                resMatr[2, 2] = Term.Cos(a);
            }
            else if(axis == 'z')
            {
                resMatr[0, 0] = Term.Cos(a);
                resMatr[0, 1] = (isObject) ? -(Term.Sin(a)) : Term.Sin(a);
                resMatr[0, 2] = resMatr[0, 3] = "0";

                resMatr[1, 0] = (!isObject) ? -(Term.Sin(a)) : Term.Sin(a);
                resMatr[1, 1] = Term.Cos(a);
                resMatr[1, 2] = resMatr[1, 3] = "0";

                resMatr[2, 2] = "1";
                resMatr[2, 0] = resMatr[2, 1] = resMatr[2, 3] = "0";
            }

            //последняя строка
            for (int i = 0; i < 3; i++)
            {
                resMatr[3, i] = "0";
                resMatr[i, 3] = "0";
            }
            resMatr[3, 3] = "1";


            return resMatr;
        }

        //матрица сдвига на плоскости
         public static Matrix ShearMatr3(bool isObject, string h, char axis)
        {
            Matrix resMatr = new Matrix(3);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j)
                        resMatr[i, j] = "1";
                    else if(i==0 && j==1&& axis == 'x')
                        resMatr[i, j] = (!isObject) ? (string)-((Term)h) : h;
                    else if(i==1 && j==0 && axis == 'y')
                        resMatr[i, j] = (!isObject) ? (string)-((Term)h) : h;
                    else resMatr[i, j] = "0";
                }
            }

            return resMatr;
        }

         //матрица сдвига в объеме вдоль axisAlong пропорционально axisProportion
         public static Matrix ShearMatr4(bool isObject, string f, char axisAlong, char axisProportion)
         {
             Matrix resMatr = new Matrix(4);

             for (int i = 0; i < 4; i++)
             {
                 for (int j = 0; j < 4; j++)
                 {
                     if (i == j) //диагональные единицы
                         resMatr[i, j] = "1";
                     else
                     {
                         if ((axisAlong == 'x' && i == 0 || axisAlong == 'y' && i == 1 || axisAlong == 'z' && i == 2)
                             && (axisProportion == 'x' && j == 0 || axisProportion == 'y' && j == 1 || axisProportion == 'z' && j == 2))
                         {
                                 if (isObject)
                                     resMatr[i, j] = f;
                                 else
                                     resMatr[i, j] = (string)-((Term)f);
                         }
                         else
                             resMatr[i, j] = "0";
                     }
                 }
             }

             return resMatr;
         }
    }
}
