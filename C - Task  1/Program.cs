using System;

namespace C___Task__1
{
    class Program
    {
        static void Main(string[] args)

            //Istifadeciden alinacaq iki eded arasinda ededlerin toplami. 
        {
            
            int a = 0;
            int b = 0;
            int cem = 0;
            bool iscountinue = true;

            do
            {
                
            Console.WriteLine("Birinci ededi daxil edin: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ikinci ededi daxil edin:  ");
            b = int.Parse(Console.ReadLine());

            for (int i = a; i < b; i++)
            {
                cem +=i;
            }

            Console.WriteLine("Iki eded arasindaki ededlerin cemi: " + cem);

            Console.WriteLine("Yeniden eded daxil etmek isteyirsinizmi?:  (He ve ya Yox daxil edin)");
            string result = Console.ReadLine();
            if (result == "Yox")
            {
                iscountinue = false;
            }

            } while (iscountinue);


        }
    }
}
