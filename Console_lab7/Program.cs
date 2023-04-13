
namespace Console_lab7
{
    internal class Program
    {
        static void Main()
        {
            //Task1
            Console.Write("Enter size your array: ");
            int s = int.Parse(Console.ReadLine());
            Array Myarray = new Array(s);
            Myarray.Show();


            Console.Write("information message: ");
            string inform = Console.ReadLine();
            Myarray.Show(inform);
        }
    }
}