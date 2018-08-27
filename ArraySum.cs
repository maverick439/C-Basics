using System;
namespace HelloWorld
{
    class Hello
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
            int i,n;
            string n1 = Console.ReadLine();
            int.TryParse(n1,out n);
            int[] arr = new int[n];
            for(i=0;i<n;i++)
                int.TryParse(Console.ReadLine(),out arr[i]);
            int sum = 0;
            for(i=0;i<n;i++)
                sum+=arr[i];
            Console.WriteLine("Sum = "+sum);
            Console.Read();
        }
    }
}
