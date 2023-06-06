namespace FinalTestModule_10
{
    //Определяем интерфейс
    public interface ISum
    {
        int Sum(int a, int b);
    }

    class Calculate : ISum
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }

    }

    class Program
    {
        static int Messeng()
        {
            Console.Write("Введите число : ");
            int num = int.Parse(Console.ReadLine());
            return num;
        }

        static void Main(string[] args)
        {
            try
            {
                int a = Messeng();
                int b = Messeng();

                Calculate calculate = new Calculate();
                Console.WriteLine($"{a} + {b} = {calculate.Sum(a, b)}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Вы ввели не цифру !");
            }
        }
    }
}

