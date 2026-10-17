namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //dikdörtgen alan hesabı
            Console.Write("kısakenar:");
            string a = Console.ReadLine();
            int kısakenar = Convert.ToInt32(a);
            Console.Write("uzun kenar:");
            string b = Console.ReadLine();
            int uzunkenar = Convert.ToInt32(b);
            int alan = kısakenar * uzunkenar / 2;
            Console.WriteLine("dikdörgenin alanı:" + alan);
        }
    }
}