using System;

namespace PzGraph
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 5;
            bool t = true;
            bool[,] matrix = { {false,true,true,false,false},
                {false,false,false,true,false},
                {false,true,false,false,true},
                {false,false,true,false,false},
                {false,false,false,true,false} 
            };
                
            Graph gr = new Graph(size, matrix);
            gr.Depth(1);
            for (int i = 0; i < size; i++)
            {
                if (!gr.Vector[i])
                {
                    Console.WriteLine("Граф не связный");
                    t = false;
                    break;
                }
            }
            if (t) Console.WriteLine("Граф связный");
        }

    }
    public class Graph
    {
        public int Size { get; set; }
        public bool[,] Adjacency { get; set; }
        public bool[] Vector { get; set; }

        public Graph(int size, bool[,] G)
        {
            Adjacency = new bool[size, size];
            Adjacency = G;
            Vector = new bool[size];
            for (int i = 0; i < size; i++)
                Vector[i] = false;
            Size = size;
        }
        public void Depth(int i)
        {
            Vector[i] = true;
            Console.Write("{0}" + ' ', i + 1);
            for (int j = 0; j < Size; j++)
                if (Adjacency[i, j] && !(Vector[j]))
                    Depth(j);
        }
    }

}
