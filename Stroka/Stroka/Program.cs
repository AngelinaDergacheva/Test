using System;

namespace Stroka
{
    class Program
    {
        private string str = "";
        private int UpperCount = 0;
        private int LowerCount = 0;
        public string vvod()
        {
            Console.WriteLine("Введите строку");
            str = Console.ReadLine();
            return str;
        }
        public void poisk()
        {
            foreach (var symbol in str)
            {
                if (char.IsUpper(symbol))
                    UpperCount++;
                else
                    if (char.IsLower(symbol))
                    LowerCount++;
              
            }
            Console.WriteLine("Количество строчных символов = " + LowerCount+ " Количество прописных символов = "+ UpperCount);
        }
        static void Main(string[] args)
        {
          
            Program p = new Program();
            Console.WriteLine("Ваща строка: "+ p.vvod());
            p.poisk();
        }
    }
}
