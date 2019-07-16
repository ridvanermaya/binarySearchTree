using System;

namespace binarySearchTree
{
    public class BinarySearchTree
    {
        // member variables
        public Node root;

        // constructor
        public BinarySearchTree()
        {
            root = null;
        }

        // member methods
        public void Add(int key)
        {
            Node node;
            Node temp = new Node(key);
            
            if (root == null) {
                root = temp;
            }

            node = root;

            while(node.left != null || node.right != null){
                if(key > node.key && node.right != null) {
                    node = node.right;
                }
                else if (key < node.key && node.left != null) {
                    node = node.left;
                }
                else {
                    break;
                }
            }
            
            if (key > node.key) {
                node.right = temp;
            }
            else if (key < node.key) {
                node.left = temp;
            }
        }

        public Node Search(int value)
        {
            Node node = new Node(value);
            return node;
        }
    }
}