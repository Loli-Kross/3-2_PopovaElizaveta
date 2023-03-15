using System;
using System.Collections.Generic;
using System.Text;

namespace PzBalance
{
    internal class BalanceTree
    {
        public Node Root { get; set; }

        public BalanceTree(int n)
        {
            Root = CreateBalanceTree(n);
        }

        public Node CreateBalanceTree(int n)
        {
            string text;
            Node root;

            if (n == 0)
                root = null;
            else
            {
                Console.WriteLine("Введите значение:");
                text = Console.ReadLine();

                root = new Node(text);
                root.Left = CreateBalanceTree(n / 2);
                root.Right = CreateBalanceTree(n - n / 2 - 1);
            }

            return root;
        }

        public static void BalanceInfo(Node root)
        {
            if (root != null)
            {
                Console.WriteLine(root.Info);
                BalanceInfo(root.Left);
                BalanceInfo(root.Right);
            }
        }

        public static void SredZnach(Node root, int n)
        {
            double sum = Sum(root);
            if (n != 0)
            {
                Console.WriteLine(sum / n);
            }
        }

        public static int Sum(Node root)
        {
            if (root == null)
            {
                return 0;
            }
            return Sum(root.Left) + Convert.ToInt32(root.Info) + Sum(root.Right);
        }

        public static int CountPlus(Node root)
        {
            int g = 0;

            if (root != null)
            {
                if ((Convert.ToInt32(root.Info) > 0)) g++;
                g += CountPlus(root.Left);
                g += CountPlus(root.Right);
            }
            return g;
        }
        public static int CountMin(Node root)
        {
            int g = 0;

            if (root != null)
            {
                if ((Convert.ToInt32(root.Info) < 0)) g++;
                g += CountMin(root.Left);
                g += CountMin(root.Right);
            }
            return g;
        }

        public static int CountVhod(Node root, int n)
        {
            int g = 0;

            if (root != null)
            {
                if ((Convert.ToInt32(root.Info) == n)) g++;
                g += CountVhod(root.Left, n);
                g += CountVhod(root.Right, n);
            }
            return g;
        }
    }

}
