using System;

namespace binarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree binarySearch = new BinarySearchTree();

            binarySearch.Add(100);
            binarySearch.Add(50);
            binarySearch.Add(125);
            binarySearch.Add(76);
            binarySearch.Add(101);
            binarySearch.Add(25);
            binarySearch.Add(129);
            binarySearch.Add(127);
            binarySearch.Add(126);

            bool found = binarySearch.Search(100000);
            Console.WriteLine(found);
        }
    }
}