using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Receive
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Receive());
            //string BieuThucInfix = "5+ 6+sin(3)"; // viet khong co dau cach theo chuan
            //BieuThucInfix =  PostFix.FormatExpresion(BieuThucInfix); // Dinh dang lai theo chuan
            //string BieuThucPostfix = PostFix.InfixToPostfix(BieuThucInfix); // Doi qua bieu thuc Postfix
            //string KetQua = PostFix.EvaluatePostfix(BieuThucPostfix).ToString(); // Tinh ket qua
            //Console.WriteLine(BieuThucInfix);
            //Console.WriteLine(BieuThucPostfix);
            //Console.WriteLine(KetQua);
        }
    }
}
