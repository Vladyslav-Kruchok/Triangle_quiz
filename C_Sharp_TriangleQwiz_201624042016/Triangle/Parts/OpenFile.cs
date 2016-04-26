using System;
using System.IO;
using System.Text;

namespace C_Sharp_TriangleQwiz_201624042016
{
    class OpenFile
    {
        private string m_string_from_file;
        private string[] m_arr;
        private string[][] m_arr_x2;
        private int[][] m_int_arr_x2;
        public int[][] GetIntArr
        {
            get { return m_int_arr_x2; }
        }
        private int m_size;
        public int GetRow
        {
            get { return m_size; }
        }
        //constructor
        public OpenFile() { }
        public void OpenDataFile (string f_filename)
        {
            m_string_from_file = f_filename;
            //open filestream to read a file
            StreamReader sr = new StreamReader(f_filename, Encoding.UTF8);
            //local variable to write info. separator figure=space, row='\n'
            m_arr = sr.ReadToEnd().Split('\n');
            sr.Dispose();
        }
        //txt->arr
        public void TransformToArr()
        {
            m_size = m_arr.Length;
            //an arr to write colomns into rows. rows = m_size = 15
            m_arr_x2 = new string[m_size][];
            for(int i = 0; i < m_size; ++i)
            {
                //an amount of colomn into row, the first row = 1 figure, the last = 15 figures
                int colomn = m_arr[i].Length;
                //initialize arr 
                m_arr_x2[i] = new string[colomn];
                //write figures into row
                m_arr_x2[i] = m_arr[i].Split(' ');
            }
        }
        //arr->intarr
        public void ArrStrToArrInt()
        {
            m_int_arr_x2 = new int[m_size][];
            for (int i = 0; i < m_size; ++i)
            {
                int colomn = m_arr_x2[i].Length;
                m_int_arr_x2[i] = new int[colomn];
                for (int j = 0; j < colomn; ++j)
                {
                   m_int_arr_x2[i][j] = Convert.ToInt16(m_arr_x2[i][j]);
                }
            }
        }
        //to show triangle
        public void Show()
        {

            for (int i =0; i < m_size; ++i)
            {
                int colomn = m_int_arr_x2[i].Length;
                for(int j = 0; j < colomn; j++)
                {
                    Console.Write(" {0:00}",m_int_arr_x2[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
