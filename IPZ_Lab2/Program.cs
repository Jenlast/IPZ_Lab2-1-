namespace Lab2
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            input:
                Console.Write("Введіть дробове бінарне число: ");
                string binary = Console.ReadLine();
                if (!IsBinaryFractional(binary))
                {
                    Console.WriteLine("Некоректні дані, очікується дробове бінарне число.");
                    goto input;
                }
            Console.WriteLine($"Десяткове значення: {BinToDec(binary)}");
        }
        static double BinToDec(string binary)
        {
            double dec = 0;
            double power = -1;

            for (int i = 2; i < binary.Length; i++)
            {
                if (binary[i] == '1')
                {
                    dec += Math.Pow(2, power);
                }
                power--;
            }
            return dec;
        }
        static bool IsBinaryFractional(string binary)
        {
            foreach (var i in binary)
            {
                if (i != '0' && i != '1' && i != '.')
                    return false;
            }
            if (binary == "0.")
                return false;
            if (!binary.StartsWith("0."))
                return false;
            return true;
        }
    }
}