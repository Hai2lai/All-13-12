internal class Program
{
    private static void Main(string[] args)
    {
        float n;
        Console.WriteLine("nhap 1 so ban muon kiem tra");
        n = float.Parse(Console.ReadLine());
        if(n<2)
        {
            Console.WriteLine(n+"khong phai la so nguyen to");
        }else 
        {   
            bool kiemtra = true;
            int i=2;
            while(i<=Math.Sqrt(n))
            {
                if(n%i==0){
                    kiemtra = false;
                    break;
                }
                i++;
            }
            if(kiemtra)
            {
                Console.WriteLine("day la so nguyen to");
            }else
            {
                Console.WriteLine("day khong phai la so nguyen to");
            }
        }
    }
}