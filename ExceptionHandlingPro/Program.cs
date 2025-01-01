using ExceptionHandlingPro;

namespace ExceptionHandlingPro
{
internal class Program
{
    public delegate int calc(int a, int b);
    private static void Main(string[] args)
    {
        //try
        //{
        //    Console.Write("Enter first number :");
        //    int a = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Enter Second number :");
        //    int b = Convert.ToInt32(Console.ReadLine());
        //    int c = a / b;
        //    Console.WriteLine("Quotient is " + c);
        //}
        //catch(Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
        //finally
        //{
        //    Console.WriteLine("Thank You");
        //}

        //calc d;
        //Calculate c = new Calculate();
        //d = c.Add;
        //d(20, 20);
        //d = c.Sub;
        //d(20, 21);


        //Subscriber s=new Subscriber();
        //s.dowork();


        Counter.Increment c = new Counter.Increment();
        c.doIncrement();
    }
}
}