/******************************************************************************
Старовойтова 23ИС-21
Лабораторная 2
Вводится латинский символ. Ответить его названием 
*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
        Console.Write("Введите латинский символ: ");
        char symbol = Console.ReadKey().KeyChar;
        Console.WriteLine();
        switch (symbol) //определяем символ и выводим результат
        {
            case 'a':
                Console.WriteLine("a - это буква 'а'");
                break;
            case 'b':
                Console.WriteLine("b - это буква 'б'");
                break;
            case 'c':
                Console.WriteLine("c - это буква 'ц'");
                break;
            // и так далее с остальными символами
            default:
                Console.WriteLine("Неизвестный символ");
                break;
        }
        Console.ReadKey();

  }
}
