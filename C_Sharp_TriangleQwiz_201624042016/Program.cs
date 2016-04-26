using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_TriangleQwiz_201624042016
{   
    class Program
    {
        static void Main(string[] args)
        {
            TriangleQwiz temp = new TriangleQwiz();
            temp.OpenFile(@"E:\Tools\Study\Projects\C_Sharp_TriangleQwiz_201624042016\triangle.txt");
            temp.Show();
            temp.ResolvePath(temp.GetIntArr);
            Console.ReadKey();          
        }
    }
}
