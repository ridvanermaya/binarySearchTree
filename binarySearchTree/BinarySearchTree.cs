namespace binarySearchTree
{
    public class BinarySearchTree
    {
        // member variables
        Node root = null;

        // constructor

        // member methods
        public void Add(int key)
        {
            Node node;
            Node temp = new Node(key);
            
            node = root;
            while(){

            }
            if(key > root.key) {
                node.right = temp;
            }
            else if (key < root.key) {

            }
        }

        public void AddFirstNode(int key)
        {
            Node temp = new Node(key);
            root = temp;
        }

        public Node Search(int value)
        {
            Node node = new Node(value);
            return node;
        }
    }
}