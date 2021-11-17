using System;
   public  class Program
    {
        static void Main()
        {
        Action<int, int> del1 = (x, y) => { Console.WriteLine($"Addition is{x + y}"); };
        Func<string, string> del2 = (str) => { return $"Mr.{str}"; };
        Console.WriteLine(del2("nazeerudin"));
        Func<string, string, string> del3 = (str1, str2) => $"{str1} {str2}";
        Console.WriteLine(del3("soumya", "vadlmudi"));
         string[] names = { "Hema", "Varalaxmi", "Mounika", "Geetha" };
        Predicate<string> del4 = (str) => { return str.Equals("Geetha"); };
        string s = Array.Find(names, del4);
        if (s == null)
            Console.WriteLine("not found");
        else
            Console.WriteLine($"{s} found in the names collection");

//        Console.WriteLine("Hello World!");
        }
    }

