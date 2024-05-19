using System;

namespace HW___Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var library1 = new Library();
            library1 += new Book("Сталкер: Холодная кровь", "Глушков Р.А.");
            library1 += new Book("Сталкер: Сердце зоны", "Левицкий А.Ю.");

            Console.WriteLine("Книги в библиотеке:");
            library1.Print();            
            Console.WriteLine("Нажмите любую клавиншу для продолжения...\n");
            Console.ReadKey(true);
            

            Console.WriteLine("Введите книгу и автора для добавления книги в библиотеку: ");
            library1 += new Book(Console.ReadLine(), Console.ReadLine());
            library1.Print();
            Console.WriteLine("Нажмите любую клавиншу для продолжения...\n");
            Console.ReadKey(true);
            

            Console.WriteLine("Проверяем наличие книги и удаляем её. ");          
            Console.WriteLine("Сталкер: Холодная кровь: " + library1.ContainsBook("Сталкер: Холодная кровь"));
            library1 -= "Сталкер: Холодная кровь";
            Console.WriteLine("Список книг: ");
            library1.Print();            
            Console.WriteLine("Нaжмите любую клавишу для продолжения...");
            Console.WriteLine();
            Console.ReadKey(true);
            Console.Clear();


            Console.WriteLine("Матрицы делал ранее во 2 домашке, тут копипаст.....");
            Console.WriteLine("Создаем две матрицы и заполняем случайными числами.");
            Random random = new Random();
            int[,] matrix1 = new int[5, 5];
            int[,] matrix2 = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix1[i, j] = random.Next(1, 10);
                    matrix2[i, j] = random.Next(11, 20);
                }
            }

            Console.WriteLine("Матрица 1:");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("{0,6}", matrix1[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Матрица 2:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("{0,6}", matrix2[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Умножаем матрицу на число.");
            Console.Write("Введите число на которое хотите умножить матрицу ->");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix1[i, j] *= n;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Результат умножения матрицы на " + n);
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("{0,6}", matrix1[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Складываем матрицы 1 и 2.");
            int[,] matrixResult = new int[5, 5];  //новая матрица для созранени результатов операций

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrixResult[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            Console.WriteLine("Результат сложения матриц:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("{0,6}", matrixResult[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Произведение матриц 1 и 2.");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrixResult[i, j] = matrix1[i, j] * matrix2[i, j];
                }
            }


            Console.WriteLine("Результат произведения матриц:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("{0,6}", matrixResult[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Нaжмите любую клавишу для продолжения...");
            Console.WriteLine();
            Console.ReadKey(true);
            Console.Clear();
        }
    }
}
