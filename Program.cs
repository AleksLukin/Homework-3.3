using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] myArray = new string[,]
            {
                {"Semenev","Semakov","Nevikov","Sorikov","Shumachin"},
                {"336-43-32","336-43-33","336-43-34","336-43-35","336-43-36"},
                {"sem@ekb.ru","sma@ekb.ru","nev@ekb.ru","sor@ekb.ru","shu@ekb.ru" }
            };
            int height = myArray.GetLength(0);//вводим переменную для получения длины массива по вертикали
            int width = myArray.GetLength(1);//вводим переменную для получения длины массива по горизонтали

            for (int i = 0; i < height; i++) // внешний цикл с выводом данных по вертикали

            {
                for (int j = 0; j < width; j++) //вложенный цикл с выводом данных по горизонтали
                {
                    Console.Write(myArray[i, j] + " \t "); //для вывода массива как в условии задачи используем Write вместо WriteLine
                }
                Console.WriteLine();// вводим для разделения между столбцами
            }
        }
    }
}

/*Написать программу — телефонный справочник — создать двумерный массив 5*2, хранящий
список телефонных контактов: первый элемент хранит имя контакта, второй — номер
телефона/e-mail.*/