using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace ClassLibraryForArray
{
   public class IntArray
    {
          //закрытый одномерный массив
         int length;      //закрытая длина
        public int[] a;

        private string Patter = @"[0-9]";
     


        public int Length { get; set; }
        public int this[int i]
        {

            get {
                
                if (i >= 0 && i < length) return a[i];
                else throw new IndexOutOfRangeException();
            }
            set {
              
                if (i >= 0 && i < length ) a[i] = value;
                else throw new IndexOutOfRangeException();
            }
        }

        public IntArray(int length)
        {
           this.length = length;
        }
        public IntArray(params int[] arr)
        {
           length = arr.Length;
            a = new int[length];
            for (int i = 0; i < length; i++) a[i] = arr[i];
        }
       

        public  IntArray RandomIntArray(int length, int a, int b)
        {
            int len = --length;
            int cos;
            Random rand = new Random();
            int[] sw = new int[++length];

            IntArray bip=new IntArray(sw);
            //bip.Length = length + 1;
            
           
            for(int i = 0; i <= len; i++)
            {
                cos = i+ 1;
               bip[i] = rand.Next(a, b);
                Console.WriteLine(cos +") "+ bip[i]);
            }
            return bip;
        }
        public IntArray ArrayFromTextFile(string fileName)
        {
            string readtext;
            int len = 0;
            int count = 0;
            int[] arka;
           
            using (StreamReader SR = new StreamReader(fileName))
            {
                readtext = SR.ReadToEnd();
            }
            readtext = readtext.Replace("\r\n", "");
            readtext = readtext.Replace(" ", "");
         
        


            for (int i = 0; i < readtext.Length; i++)
                if (Regex.IsMatch(readtext[i].ToString(), Patter)) len++;


         //   len++;
            arka = new int[len];


            for (int t = 0; t < readtext.Length; t++)
            {
                if (Regex.IsMatch(readtext[t].ToString(), Patter))
                {
                    
                    arka[count] = int.Parse(readtext[t].ToString());
                    count++;
                    //Console.WriteLine(arka[t]);
                }
            }
            IntArray temp = new IntArray(arka);



            return temp;
        }

        public static int SumArray(IntArray arr)
        {
            int sum=0;
           
             for(int i = 0; i < arr.length; i++)
             {
                sum += arr[i];
             }
            return sum;
        }


        public static IntArray operator ++(IntArray arr)
        {
            IntArray intArray = new IntArray(arr.a.Length);
            intArray.a = new int[arr.a.Length];
            int sw = 0;
            for (int i = 0; i < arr.a.Length; i++)
            {
                 sw = arr.a[i];
                sw++;
                intArray[i] = sw;
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
