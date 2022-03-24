using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace TreeApplication
{
    public class TreeNode
    {
        private string[] operators = new string[] { "-", "+", "*", "/" }; //допустимые операторы
        private string info;
        private bool isOperator;
        public TreeNode left, right;

        public string Info
        {
            get { return info; }
            set
            {
                info = value;
                if (operators.Contains(value))
                    isOperator = true;
                else isOperator = false;
            }
        }
        public bool IsOperator { get { return isOperator; } }
        public TreeNode Left { get { return left; } set { left = value; } }
        public TreeNode Right { get { return right; } set { right = value; } }

        public TreeNode()
        {
        }

        public TreeNode(string info)
        {
            Info = info;
            Left = Right = null;
        }

        public TreeNode(string info, TreeNode left, TreeNode right)
        {
            Info = info;
            Left = left;
            Right = right;
        }
    }

    class ExpressionTree
    {
        private TreeNode root;

        public TreeNode Root { get { return root; } set { root = value; } }

        public ExpressionTree()
        {
            Root = null;
        }

        //строит дерево по строковому выражению
        public void Create(ExpressionString formula)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>(); //вспомогательный стек узлов
            string[] postfixExpr = formula.PostfixNotation; //элементы выражения в постфиксной нотации

            TreeNode[] Nodes = new TreeNode[postfixExpr.Length];
            for (int i = 0; i < postfixExpr.Length; i++)
                Nodes[i] = new TreeNode(postfixExpr[i]); //узлы будущего дерева

            foreach (TreeNode Node in Nodes)
            {
                if (!Node.IsOperator) //операнды помещаем в вершину стека
                    stack.Push(Node);
                else //обработка операций
                {
                    if (stack.Count < 2)
                        throw new FormatException();

                    Node.Right = stack.Pop(); //устанавливаем связи с операндами
                    Node.Left = stack.Pop();

                    stack.Push(Node); //результат помещаем в стек
                }
            }

            if (stack.Count > 0)
                Root = stack.Pop();
            else Root = null;
        }

        //упрощаем в восходящем обходе
        private void Simplify(ref TreeNode node)
        {
            if (node != null)
            {
                Simplify(ref node.left);
                Simplify(ref node.right);

                if (node.IsOperator)
                {
                    //упрощаем
                    if (node.Info == "+")
                    {
                        if (node.Right.Info == "0") //f+0
                            node = node.Left;
                        else if (node.Left.Info == "0") //0+f
                            node = node.Right;
                    }
                    else if (node.Info == "-")
                    {
                        if (node.Right.Info == "0") //f-0
                            node = node.Left;
                    }
                    else if (node.Info == "*")
                    {
                        if (node.Right.Info == "1")//f*1
                            node = node.Left;
                        else if (node.Left.Info == "1")//1*f
                            node = node.Right;
                        else if (node.Right.Info == "0") //f*0
                            node = node.Right;
                        else if (node.Left.Info == "0") //0*f
                            node = node.Left;
                        else if (node.Left.Info == "-1")
                        {
                            node = node.Right;
                            node.Info = "-" + node.Info;
                        }
                        else if (node.Right.Info == "-1")
                        {
                            node = node.Left;
                            node.Info = "-" + node.Info;
                        }
                    }
                }
            }
        }

        public void Simplify()
        {
            Simplify(ref this.root);
        }


        //предвычисление констант
        public void SimplifyConst(ref TreeNode node)
        {
            Regex digitRegExp = new Regex("^-?\\d+(?:\\.\\d+)?$");

            if (node != null)
            {
                SimplifyConst(ref node.left);
                SimplifyConst(ref node.right);

                if (node.IsOperator)
                {
                    //упрощаем
                    if (node.Info == "+" || node.Info == "-" || node.Info == "*" || node.Info == "/")
                    {
                        
                        double op1;
                        double op2;
                        if (node.Left.Info == "k1" || node.Right.Info == "k1")
                        {
                        }

                        if (Double.TryParse(node.Left.Info.Replace(".", ","), out op1) && Double.TryParse(node.Right.Info.Replace(".", ","), out op2))
                        {
                            switch (node.Info)
                            {
                                case "+":
                                    node.Info = (op1 + op2).ToString();
                                    break;
                                    
                                case "-":
                                    node.Info = (op1 - op2).ToString();
                                    break;

                                case "*":
                                    node.Info = String.Format("{0:0.###}", op1 * op2);
                                    break;

                                case "/":
                                    node.Info = String.Format("{0:0.###}", op1 / op2);
                                    break;
                            }

                            node.Left = null;
                            node.Right = null;
                        }

                        //sin^2a+cos^2a=1
                        if (node.Info == "+")
                        {
                            if(node.Left.IsOperator && node.Left.Info == "*" && node.Right.IsOperator && node.Right.Info == "*")
                            {
                                if (node.Left.Left.Info == node.Left.Right.Info && node.Left.Left.Info.StartsWith("cos") && node.Right.Left.Info == node.Right.Right.Info && node.Right.Left.Info.StartsWith("sin")
                                    || node.Left.Left.Info == node.Left.Right.Info && node.Left.Left.Info.StartsWith("sin") && node.Right.Left.Info == node.Right.Right.Info && node.Right.Left.Info.StartsWith("cos"))
                                {
                                    node.Info = "1";
                                    node.Left = null;
                                    node.Right = null;
                                }
                            }
                        }
                    }
                }
            }
        }

        public void SimplifyConst()
        {
            SimplifyConst(ref this.root);
        }


        //разрушение дерева
        public void Destroy()
        {
            root = null;
        }

        //высота дерева
        private int Height(TreeNode p)
        {
            int result = 0;
            if (p != null)
            {
                int hLeft = Height(p.Left);
                int hRight = Height(p.Right);
                if (hLeft > hRight)
                    result = 1 + hLeft;
                else result = 1 + hRight;
            }
            return result;
        }

        public int Height()
        {
            return Height(root);
        }

        public string ToString(TreeNode node)
        {
            string result = "";

            if (node != null)
            {
                if (node.IsOperator)
                {
                    switch (node.Info)
                    {
                        case "-":
                            result = ToString(node.Left) + "-"
                                + ((node.Right.IsOperator) ? "(" : "") + ToString(node.Right) + ((node.Right.IsOperator) ? ")" : ""); ;
                            break;
                        case "+":
                            result = ToString(node.Left) + "+" + ToString(node.Right);
                            break;
                        case "*":
                            result = ((node.Left.IsOperator) ? "(" : "") + ToString(node.Left) + ((node.Left.IsOperator) ? ")" : "") + "*"
                                + ((node.Right.IsOperator) ? "(" : "") + ToString(node.Right) + ((node.Right.IsOperator) ? ")" : "");
                            break;
                        case "/":
                            result = ((node.Left.IsOperator) ? "(" : "") + ToString(node.Left) + ((node.Left.IsOperator) ? ")" : "") + "/"
                                + ((node.Right.IsOperator) ? "(" : "") + ToString(node.Right) + ((node.Right.IsOperator) ? ")" : "");
                            break;
                    }
                }
                else
                {
                    if (node.Info.StartsWith("-"))
                        result = "("+node.Info+")";
                    else
                        result = node.Info;
                }

            }

            return result;
        }

        public override string ToString()
        {
            return ToString(this.root);
        }
    }
}
