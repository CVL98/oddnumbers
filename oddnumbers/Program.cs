namespace oddnumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(";");
            int[] intput = new int[input.Length];
            int evensum = default;
            int oddsum = default;

            for (int i = 0; i < intput.Length; i++)
            {
                intput[i] = int.Parse(input[i]);
                if (intput[i]%2 == 0)
                {
                    Console.WriteLine($"Hey, I found the even number {intput[i]}!");
                    evensum += intput[i];
                }
                else
                {
                    Console.WriteLine($"Oi, I found the odd number {intput[i]}");
                    oddsum += intput[i];
                }
            }
            Console.WriteLine($"\n\nThe sum of all odds are {oddsum}");
            Console.WriteLine($"The sum of all evens are {evensum}");
        }
    }
}