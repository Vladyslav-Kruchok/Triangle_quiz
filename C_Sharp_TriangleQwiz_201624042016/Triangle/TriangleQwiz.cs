using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_TriangleQwiz_201624042016
{
    
    class TriangleQwiz
    {
        private OpenFile m_open_file = null;
        public int[][] GetIntArr
        {
            get { return m_open_file.GetIntArr; }
        }

        private void Initialize()
        {
            m_open_file = new OpenFile();
        }
        public TriangleQwiz()
        {
            Initialize();
        }
        public void OpenFile (string f_path)
        {
            m_open_file.OpenDataFile(f_path);
            m_open_file.TransformToArr();
            m_open_file.ArrStrToArrInt();
        }
        public void ResolvePath(int[][] f_arr_x2)
        {
            int base_i = 0, base_j = 0;
            int row = m_open_file.GetRow;
            int sum = f_arr_x2[0][0];
            for (int i = 0; i < (row*3); ++i)
            {
                Console.Write("-");
            }
                Console.Write("\n {0:00}", f_arr_x2[0][0]);
            for (int i=0; i < (row - 1);++i)
            {
                int colomn = m_open_file.GetIntArr[i].Length;
                if (Leftbroad(base_i, base_j))
                {
                    //true is left broad
                    if(f_arr_x2[base_i+1][base_j] >= f_arr_x2[base_i + 1][base_j+1])
                    {
                        sum += f_arr_x2[base_i + 1][base_j];//base figure the bigest
                        Console.Write(" {0:00}", f_arr_x2[base_i + 1][base_j]);
                        base_i = base_i + 1;
                        base_j = base_j + 0;                        
                     }
                    else
                    {
                        sum += f_arr_x2[base_i + 1][base_j + 1];//base figure the bigest
                        Console.Write(" {0:00}", f_arr_x2[base_i + 1][base_j + 1]);
                        base_i = base_i + 1;
                        base_j = base_j + 1;
                    }
                }
                else
                {
                    //false
                    if ((f_arr_x2[base_i + 1][base_j - 1] >= f_arr_x2[base_i + 1][base_j + 1])&base_i+1< m_open_file.GetRow)//row below - left/right
                    {
                        sum += f_arr_x2[base_i + 1][base_j - 1];//base figure the bigest
                        Console.Write(" {0:00}", f_arr_x2[base_i + 1][base_j - 1]);
                        base_i = base_i + 1;
                        base_j = base_j - 1;
                    }
                    else
                    {
                        sum += f_arr_x2[base_i + 1][base_j + 1];//base figure the bigest
                        Console.Write(" {0:00}", f_arr_x2[base_i + 1][base_j + 1]);
                        base_i = base_i + 1;
                        base_j = base_j + 1;
                    }
                }
            }
            Console.WriteLine("\n Sum of elements = {0}",sum);
        }
        private bool Leftbroad(int f_base_i, int f_base_j)
        {
            if (f_base_j==0)
            {
                return true;
            }
            return false;
        }

        public void Show()
        {
            m_open_file.Show();
        }
    }
}
