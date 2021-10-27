using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab18
{
    /*Дана строка, содержащая скобки трех видов (круглые, квадратные, фигурные) и любые другие символы. Проверить, корректно ли расставлены скобки.
      Например, в строке ([]{})[] скобки расставлены корректно, а в строке ([]] — нет.
      Задача решается однократным проходом по символам заданной строки слева направо; для каждой открывающей скобки в стек помещается соответствующая закрывающая,
      каждая закрывающая скобка в строке должна соотвествовать скобке из вершины стека (при этом скобка с вершины стека снимается); в конце прохода стек должен быть пуст*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку, содержащую круглые, квадратные и фигурные скобки");      // можно скопировать из описания задачи
            string s = Console.ReadLine();
            bool b = true;
            Stack<char> bracket = new Stack<char>();
            foreach (char i in s)
            {
                if (i == '(')
                {
                    bracket.Push(')');
                }
                if (i == '[')
                {
                    bracket.Push(']');
                }
                if (i == '{')
                {
                    bracket.Push('}');
                }
                if (bracket.Count > 0 && i == bracket.Peek())
                {
                    bracket.Pop();
                    continue;
                }
                if (i == ')' || i == ']' || i == '}' && bracket.Count == 0)     // на случай закрывающей скобки перед открывающей, либо без неё
                {
                    b = false;
                }
            }
            if (bracket.Count == 0 && b == true)
            {
                Console.WriteLine("Скобки расставлены корректно");
            }
            else
            {
                Console.WriteLine("Скобки расставлены не корректно");
            }            
            Console.WriteLine("Для завершения нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
