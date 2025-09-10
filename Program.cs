using System;

namespace TriangleDrawerApp
{
    class InputHandler
    {
        public static int GetTriangleSize()
        {
            int size;
            Console.Write("Enter the size of the triangle (positive integer): ");
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.Write("Invalid input. Please enter a positive integer: ");
            }
            return size;
        }
    }

    class TriangleDrawer
    {
        public void DrawRightAngledTriangle(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                Console.WriteLine(new string('*', i));
            }
        }
        
        public void DrawRightAngledTriangleFlipped(int size)
        {
            for (int i = size; i >= 1; i--)
            {
                Console.WriteLine(new string('*', i));
            }
        }

        public void DrawLeftAngledTriangle(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                string spaces = new string(' ', size - i);
                string stars = new string('*', i);
                Console.WriteLine(spaces + stars);
            }
        }
        public void DrawLeftAngledTriangleFlipped(int size)
        {
            for (int i = size; i >= 1; i--)
            {
                string spaces = new string(' ', size - i);
                string stars = new string('*', i);
                Console.WriteLine(spaces + stars);
            }
        }

        public void DrawEquilateralTriangle(int size)
        {
            for (int i = 1; i < size; i++)
            {
                string spaces = new string(' ', size - i);
                string stars = new string('*', 2 * i - 1);
                Console.WriteLine(spaces + stars + spaces);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int size = InputHandler.GetTriangleSize();
            TriangleDrawer drawer = new TriangleDrawer();

            Console.WriteLine("\nRight-Angled Triangle:");
            drawer.DrawRightAngledTriangle(size);

            Console.WriteLine("\nEquilateral Triangle:");
            drawer.DrawEquilateralTriangle(size);

            Console.WriteLine("\nFlipped Right-Angled Triangle:");
            drawer.DrawRightAngledTriangleFlipped(size);

            Console.WriteLine("\nLeft-Angled Triangle:");
            drawer.DrawLeftAngledTriangle(size);

            Console.WriteLine("\nFlipped Left-Angled Triangle:");
            drawer.DrawLeftAngledTriangleFlipped(size);
        }
    }
}