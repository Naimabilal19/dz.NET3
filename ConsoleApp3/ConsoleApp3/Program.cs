using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region задание 1

             int[] A = new int[5];
             int mult = 1;
             Console.WriteLine("Введите числа для массива из 5 элементов");
             //заполнение массива А
             for(int i=0;i<A.Length;i++)
             {
                 A[i] = Convert.ToInt32(Console.ReadLine());

             }
             Console.WriteLine();
             Console.WriteLine("Массив: ");
             //Отображение А
             for (int i = 0; i < A.Length; i++)
             {
                 mult*= A[i];
                 Console.Write("{0,4}", A[i]);

             }
             Console.WriteLine();
             Console.WriteLine("Максимальный элемент: ");
             Console.WriteLine(A.Max());     //функция для поиска максимального
             Console.WriteLine("Минимальный элемент: ");
             Console.WriteLine(A.Min());     //функция для поиска минимального
             Console.WriteLine("Сумма всех элементов: ");
             Console.WriteLine(A.Sum());     //сумма 
             Console.WriteLine("Произведение всех элементов: ");
             Console.WriteLine("{0}", mult);
             Console.WriteLine("Сумма четных элементов: ");
             Console.WriteLine(A.Where(i => i % 2 == 0).Sum()); 
             Console.WriteLine("------------------------");


             int[,] B = new int[3, 4];
             Console.WriteLine("2-мерный массив:");
             Random r = new Random();
             int max = 0,min=0,sum=0,multt=1,sumcol=0,col;
             for (int i=0;i<B.GetLength(0);i++)
             {
                 for (int j = 0; j < B.GetLength(1); j++)
                 {
                    B[i, j] = r.Next(1, 10);
                    Console.Write("{0,4}", B[i, j]);
                    max = B.Cast<int>().Max();
                    min = B.Cast<int>().Min();
                    sum = B.Cast<int>().Sum();
                    multt *= B[i, j];
                    if(B[i,j]%3==0)
                    {
                        sumcol += B.GetLength(1);
                    }
                }
                 Console.WriteLine();
             }
            Console.WriteLine("Максимальный элемент: {0}", max);
            Console.WriteLine("Минимальный элемент: {0}", min);
            Console.WriteLine("Сумма: {0}", sum);
            Console.WriteLine("Произведение: {0}", multt);
            Console.WriteLine("Cумма нечетных: {0}", sumcol);
            #endregion

            Console.WriteLine("----------задание 2--------------");

            //-----------------------------------------------
            #region задание 2
            int[,] arr2 = new int[5, 5];  //создаю двумерный массив
            Random rnd = new Random();
            int summ = 0,maxx=0,minn=0;
            Console.WriteLine("2-мерный массив:");
            for (int i = 0; i < arr2.GetLength(0); i++)    
            {
                for (int j = 0; j < arr2.GetLength(1); j++) 
                {
                    arr2[i, j] = rnd.Next(1, 10);  //инициализация
                    Console.Write("{0,4}", arr2[i, j]);
                    maxx = arr2.Cast<int>().Max();      //нахождение минимума в двумерном
                    minn = arr2.Cast<int>().Min();       //нахождение максимума в двумерном
                    if (arr2[i, j] != minn && arr2[i, j] != maxx)
                    {
                        summ += arr2[i, j];                //я пыталась
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine("Минимальное: {0}", minn);
            Console.WriteLine("Максимальное: {0}", maxx);
            Console.WriteLine("Сумма между минимальным и максимальным элементами: {0}",summ );
            #endregion



            Console.WriteLine("----------задание 3--------------");
            //-----------------------------------------------
            #region задание 3
            char[] alp = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
            Console.Write("Введите фразу на русском: ");
            string str = Console.ReadLine(); 
            char[] strArr = str.ToCharArray(); // преобразовывает строку в массив символов
            char[] encryption = strArr; //  шифровка

            for (int i = 0; i < strArr.Length; i++)
            {
                int ch = strArr[i]; 
                for (int j = 0; j < alp.Length; j++)
                {                                            
                    if (ch == alp[j])   //если индекс буквы массива равен индексу алфавита
                    {                         
                        int n = j + 3;  //то меняем позицию буквы алфавита на 3 вперед
                        encryption[i] = alp[n]; //заменяем буквы в массиве
                    }
                }
            }
            Console.WriteLine("Шифровка Цезаря:");
            for (int i=0;i<encryption.Length;i++)
            { 
                Console.Write(encryption[i]);
            }
            #endregion

            Console.WriteLine("----------задание 4--------------");
            //-----------------------------------------------
            #region задание 4

            int[,] matrixA = new int[4, 4];
            int[,] matrixB = new int[4, 4];
            int a;    
            int[,] newMat = new int[4, 4];    //матрица для умножения на число
            int[,] multiMatr = new int[4, 4]; //матрица для умножения А на B
            int[,] SumMatr = new int[4, 4];    //матрица для сложения А на B
            Random rand1 = new Random();
            Console.WriteLine("Введите число, которое будет умножено на матрицу");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Матрица A:");
            for (int i=0;i<matrixA.GetLength(0);i++)
            {
                for(int j=0;j<matrixA.GetLength(1);j++)
                {
                    matrixA[i, j] = rand1.Next(1, 5);
                    Console.Write("{0,4}", matrixA[i, j]);
                    
                }
                Console.WriteLine();
            }


            Console.WriteLine("Матрица B:");
            for (int i = 0; i < matrixB.GetLength(0); i++)
            {
                for (int j = 0; j < matrixB.GetLength(1); j++)
                {
                    matrixB[i, j] = rand1.Next(1, 5);
                    Console.Write("{0,4}", matrixB[i, j]);
                }
                Console.WriteLine();
            }


            Console.WriteLine("Матрица А, умноженная на заданное число: ");
            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixA.GetLength(1); j++)
                {
                    newMat[i, j] = matrixA[i, j] * a;
                    Console.Write("{0,4}", newMat[i, j]);
                }
                Console.WriteLine();
            }


            Console.WriteLine("Сложение матриц A & B");
            for (int i=0;i<matrixA.GetLength(0);i++)
            {
                for(int j=0;j<matrixB.GetLength(1);j++)
                {
                    SumMatr[i,j] = matrixA[i, j] + matrixB[i, j];
                    Console.Write("{0,4}", SumMatr[i, j]);
                }
                Console.WriteLine();
            }


            Console.WriteLine("Умножение матриц A & B");
            for (int i = 0; i < matrixA.GetLength(0); i++)      //берем строки с матрицы А
            {
                for (int j = 0; j < matrixB.GetLength(1); j++)     //столбцы с матрицы B
                {
                    for (int k = 0; k < matrixB.GetLength(1); k++)       
                    {
                        if (matrixA.GetLength(0) == matrixB.GetLength(1))      //если длина строки первой матрицы равна длине столбцу второй матрицы
                        {
                            multiMatr[i, j]+= matrixA[i, k] * matrixB[k, j];      //то умножаем 
                        }
                    }
                    Console.Write("{0,4}", multiMatr[i, j]);
                }
                Console.WriteLine();
            }
             #endregion
        }
           
        }
    }

