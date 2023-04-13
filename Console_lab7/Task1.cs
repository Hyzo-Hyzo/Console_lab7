using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_lab7
{
    interface IOutput
    {
        void Show();
        void Show(string info);
    }

    class Array : IOutput
    {
        public int Size { get; set; }
        public Array(int size)
        {
            this.Size = size;
        }

        public void Show()
        {
            int[] arr = new int[Size];
            Random rnd = new Random();
            Console.Write("Array: ");
            for (int i = 0; i < Size; i++)
            {
                arr[i] = rnd.Next(1, 25);
                Console.Write(arr[i] + "  ");
            }
        }
        public void Show(string inform)
        {
            Show();
            Console.WriteLine($"Information message: {inform}");
        }
    }
}
