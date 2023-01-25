using System; 
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vilkt år är det? "); 
            int år = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Det är " + (2100-år) + " år till 2100");


        }

    }


}
