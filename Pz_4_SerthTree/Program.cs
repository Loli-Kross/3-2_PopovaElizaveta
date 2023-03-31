using System;
using System.Collections.Generic;

namespace Pz_4_SerthTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            DTreeNode root = null;
            for (int i = 0; i < 10; i++)
            {
                int a = random.Next(-1000, 1000);
                root = DixotomyTree.Insert_DNode(root, 1 + i, a);

            }
            Console.WriteLine($"Сумма инвормационных полей: {DixotomyTree.Sum(root)}");
            Console.WriteLine();

            //Задание 2
            Console.WriteLine($"Внутренние узлы дерева: {DixotomyTree.VnutrennieNode(root)}");
            Console.WriteLine();

            //Задание 3 
            List<int> negativeValues = DixotomyTree.SerchtMInNode(root);
            Console.WriteLine($"Отрицательные значения информационных полей дерева: {negativeValues.Count}");
            Console.WriteLine();

            foreach (var value in negativeValues)
            {
                Console.Write($"{value}, ");
            }
            Console.WriteLine(); Console.WriteLine();
        }

    }
}
