using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Tree Search Program ");
            Console.WriteLine("\n 1. Insertion");
            Console.WriteLine("Enter the the 1");
            int num = Convert.ToInt32(Console.ReadLine());
            BST<int> BinarySearchTree = new BST<int>(20);

            switch (num)
            {
                case 1:
                    BinarySearchTree.Insert(30);
                    BinarySearchTree.Insert(40);
                    BinarySearchTree.Display();
                    break;
                default:
                    break; 
            }
        }
    }
}
