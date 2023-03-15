using System;

namespace PzBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество вершин");
            int n = Convert.ToInt32(Console.ReadLine());

            BalanceTree tree = new BalanceTree(n);

            Console.Write("Среднее значение:");
            BalanceTree.SredZnach(tree.Root, n);
            Console.WriteLine("Положительные числа: " + BalanceTree.CountPlus(tree.Root));
            Console.WriteLine("Отрицательные числа: " + BalanceTree.CountMin(tree.Root));

            Console.Write("Введите число для поиска:");
            int vhozhdenie = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Количество вхождений числа {vhozhdenie}: " + BalanceTree.CountVhod(tree.Root, vhozhdenie));
        }
    }

}
