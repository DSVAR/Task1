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
            get {
                if (i >= 0 && i < length) return a[i];
                else throw new IndexOutOfRangeException();
            }
            set {
                if (i >= 0 && i < length) a[i] = value;
                else throw new IndexOutOfRangeException();
            }
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
            IntArray intArray = new IntArray(arr.length);
            for (int i = 0; i < arr.length; i++)
            {
                intArray[i] = arr.a[i]++;
            }
            return intArray;

        }
        public static IntArray operator +(IntArray x, int y)
        {
            IntArray temp = new IntArray(x.length);
            for(int i = 0; i < x.length; i++)
                temp[i] =x[i]+ y;
            
            return temp;
        }

        public static IntArray operator +(int x, IntArray y)
        {
            IntArray temp = new IntArray(y.length);
            for (int i = 0; i < y.length; i++)
                temp[i] = x + y[i];

            return temp;
        }

        public static IntArray operator +(IntArray x, IntArray y)
        {
            int len = x.length < y.length ? x.length : y.length;
            IntArray temp = new IntArray(len);
            for (int i = 0; i < len; i++) temp[i] = x[i] + y[i];

            return temp;
        }

        /////////////////////////
        ///
        //1
        public static IntArray operator --(IntArray arr)
        {
            IntArray intArray = new IntArray(arr.length);
            for (int i = 0; i < arr.length; i++)
            {
                intArray[i] = arr.a[i]--;
            }
            return intArray;

        }
        //2
        public static IntArray operator -(IntArray x, int y)
        {
            IntArray temp = new IntArray(x.length);
            for (int i = 0; i < x.length; i++)
                temp[i] = x[i] - y;

            return temp;
        }
        //3
        public static IntArray operator -(int x, IntArray y)
        {
            IntArray temp = new IntArray(y.length);
            for (int i = 0; i < y.length; i++)
                temp[i] = x - y[i];

            return temp;
        }
        //4
        public static IntArray operator -(IntArray x, IntArray y)
        {
            int len = x.length < y.length ? x.length : y.length;
            IntArray temp = new IntArray(len);
            for (int i = 0; i < len; i++) temp[i] = x[i] - y[i];

            return temp;
        }


    }
}
