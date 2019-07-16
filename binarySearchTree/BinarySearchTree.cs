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

        public bool Search(int key)
        {
            bool isFound = false;

            while((root.left != null || root.right != null)){
                if (key < root.key && root != null) {
                    root = root.left;
                    if (root == null) {
                    break;
                    }
                    if (root.key == key) {
                        isFound = true;
                    }
                }
                else if (key > root.key && root != null) {
                    root = root.right;
                    if (root == null) {
                    break;
                    }
                     if (root.key == key) {
                        isFound = true;
                    }
                }
                if (key == root.key && root != null) {
                isFound = true;
                break;
                }
            }

            return isFound;
        }
    }
}