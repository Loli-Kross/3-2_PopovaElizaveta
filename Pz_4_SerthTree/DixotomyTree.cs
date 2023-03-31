using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Pz_4_SerthTree
{
    class DixotomyTree
    {
        private DTreeNode root; 
        public DTreeNode Root 
        {
            get { return root; }
            set { root = value; }
        }
        public DixotomyTree() 
        {
            root = null;
        }
        public static DTreeNode Insert_DNode(DTreeNode root, int k, int a)
        {
            if (root == null)
            {
                return new DTreeNode(k, a);
            }
            else
            {
                if (k < root.Key)
                    root.Left = Insert_DNode(root.Left, k, a);
                else if (k > root.Key)
                    root.Right = Insert_DNode(root.Right, k, a);
                else
                    Console.WriteLine($"узел с ключом {k} уже есть в дереве");
            }
            return root;
        }

        public static int Sum(DTreeNode treenode)
        {
            if (treenode == null)
                return 0;
            return treenode.Key + Sum(treenode.Left) + Sum(treenode.Right);
        }
        public static int VnutrennieNode(DTreeNode node)
        {
            if (node == null)
                return 0;
            else if (node.Left == null && node.Right == null)
                return 0;
            else
                return 1 + VnutrennieNode(node.Left) + VnutrennieNode(node.Right);

        }
        public static List<int> SerchtMInNode(DTreeNode node)
        {

            List<int> result = new List<int>();

            if (node == null)
                return result;


            if (node.Key < 0) // Проверка отрицательности
            {
                result.Add(node.Key);
                Console.WriteLine($"Узел: {node.Info}, Отрицательное: {result.Count}: {node.Key} ");

            }
            else
            {
                Console.WriteLine($"Узел: {node.Info}, Отрицательное: {result.Count}: {node.Key} ");

            }

            result.AddRange(SerchtMInNode(node.Left));
            result.AddRange(SerchtMInNode(node.Right));

            return result;
        }
    }
}
