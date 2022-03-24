using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Affine_Transformations
{
    //класс операций над элементами матрицы - термами
    public class Term
    {
        public string value;

        public Term()
        {
            value = "";
        }

        public Term(string value)
        {
           this.value = value;
        }

        //неявное преобразование типов строка<->term
        public static implicit operator string(Term term)
        {
            return term.value;
        }

        public static implicit operator Term(string str)
        {
            return new Term(str);
        }

        public override string ToString()
        {
            return value;
        }

        //умножение на минус 1
        public static Term operator -(Term term)
        {
            string result;
            if (term == "0")
                result = term;
            else if (((String)term).StartsWith("-"))
                result = ((String)term).Substring(1);
            else
                result = "-" + (string)term;

            return result;
        }

        public static Term operator /(Term t1, Term t2)
        {
            string result;
            string s1 = (string)t1;
            string s2 = (string)t2;

            if (!(s1.StartsWith("-") ^ s2.StartsWith("-"))) //если +/+ или -/-
            {
                if (s1 != "" && s2 != "")
                    result = String.Format("({0})/({1})", s1, s2);
                else
                    result = String.Format("{0}{1}", s1, s2);
            }
            else if (s1.StartsWith("-")) //-/+
                result = "-"+ s1.Substring(1) + "/" + s2;
            else if (s2.StartsWith("-")) //+/-
                result = "-" + s1 + "/" + s2.Substring(1);
            else //+/+
                result = s1 + "/" + s2;

            return result;
        }

        //сумма двух строк-выражений c учетом пустой строки
        public static Term operator |(Term o1, Term o2)
        {
            string res;
            string s1 = (string)o1;
            string s2 = (string)o2;

            if (s1 != "" && s2 != "")
                res = String.Format("{0}+{1}", s1, s2);
            else
                res = String.Format("{0}{1}", s1, s2);

            return res;
        }

        public static Term operator -(Term o1, Term o2)
        {
            string res="";
            string s1 = (string)o1;
            string s2 = (string)o2;

            if (s1 != "" && s2 != "")
            {
                if(!s2.StartsWith("-"))
                    res = String.Format("{0}-{1}", s1, s2);
                else
                    res = String.Format("{0}+{1}", s1, s2.Substring(1));
            }
            else if (s1 != "" && s2=="")
                res = String.Format("{0}", s1);
            else if (s1 == "" && s2 != "")
                res = -(Term)s2;

            return res;
        }

        //умножение двух строк-выражений c учетом пустой строки
        public static Term operator *(Term o1, Term o2)
        {
            string res;

            if (o1 != "" && o2 != "")
                res = String.Format("(({0})*({1}))", o1, o2);
            else
                res = String.Format("({0}{1})", o1, o2);

            return res;
        }

        //а - угол в градусах
        public static Term Cos(Term aStr)
        {
            double aNum;
            string result;

            if (Double.TryParse(aStr, out aNum)) //если угол - число
            {
                result = String.Format("{0:0.###}", Math.Cos(aNum * Math.PI / 180));
            }
            else
            {
                if (((string)aStr).StartsWith("-"))
                    result = "cos(" + ((string)aStr).Substring(1) + ")";
                else
                    result = "cos(" + aStr + ")";
            }

            return result;
        }

        //а - угол в градусах
        public static Term Sin(Term aStr)
        {
            double aNum;
            string result;

            if (Double.TryParse(aStr, out aNum)) //если угол - число
            {
                result = String.Format("{0:0.###}", Math.Sin(aNum * Math.PI / 180));
            }
            else
            {
                if (((string)aStr).StartsWith("-"))
                    result = "-sin(" + ((string)aStr).Substring(1) + ")";
                else
                    result = "sin(" + aStr + ")";
            }

            return result;
        }
    }
}
