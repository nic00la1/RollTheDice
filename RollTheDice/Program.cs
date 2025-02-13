namespace RollTheDice
{
    namespace GraKosci
    {
        class Program
        {
            static void Main(string[] args)
            {
                List<int> rzuty = new List<int>();
                bool repeat = true;
                Random rnd = new Random();
                int count = 0;
                int suma = 0;
                while (repeat)
                {
                    Console.WriteLine("Ile kostek chcesz rzucic? (3 - 10)");
                    count = Convert.ToInt32(Console.ReadLine());
                    if (count >= 3 && count <= 10)
                    {
                        rzuty.Clear();
                        suma = 0;
                        for (int i = 0; i < count; i++)
                        {
                            int result = rnd.Next(1, 7);
                            rzuty.Add(result);

                            Console.WriteLine($"Kostka {i + 1}: {rzuty[i]}");
                        }

                        /*Sprawdza czy dany wynik się już powtórzył. Jezeli tak to dodaje go do siebie */
                        for (int i = 0; i < rzuty.Count; i++)
                        {
                            bool isMultiply = false;
                            for (int y = 0; y < rzuty.Count; y++)
                            {
                                if (rzuty[i] == rzuty[y] && i != y)
                                {
                                    isMultiply = true;

                                }
                            }

                            if (isMultiply)
                            {
                                suma += rzuty[i];
                            }
                        }

                        Console.WriteLine($"Liczba uzyskanych punktów: {suma}");
                        Console.WriteLine("Jeszcze raz? (t/n)");
                        bool odp = Console.ReadLine() == "t" ? true : false;

                        if (!odp)
                        {
                            repeat = false;
                        }

                    }
                }


            }
        }
    }
}