internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("nhap lua chon cua ban");
        Console.WriteLine("1. ve hinh chu nhat");
        Console.WriteLine("2. ve hinh tam giac vuong");
        Console.WriteLine("3. ve hinh tam giac can");
        Console.WriteLine("4. THOAT");
        int n;
        int i=43;
        while(i!=0)
        {
            n = int.Parse(Console.ReadLine()); 
            switch (n)
            {
                case 1:
                Hinhchunhat();
                break;
                case 2:
                tamgiacvuong();
                break;
                case 3:
                tamgiaccan();
                break;
                case 4:
                Console.WriteLine("Tam Biet Ban");
                i=0;
                break;
                default: Console.WriteLine("ban nhap sai");
                break;
            }
        }
           
    }
    public static void Hinhchunhat()
    {
        for(int i=0;i<3;i++)//cột dọc
        {
            for(int j=0;j<7;j++)//hàng ngang
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
    public static void tamgiacvuong()
    {
        for(int i=1;i<=5;i++)
        {
            for(int j=1;j<=i;j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
    public static void tamgiaccan()
    {
        for(int i=1;i<=5;i++)
        {
            for(int j=1;j<=5-i;j++)
            {
                Console.Write("  ");
            }
            for(int k=1;k<=2*i-1;k++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}