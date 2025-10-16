using System.ComponentModel.DataAnnotations;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
        Console.Write("Nhập vào n: ");
        int n = int.Parse(Console.ReadLine());

        if ((n % 4 == 0 && n % 100 != 0) || (n % 400 == 0))
            Console.WriteLine($"{n} là năm nhuận");
        */
        /*
        Console.Write("Nhập vào số x: ");
        float x = float.Parse(Console.ReadLine());
        if (x > 0)
            Console.WriteLine(1);
        else if (x == 0)
            Console.WriteLine(0);
        else
            Console.WriteLine(-1);
        */
        /*
        Console.WriteLine("Nhập vào 5 số: ");
        float x = float.Parse(Console.ReadLine());
        float y = float.Parse(Console.ReadLine());
        float z = float.Parse(Console.ReadLine());
        float t = float.Parse(Console.ReadLine());
        float u = float.Parse(Console.ReadLine());
        float max = x;
        if (y > max)
            max = y;
        if (z > max)
            max = z;
        if (t > max)
            max = t;
        if (u > max)
            max = u;
        Console.WriteLine($"Max là {max}");
        */
        /*
        Console.WriteLine("Nhập các hệ số a, b, c: ");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if (a == 0)
        {
            if (b != 0)
            {
                double x = -c / b;
                Console.Write("Đây là phương trình bậc nhất, x = " + x);
            }
            else
                if (c == 0)
                Console.Write("PT VSN");
            else
                Console.Write("PTVN");
        }
        else
        {
            double delta = (b * b) - (4 * a * c);
            if (delta > 0)
            {
                double nghiemmot = (-b + Math.Sqrt(delta)) / (2 * a);
                double nghiemhai = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.Write("Nghiem cua PT bac 2 la: " + nghiemmot + " va " + nghiemhai);
            }
            else if (delta == 0)
            {
                double nghiemkep = -b / (2 * a);
                Console.Write("Nghiem kep cua PT bac 2 la: " + nghiemkep);
            }
            else
                Console.Write("PTVN");
        }
        */
        Console.WriteLine("Nhập 3 số a, b, c: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int max = a;
        if (max > b)
            max = b;
        if (max > c)
            max = c;
        if (a + b > c && a + c > b && b + c > a)
        {
            if (a == b && b == c)
                Console.WriteLine("tam giac deu");
            else if (a == b || b == c || a == c)
            {
                if (a * a + b * b + c * c == 2 * max * max)
                    Console.WriteLine("Đây là tam giác vuông cân");
                else
                    Console.WriteLine("Tam giác cân");

            }
            else if (a * a + b * b + c * c == 2 * max * max)
                Console.WriteLine("Tam giác vuông");
            else
                Console.WriteLine("Tam giác thường");
        }
        else
            Console.WriteLine("Đây không là tam giác");
    }
}