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
            Console.WriteLine("\n 2. Insert More Element");
            Console.WriteLine("\n 3. Search Element");

            Console.WriteLine("Enter the Option");

            int num = Convert.ToInt32(Console.ReadLine());
            BST<int> BinarySearchTree = new BST<int>(20);

            switch (num)
            {
                case 1:
                    BinarySearchTree.Insert(30);
                    BinarySearchTree.Insert(40);
                    BinarySearchTree.Display();
                    break;
                case 2:
                    BinarySearchTree.Insert(50);
                    BinarySearchTree.Insert(45);
                    BinarySearchTree.Insert(46);
                    BinarySearchTree.Insert(89);
                    BinarySearchTree.Insert(11);
                    BinarySearchTree.Insert(8);
                    BinarySearchTree.Insert(16);
                    BinarySearchTree.Insert(60);
                    BinarySearchTree.Insert(95);
                    BinarySearchTree.Insert(65);
                    BinarySearchTree.Insert(63);
                    BinarySearchTree.Insert(67);
                   break;
                case 3:
                    BinarySearchTree.Insert(30);
                    BinarySearchTree.Insert(70);
                    BinarySearchTree.Insert(22);
                    BinarySearchTree.Insert(40);
                    BinarySearchTree.Insert(11);
                    BinarySearchTree.Insert(3);
                    BinarySearchTree.Insert(16);
                    BinarySearchTree.Insert(60);
                    BinarySearchTree.Insert(95);
                    BinarySearchTree.Insert(65);
                    BinarySearchTree.Insert(63);
                    BinarySearchTree.Insert(67);
                    BinarySearchTree.Display();
                    bool result = BinarySearchTree.IfExists(63, BinarySearchTree);
                    Console.WriteLine(result);
                    break;

                default:
                    Console.WriteLine("Enter the Valid Option");
                    break; 
            }
        }
    }
}
