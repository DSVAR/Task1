using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForArray
{
    class IntArray
    {
       private int[] a;    //закрытый одномерный массив
       private int length;      //закрытая длина

        public int Length { get; set; }
        public int this[int i]
        {
            get { return 0; }
            set { a[i] = value; }
        }
        public IntArray(int length)
        {

        }
        public IntArray(params int[] arr)
        {

        }
       

        public static IntArray RandomIntArray(int length, int a, int b)
        {

            return null;
        }

        public static int SumArray(IntArray arr)
        {
           
            return 1;
        }


        public static IntArray operator ++(IntArray arr)
        {
            IntArray intArray = new IntArray(arr.a);

            return intArray;

        }
        public static IntArray operator +(IntArray x, int y)
        {
            IntArray intArray =new IntArray()
        }
    }
}
