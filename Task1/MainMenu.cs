using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryForArray;

namespace Task1
{
    class MainMenu
    {
       
        public static void Menu()
        {
       
         
            string answer;
            
            Console.WriteLine("\r\n"+"С 4 задание по 7, выбрать надо сложение или вычитание 1/0 и откуда брать массив");
            Console.WriteLine("1.Рандомный массив.");
            Console.WriteLine("2.Открыть Массив.");
            Console.WriteLine("3.Сумма массива.");
            Console.WriteLine("4.Увеличить/уменьшить массив на 1.");
            Console.WriteLine("5.Сложение/вычитание скаляра х.");
            Console.WriteLine("6.Сложение/вычитание двух массивов.");
            Console.WriteLine("7.Очистить консоль.");

            Console.Write("Выбрать функцию:");
            answer = Console.ReadLine();
            try
            {
                if (Convert.ToInt32(answer) < 0 || Convert.ToInt32(answer) > 7) 
                {
                    Console.WriteLine("Нет такого задания, нажмите enter для продолжения");
                    Console.ReadLine();
                    Menu();
                }
            else
                    switch (Convert.ToInt32(answer))
                    {
                        case 1:
                            {
                                task1();
                                
                                Menu();
                                break;
                            }
                        case 2:
                            {
                                task2();
                                
                                Menu();
                                break;
                            }
                        case 3:
                            {
                                task3();
                                Menu();
                                break;
                            }
                        case 4:
                            {
                                task4();
                                Menu();
                                break;
                            }
                        case 5:
                            {
                                task5();
                                Menu();
                                break;
                            }
                        case 6:
                            {
                                task7();
                                Menu();
                                break;
                            }
                        case 7:
                            {
                                Console.Clear();
                                Menu();
                                break;
                            }
                    }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("нажмите enter для продолжения");
                Console.ReadLine();
                Menu();
            }
        }

       static int[] task1()
        {
            int lenght,min,max;

            Console.Write("\r\n" + "Введите размер:");
           lenght= Convert.ToInt32(Console.ReadLine()) ;
            Console.Write("\r\n");
            Console.Write("Введите Min:");
            min = Convert.ToInt32(Console.ReadLine());

            Console.Write("\r\n");
            Console.Write("Введите Max:");
               max = Convert.ToInt32(Console.ReadLine());

            IntArray AI = new IntArray();
            IntArray pb;
            pb=AI.RandomIntArray(lenght, min, max);
            return pb.a;
        }



        static void task3()
        {
            int len,count;
            Console.Write("\r\n" + "Введите размерность масива:");
            len= Convert.ToInt32( Console.ReadLine() );
            int[] sw = new int[len];
           
            for (int i = 0; i < len; i++)
            {
                count = i + 1;
                Console.Write($"\n" + "Значение" + count.ToString() + ":");
               sw[i]=Convert.ToInt32( Console.ReadLine() );
            }
           

            IntArray ia = new IntArray(sw);

         Console.WriteLine("\r\n"+ "Сумма массива равняется:" + IntArray.SumArray(ia) +"\r\n");
            
        }


       static void task2()
        {
            string pathExample = @"C:\folder\tex.txt";
            string path;

            Console.Write($"\r\n Введите строку где находится файл например ({pathExample}):");
            path=Console.ReadLine();

            IntArray AI = new IntArray();

         AI= AI.ArrayFromTextFile(path);
          
            Console.WriteLine("массив:");
            for(int o=0; o < AI.a.Length; o++)
            {
                Console.WriteLine(AI.a[o]);
            } 
            
        }

        static void task4()
        {
            int[] p = task1();
            IntArray AI=new IntArray();
            AI.a = p;
            Console.WriteLine("1 или 0, 1 значение +, 0 зачение -");
            string answer = Console.ReadLine();


            IntArray PB=AI;
            switch (Convert.ToInt32(answer))
            {
                case 0:
                    {
                        PB = --AI;
                        break;
                    }
                case 1:
                    {
                        PB = ++AI;
                        break;
                    }
            }
            Console.WriteLine("\r\n ОТВЕТ:");
            for (int o = 0; o < PB.a.Length; o++)
            {
                Console.Write(o + 1 + ")");
                Console.WriteLine(PB.a[o]);
            }
           

        }
        static void task5()
        {
            int cost;
            int[] p = task1();
            IntArray AI = new IntArray();
            AI.a = p;
            Console.Write("на сколько прибавить/уменьшить каждый эллемент массива?:");
            string answer = Console.ReadLine();

            cost = Convert.ToInt32(answer);

            Console.WriteLine("1 или 0, 1 значение +, 0 зачение -");
             answer = Console.ReadLine();

            IntArray PB = AI;
            switch (Convert.ToInt32(answer))
            {
                case 0:
                    {
                        PB = AI-cost;
                        break;
                    }
                case 1:
                    {
                        PB = AI+cost;
                        break;
                    }
            }
            Console.WriteLine("\r\n ОТВЕТ:");
            for (int o = 0; o < PB.a.Length; o++)
            {
                Console.Write(o + 1 + ")");
                Console.WriteLine(PB.a[o]);
            }

        }
        static void task6()
        {//Тоже самое что и задание 5.. бред какой то.. но оно есть
            int cost;
            int[] p = task1();
            IntArray AI = new IntArray();
            AI.a = p;
            Console.Write("на сколько прибавить/уменьшить каждый эллемент массива?:");
            string answer = Console.ReadLine();

            cost = Convert.ToInt32(answer);

            Console.WriteLine("1 или 0, 1 значение +, 0 зачение -");
            answer = Console.ReadLine();

            IntArray PB = AI;
            switch (Convert.ToInt32(answer))
            {
                case 0:
                    {
                        PB = cost-AI ;
                        break;
                    }
                case 1:
                    {
                        PB = cost + AI;
                        break;
                    }
            }
            Console.WriteLine("\r\n ОТВЕТ:");
            for (int o = 0; o < PB.a.Length; o++)
            {
                Console.Write(o + 1 + ")");
                Console.WriteLine(PB.a[o]);
            }

        }
        static void task7()
        {
            int[] mass1 = task1();
            int[] mass2 = task1();

            IntArray MASS1 = new IntArray();
            MASS1.a = mass1;
            IntArray MASS2 = new IntArray();
            MASS2.a = mass2;

            string answer;

            Console.WriteLine("1 или 0, 1 значение +, 0 зачение -");
            answer = Console.ReadLine();
            int len = MASS1.a.Length < MASS2.a.Length ? MASS1.a.Length : MASS2.a.Length;
            
            IntArray PB = MASS1.a.Length < MASS2.a.Length ? MASS1 : MASS2;
            PB.Length = len;
            switch (Convert.ToInt32(answer))
            {
                case 0:
                    {
                        PB = MASS1 - MASS2;
                        break;
                    }
                case 1:
                    {
                        PB = MASS1 + MASS2;
                        break;
                    }
            }

            Console.WriteLine("\r\n ОТВЕТ:");
            for (int o = 0; o < PB.a.Length; o++)
            {
                Console.Write(o + 1 + ")");
                Console.WriteLine(PB.a[o]);
            }

            Console.WriteLine();

        }



     
    }
}

