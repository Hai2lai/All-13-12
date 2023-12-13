internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Menu :");
        Console.WriteLine("1. ve hinh tam giac");
        Console.WriteLine("2. ve hinh vuong");
        Console.WriteLine("3. ve hinh chu nhat");
        Console.WriteLine("0. de thoat");
        Console.WriteLine("Nhap lua chon cua ban");
        float n;
        do
        {
            n = float.Parse(Console.ReadLine());
            switch(n)
            {
                case 1: 
                Console.WriteLine("******");
                Console.WriteLine("*****");
                Console.WriteLine("****");
                Console.WriteLine("***");
                Console.WriteLine("**");
                Console.WriteLine("*");
                break;
                case 2:
                Console.WriteLine("* * * * * *");
                Console.WriteLine("* * * * * *");
                Console.WriteLine("* * * * * *");
                Console.WriteLine("* * * * * *");
                Console.WriteLine("* * * * * *");
                Console.WriteLine("* * * * * *");
                break;
                case 3:
                Console.WriteLine("* * * * * *");
                Console.WriteLine("* * * * * *");
                Console.WriteLine("* * * * * *");
                break;
                case 0:
                Console.WriteLine("Tam Biet");
                Environment.Exit(0);
                break;
                default:
                Console.WriteLine("ban nhap sai");
                break;
            }
        }while(n!=0);
    }
}