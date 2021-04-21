using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //Генерация случайного массива из 10 чисел
            int[] arr = new int [10];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rand.Next(-100,100);
            
            //Сортировка по увеличению
            int temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            //Вывод массива
            Console.WriteLine("Массив из 10 чисел отсортированных по увеличению");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();

        }
    }
}
