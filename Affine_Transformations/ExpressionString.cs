using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace TreeApplication
{
    //класс работы со строковым представлением математического выражения
    public class ExpressionString
    {
        private readonly string[] operators = new string[] { "(", ")", "-", "+", "*", "/" }; //доступные операции
        private string[] infixNotation; //инфиксная форма
        private string[] postfixNotation; //постфиксная форма

        public string InfixNotation
        {
            get { return infixNotation.ToString(); }
            set
            {
                infixNotation = ToSeparate(value);
                MakePostfix();
            }
        }

        public string[] PostfixNotation
        {
            get { return postfixNotation; }
        }

        public ExpressionString(string infixExpression)
        {
            InfixNotation = infixExpression;
        }

        //возвращает приоритет операций
        private int GetPriority(string s)
        {
            int priority;
            if (s == "(" || s == "(")
                priority = 0;
            else if (s == "+" || s == "-")
                priority = 1;
            else if (s == "*" || s == "/")
                priority = 2;
            else
                priority = 3;
            
            return priority;
        }

        //разделяет выражение на операции и операнды
        private string[] ToSeparate(string input)
        {
            List<string> result = new List<string>();
            Regex allowedSym = new Regex("^(?:\\:||\\^|\\.|_|,)$");

            for (int pos = 0; pos < input.Length; )
            {
                string s = "";

                if (!((pos == 0 || input[pos - 1] == '(') && input[pos] == '-') && operators.Contains(input[pos].ToString())) //оператор
                    s = input[pos].ToString();
                else if (Char.IsLetterOrDigit(input[pos]) || input[pos] == '-') //если операнд - считываем его полностью
                {
                    bool flag = false;
                    s = input[pos].ToString();
                    for (int i = pos + 1; (i < input.Length) && ((Char.IsLetterOrDigit(input[i]) || allowedSym.IsMatch(input[i].ToString()))
                        || (s == "-" && (pos == 0 && input[pos - 1] == '('))
                        || (input[i] == '(' && ((i - 1) >= 0) && Char.IsLetter(input[i - 1]) && (flag = true))
                        || (flag == true && input[i] != ')')
                        || (input[i] == ')' && (flag == true) && !(flag = false))); i++)
                        s += input[i];
                }
                else //недопустимый символ
                    throw new FormatException();

                result.Add(s);
                pos += s.Length;
            }

            return result.ToArray();
        }

        //получает PostFixexpression по алгоритму Дейкстра
        private void MakePostfix()
        {
            List<string> outputExpr = new List<string>(); //выходное выражение в постфиксной форме
            Stack<string> stack = new Stack<string>(); //вспомогательный стек

            foreach (string c in infixNotation)
            {
                if (!operators.Contains(c)) //если операнд - помещаем в outputExpr
                    outputExpr.Add(c);
                else if (c == "(") //если открывающаяся скобка - помещаем в стек
                    stack.Push(c);
                else if (c == ")") //если закрывающаяся скобка
                {   //пока верхним элементом стека не станет открывающая скобка выталкиваем элементы из стека в outputExpr
                    string s;
                    do
                    {
                        if (stack.Count > 0) s = stack.Pop();
                        else throw new FormatException();
                        if (s != "(") outputExpr.Add(s); //саму скобку не добавляем
                    } while (s != "(");
                }
                else //если оператор (левоассоциативный)
                {   //пока приоритет текущего оператора меньше либо равен приоритету опреатора находящегося на вершине стека выталкиваем элементы стека в outputExpr
                    while (stack.Count > 0 && GetPriority(c) <= GetPriority(stack.Peek()))
                        outputExpr.Add(stack.Pop());
                    stack.Push(c); //помещаем текущий оператор в стек
                }
            }

            //выталкиваем все оставшиеся операторы из стека в outputExpr
            if (stack.Count > 0)
                foreach (string c in stack)
                    if (operators.Contains(c)) outputExpr.Add(c);
                    else throw new FormatException();

            postfixNotation = outputExpr.ToArray();
        }

        public static string SimplifyString(string Expression)
        {
            string result = Expression;

            ExpressionTree tree = new ExpressionTree();
            tree.Create(new ExpressionString(result));

            do
            {
                tree.Simplify();
                tree.SimplifyConst();
            }
            while (result != (result = tree.ToString()));

            return result;
        }
    }
}