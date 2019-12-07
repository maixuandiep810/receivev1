using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Receive
{ 
    class PostFix
    {
        public static int GetPriority(string op)
        {
            if (op == "sin" || op == "cos" || op == "log")
                return 3;
            if (op == "*" || op == "/" || op == "%")
                return 2;
            if (op == "+" || op == "-")
                return 1;
            return 0;
        }

        public static string FormatExpresion(string expression)
        {

            expression = expression.Replace(" ", "");
            expression = Regex.Replace(expression, @"\+|\-|\*|\/|\%|\)|\(|sin|cos|log", delegate (Match match)
            {
                return " " + match.Value + " ";
            });
            expression = expression.Replace("  ", " ");
            expression = expression.Trim();
            return expression;
        }

        private static bool IsOperator(string str)
        {

            return Regex.Match(str, @"\+|\-|\*|\/|\%|sin|cos|log").Success;
        }

        private static bool IsOperand(string str)
        {

            return Regex.Match(str, @"^\d+$").Success;
        }

        public static string InfixToPostfix(string infix)
        {

            infix = FormatExpresion(infix);
            IEnumerable<string> str = infix.Split(' ');
            Stack<string> stack = new Stack<string>();
            string postfix = "";

            foreach (string s in str)
            {

                if (IsOperand(s))
                    postfix += (s + " ");
                else if (s == "(")
                    stack.Push(s);
                else if (s == ")")
                {
                    string x = "";
                    while ((x = stack.Pop()) != "(")
                        postfix += (x + " ");

                }
                else if (IsOperator(s))
                {
                    while (stack.Count > 0 && GetPriority(s) <= GetPriority(stack.Peek()))
                        postfix += (stack.Pop() + " ");
                    stack.Push(s);
                }
                else
                {
                    throw new Exception("SYNTAX ERROR");
                }
            };

            while (stack.Count > 0)
                postfix += (stack.Pop() + " ");
            postfix.Trim();
            return postfix;
        }

        public static float EvaluatePostfix(string postfix)
        {

            Stack<float> stack = new Stack<float>();
            IEnumerable<string> ienum = postfix.Split(' ');

            foreach (string s in ienum)
            {

                if (IsOperand(s))
                {

                    stack.Push(float.Parse(s));
                }
                else if (IsOperator(s))
                {

                    if (GetPriority(s) == 3)
                    {
                        float x = stack.Pop();
                        switch (s)
                        {
                            case "sin": x = (float) Math.Sin(x); break;
                            case "cos": x = (float) Math.Cos(x); break;
                            case "log": x = (float) Math.Log10(x); break;
                        }
                        stack.Push(x);
                    }
                    else
                    {
                        float x = stack.Pop();
                        float y = stack.Pop();

                        switch (s)
                        {

                            case "+": y += x; break;
                            case "-": y -= x; break;
                            case "*": y *= x; break;
                            case "/": y /= x; break;
                            case "%": y %= x; break;
                        }
                        stack.Push(y);
                    }
                }
            }

            return stack.Pop();
        }
    }
}
